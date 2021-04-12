using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BusinessGatewayModels;
using BusinessGatewayRepositories.AttachmentServiceRequest;
using BusinessGatewayRepositories.EDRSApplication;
using BusinessGatewayServices;
using eDRS_Land_Registry.Models;
using eDrsDB.Models;
using CertifiedTypeContent = BusinessGatewayRepositories.EDRSApplication.CertifiedTypeContent;
using DocumentNameContent = BusinessGatewayRepositories.EDRSApplication.DocumentNameContent;

namespace eDRS_Land_Registry.ApiConverters
{

    public class RestrictionConverter
    {
        Services _services = new Services();
        Search[] _search_array = new Search[1];
        RequestApplicationToChangeRegisterV1_0Type _request = new RequestApplicationToChangeRegisterV1_0Type();
        ProductType _product = new ProductType();


        public RestrictionConverter()
        {
        }

        public RequestApplicationToChangeRegisterV1_0Type ArrangeLrApi(DocumentReference docRef)
        {

            _request.ExternalReference = docRef.ExternalReference;
            _request.MessageId = docRef.MessageID;

            _product.Reference = docRef.Reference;
            _product.TotalFeeInPence = docRef.TotalFeeInPence.ToString();
            _product.Email = docRef.Email;
            _product.TelephoneNumber = docRef.TelephoneNumber.ToString();
            _product.AP1WarningUnderstood = docRef.AP1WarningUnderstood;
            _product.ApplicationDate = docRef.ApplicationDate;
            _product.PostcodeOfProperty = docRef.PostcodeOfProperty;
            _product.DisclosableOveridingInterests = docRef.DisclosableOveridingInterests;



            #region TitleNumbers

            var titleList = new List<string>();

            docRef.Titles.ToList().ForEach(x =>
            {
                titleList.Add(x.TitleNumberCode);
            });

            var titlesType = new TitlesType()
            {
                TitleNumber = titleList.ToArray()
            };

            _product.Titles = titlesType;
            #endregion

            #region OtherApplication

            var applications = new List<ApplicationType>();

            docRef.Applications.ToList().ForEach(x =>
            {
                if (x.Variety == "other")
                {
                    applications.Add(new OtherApplicationType()
                    {
                        Document = new DocumentType { CertifiedCopy = (CertifiedTypeContent)Enum.Parse(typeof(CertifiedTypeContent), x.CertifiedCopy) },
                        Priority = x.Priority.ToString(),
                        Value = x.Value,
                        FeeInPence = x.FeeInPence.ToString()
                    });
                }
                else if (x.Variety == "charge")
                {
                    object item = x.IsMdRef == "no" ? x.MdRef : new NoMDRefType().ToString();
                    applications.Add(new ChargeApplicationType()
                    {
                        Document = new DocumentType { CertifiedCopy = (CertifiedTypeContent)Enum.Parse(typeof(CertifiedTypeContent), x.CertifiedCopy) },
                        Priority = x.Priority.ToString(),
                        Value = x.Value,
                        FeeInPence = x.FeeInPence.ToString(),
                        ChargeDate = x.ChargeDate,
                        SortCode = x.SortCode,
                        Item = item
                    });
                }

            });

            _product.Applications = applications.ToArray();

            #endregion

            #region Supporting Documents

            //supporting documnets
            SupportingDocumentsType supportingDocuments = new SupportingDocumentsType();
            var supportingDocumentTypes = new List<SupportingDocumentType>();

            docRef.SupportingDocuments.ToList().ForEach(x =>
            {
                supportingDocumentTypes.Add(new SupportingDocumentType()
                {
                    CertifiedCopy = (CertifiedTypeContent)Enum.Parse(typeof(CertifiedTypeContent), x.CertifiedCopy),
                    DocumentId = x.DocumentId.ToString(),
                    DocumentName = (DocumentNameContent)Enum.Parse(typeof(DocumentNameContent), x.DocumentName),

                });
            });
            supportingDocuments.SupportingDocument = supportingDocumentTypes.ToArray();

            _product.SupportingDocuments = supportingDocuments;

            #endregion

            #region Representations

            //Representations

            RepresentationsType representations = new RepresentationsType();

            List<RepresentingConveyancerType> representingConveyancerTypes = new List<RepresentingConveyancerType>();
            LodgingConveyancerType lodgingConveyancer = new LodgingConveyancerType();
            docRef.Representations.ForEach(x =>
            {
                if (x.Type == "RepresentingConveyancer")
                {
                    CareOfAddressType tempDx = new DXAddressType()
                    {
                        DXNumber = x.DxNumber,
                        DXExchange = x.DxExchange,
                        CareOfName = x.CareOfName,
                        CareOfReference = x.CareOfReference
                    };
                    CareOfAddressType tempPostal = new PostalAddressType()
                    {
                        CareOfName = x.CareOfName,
                        CareOfReference = x.CareOfReference,
                        AddressLine1 = x.AddressLine1,
                        AddressLine2 = x.AddressLine1,
                        AddressLine3 = x.AddressLine1,
                        AddressLine4 = x.AddressLine1,
                        City = x.City,
                        Country = x.Country,
                        County = x.County,
                        Postcode = x.AddressLine1
                    };

                    representingConveyancerTypes.Add(new RepresentingConveyancerType
                    {
                        ConveyancerName = x.Name,
                        Reference = x.Reference,
                        RepresentativeId = x.RepresentativeId.ToString(),
                        Item = x.AddressType == "DXAddress" ? tempDx : tempPostal
                    });
                }
                else if (x.Type == "LodgingConveyancer")
                {
                    lodgingConveyancer = new LodgingConveyancerType
                    {
                        RepresentativeId = docRef.Representations.ToList().Select(w => w.RepresentativeId).FirstOrDefault().ToString()
                    };
                }
            });

            representations.LodgingConveyancer = lodgingConveyancer;
            representations.RepresentingConveyancer = representingConveyancerTypes.ToArray();

            _product.Representations = representations;

            #endregion

            #region Party

            //Parties
            PartiesType parties = new PartiesType();

            List<PartyType> partyTypes = new List<PartyType>();

            docRef.Parties.ToList().ForEach(x =>
            {
                var roles = x.Roles.Split(',');
                var partyType = new PartyType { IsApplicant = x.IsApplicant, representativeId = "1" };

                List<PartyRoleType> partyRoleType = new List<PartyRoleType>();
                roles.ToList().ForEach(r =>
                {
                    partyRoleType.Add(new PartyRoleType
                    {
                        Priority = 1.ToString(),
                        RoleType = (RoleTypeContent)Enum.Parse(typeof(RoleTypeContent), r)
                    });
                });
                partyType.Roles = partyRoleType.ToArray();

                if (x.PartyType == "company")
                    partyType.Item = new CompanyType { CompanyName = x.CompanyOrForeName };
                else if (x.PartyType == "person")
                    partyType.Item = new PersonType { Forenames = x.CompanyOrForeName, Surname = x.Surname };


                partyTypes.Add(partyType);

            });
            parties.Party = partyTypes.ToArray();

            _product.Parties = parties;
            #endregion


            _request.Product = _product;
            return _request;
        }

