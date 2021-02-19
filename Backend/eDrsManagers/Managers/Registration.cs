﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using eDrsDB.Data;
using eDrsDB.Models;
using eDrsManagers.ApiConverters;
using eDrsManagers.Interfaces;
using LrApiManager.SOAPManager;
using LrApiManager.SOAPManager.Restriction;
using LrApiManager.XMLClases;
using LrApiManager.XMLClases.Restriction;
using LrApiManager.XMLClases.TransferOfPart;
using Microsoft.EntityFrameworkCore;
using Party = eDrsDB.Models.Party;

namespace eDrsManagers.Managers
{
    public class Registration : IRegistration
    {
        private readonly RestrictionRequestManager _restrictionServiceManager = new RestrictionRequestManager();
        private readonly RestrictionPollRequest _restrictionPoolRequest = new RestrictionPollRequest();
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IRestrictionConverter _restrictionConverter;

        public Registration(AppDbContext context, IMapper mapper, IRestrictionConverter restrictionConverter)
        {
            _context = context;
            _mapper = mapper;
            _restrictionConverter = restrictionConverter;
        }


        public List<RegistrationType> GetRegistrationTypes()
        {
            return _context.RegistrationTypes.Where(s => s.Status).ToList();
        }

        public ApplicationResponse CreateRegistration(DocumentReference viewModel)
        {

            viewModel.Parties.ToList().ForEach(party =>
            {
                party.Roles = string.Join(",", party.ViewModelRoles);

            });
            viewModel.MessageID = Guid.NewGuid().ToString();
            _context.DocumentReferences.Add(viewModel);

            _context.SaveChanges();

            var requestXml = _restrictionConverter.ArrangeLrApi();
            var applicationResponse = _restrictionServiceManager.RequestRestrictionApplication(requestXml);

            var requestLog = new RequestLog()
            {
                Type = "Application",
                TypeCode = applicationResponse.TypeCode,
                Description = applicationResponse.Acknowledgement.MessageDescription,
                DocumentReferenceId = viewModel.DocumentReferenceId
            };
            _context.RequestLogs.Add(requestLog);
            _context.SaveChanges();

            return applicationResponse;
        }

        public ApplicationResponse UpdateRegistration(DocumentReference viewModel)
        {
            viewModel.Parties.ToList().ForEach(party =>
            {
                party.Roles = string.Join(",", party.ViewModelRoles);

            });

            var deletingTitle = _context.TitleNumbers
                .Where(x => !viewModel.Titles.Select(s => s.TitleNumberId).ToList().Contains(x.TitleNumberId) && x.DocumentReferenceId == viewModel.DocumentReferenceId).ToList();

            var deletingApplications = _context.ApplicationForms
                .Where(x => !viewModel.Applications.Select(s => s.ApplicationFormId).ToList().Contains(x.ApplicationFormId) && x.DocumentReferenceId == viewModel.DocumentReferenceId).ToList();

            var deletingSupportingDocuments = _context.SupportingDocuments
                .Where(x => !viewModel.SupportingDocuments.Select(s => s.SupportingDocumentId).ToList().Contains(x.SupportingDocumentId) && x.DocumentReferenceId == viewModel.DocumentReferenceId).ToList();

            var deletingParties = _context.Parties
                .Where(x => !viewModel.Parties.Select(s => s.PartyId).ToList().Contains(x.PartyId) && x.DocumentReferenceId == viewModel.DocumentReferenceId).ToList();

            var deletingNotes = _context.AttachmentNotes
                .Where(x => !viewModel.AttachmentNotes.Select(s => s.AttachmentNotesId).ToList().Contains(x.AttachmentNotesId) && x.DocumentReferenceId == viewModel.DocumentReferenceId).ToList();


            _context.TitleNumbers.RemoveRange(deletingTitle);
            _context.ApplicationForms.RemoveRange(deletingApplications);
            _context.SupportingDocuments.RemoveRange(deletingSupportingDocuments);
            _context.Parties.RemoveRange(deletingParties);
            _context.AttachmentNotes.RemoveRange(deletingNotes);

            _context.DocumentReferences.Update(viewModel);

            _context.SaveChanges();
            var requestXml = _restrictionConverter.ArrangeLrApi();
            ApplicationResponse applicationResponse = _restrictionServiceManager.RequestRestrictionApplication(requestXml);

            var requestLog = new RequestLog()
            {
                Type = "Application",
                TypeCode = applicationResponse.TypeCode,
                Description = applicationResponse.Acknowledgement.MessageDescription,
                DocumentReferenceId = viewModel.DocumentReferenceId
            };
            _context.RequestLogs.Add(requestLog);
            _context.SaveChanges();

            return applicationResponse;

        }