        public AttachmentV2_0Type ArrangeAttachmentApi(ApplicationForm applicationForm, SupportingDocuments supportingDocuments, string messageId, int count)
        {

            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            AttachmentV2_0Type _request = new AttachmentV2_0Type();

            _request.MessageId = messageId;
            _request.ExternalReference = applicationForm != null ? applicationForm.ExternalReference : supportingDocuments.ExternalReference;
            _request.ApplicationMessageId = messageId;
            _request.ApplicationService = "104";

            BusinessGatewayRepositories.AttachmentServiceRequest.AttachmentType attachment = null;
            if (applicationForm != null || supportingDocuments.DocumentType == "supDoc")
            {
                byte[] fileArray = Convert.FromBase64String(applicationForm != null
                    ? applicationForm.Document.Base64.Split(',')[1]
                    : supportingDocuments.Base64.Split(',')[1]);

                attachment = new BusinessGatewayRepositories.AttachmentServiceRequest.AttachmentType
                {
                    filename = Path.GetFileNameWithoutExtension(applicationForm != null ? applicationForm.Document.FileName : supportingDocuments.FileName),
                    format = applicationForm != null ? applicationForm.Document.FileExtension : supportingDocuments.FileExtension,
                    Value = fileArray,
                };
            }

            var ItemsElementName = new BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType[3];

            if (applicationForm != null || supportingDocuments.DocumentType == "supDoc")
            {
                ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.Attachment;
                ItemsElementName[1] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.AttachmentId;
                ItemsElementName[2] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.CertifiedCopy;

            }
            else
            {
                ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequest.ItemsChoiceType.Notes;

            }

            object[] Items;

            if (applicationForm != null || supportingDocuments.DocumentType == "supDoc")
            {
                Items = new object[] {
                    attachment,
                    count.ToString(),
                    (BusinessGatewayRepositories.AttachmentServiceRequest.CertifiedTypeContent)Enum.Parse(typeof(BusinessGatewayRepositories.AttachmentServiceRequest.CertifiedTypeContent),
                        applicationForm != null ? applicationForm.CertifiedCopy : supportingDocuments.CertifiedCopy),
                };
            }
            else
            {
                Items = new object[] {
                    supportingDocuments.Notes
                };
            }



            _request.Items = Items;
            _request.ItemsElementName = ItemsElementName;

            return _request;


        }
    }
}