        public bool DeleteRegistration(long regId)
        {
            var deleteObject = _context.DocumentReferences.FirstOrDefault(s => s.DocumentReferenceId == regId);
            if (deleteObject != null) deleteObject.Status = false;
            return _context.SaveChanges() > 0;
        }

        public RegistrationType GetRegistrationType(long regType)
        {
            return _context.RegistrationTypes.FirstOrDefault(s => s.RegistrationTypeId == regType);
        }


        public List<DocumentReference> GetRegistrations(string regType)
        {
            return _context.DocumentReferences.Where(s => s.Status && s.RegistrationTypeId == int.Parse(regType))
                .ToList();
        }

        public RestrictionPollResponse GetPollResponse(long regId)
        {

            var docRef = _context.DocumentReferences.FirstOrDefault(x => x.DocumentReferenceId == regId);
            var response = _restrictionPoolRequest.PoolRequest(docRef.MessageID);

            var requestLog = new RequestLog()
            {
                Type = "Poll",
                TypeCode = Convert.ToInt32(response.TypeCode),
                Description = response.Results.FirstOrDefault().MessageDetails,
                File = response.Results.FirstOrDefault().DespatchDocument.FirstOrDefault().byteArray,
                DocumentReferenceId = docRef.DocumentReferenceId
            };
            _context.RequestLogs.Add(requestLog);
            _context.SaveChanges();
            return response;

        }

        public DocumentReference GetRegistration(long regId)
        {
            var documentReference =
                _context.DocumentReferences.Include(x => x.SupportingDocuments)
                    .Include(x => x.Applications)
                    .Include(x => x.Parties)
                    .Include(x => x.Titles)
                    .Select(sel => new DocumentReference
                    {
                        DocumentReferenceId = sel.DocumentReferenceId,
                        Email = sel.Email,
                        Notes = sel.Notes,
                        AP1WarningUnderstood = sel.AP1WarningUnderstood,
                        Titles = sel.Titles.Select(s => new TitleNumber
                        {
                            UpdatedDate = s.UpdatedDate,
                            Status = s.Status,
                            DocumentReferenceId = s.DocumentReferenceId,
                            TitleNumberId = s.TitleNumberId,
                            CreatedDate = s.CreatedDate,
                            TitleNumberCode = s.TitleNumberCode,

                        }).ToList(),
                        RegistrationTypeId = sel.RegistrationTypeId,
                        ApplicationAffects = sel.ApplicationAffects,
                        ApplicationDate = sel.ApplicationDate,
                        Applications = sel.Applications.Select(app => new ApplicationForm
                        {
                            ApplicationFormId = app.ApplicationFormId,
                            DocumentReferenceId = app.DocumentReferenceId,
                            FeeInPence = app.FeeInPence,
                            Priority = app.Priority,
                            Type = app.Type,
                            Value = app.Value,
                            ExternalReference = app.ExternalReference,
                            Document = app.Document,
                            CertifiedCopy = app.CertifiedCopy
                        }).ToList(),
                        DisclosableOveridingInterests = sel.DisclosableOveridingInterests,
                        LocalAuthority = sel.LocalAuthority,
                        TotalFeeInPence = sel.TotalFeeInPence,
                        TelephoneNumber = sel.TelephoneNumber,
                        SupportingDocuments = sel.SupportingDocuments.Select(sup => new SupportingDocuments
                        {
                            CertifiedCopy = sup.CertifiedCopy,
                            SupportingDocumentId = sup.SupportingDocumentId,
                            DocumentReferenceId = sup.DocumentReferenceId,
                            DocumentName = sup.DocumentName,
                            DocumentId = sup.DocumentId
                        }).ToList(),
                        PostcodeOfProperty = sel.PostcodeOfProperty,
                        Reference = sel.Reference,
                        MessageID = sel.MessageID,
                        Parties = sel.Parties.Select(party => new Party
                        {
                            Surname = party.Surname,
                            PartyType = party.PartyType,
                            IsApplicant = party.IsApplicant,
                            DocumentReferenceId = party.DocumentReferenceId,
                            CompanyOrForeName = party.CompanyOrForeName,
                            PartyId = party.PartyId,
                            Roles = party.Roles
                        }).ToList(),
                        Status = sel.Status,
                        AdditionalProviderFilter = sel.AdditionalProviderFilter,
                        ExternalReference = sel.ExternalReference,
                        Password = sel.Password,
                        AttachmentNotes = sel.AttachmentNotes,
                        RequestLogs = sel.RequestLogs

                    })
                    .FirstOrDefault(s => s.Status && s.DocumentReferenceId == regId);

            return documentReference;

        }

    }
}