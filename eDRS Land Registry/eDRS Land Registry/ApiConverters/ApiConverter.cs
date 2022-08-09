using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BusinessGatewayModels;
using BusinessGatewayRepositories.AttachmentServiceRequestV2_1;
using BusinessGatewayRepositories.EDRSApplicationV2_1;
using BusinessGatewayServices;
using eDRS_Land_Registry.Models;
using eDrsDB.Models;
using ApplicationTypeContent = BusinessGatewayRepositories.EDRSApplicationV2_1.ApplicationTypeContent;
using CertifiedTypeContent = BusinessGatewayRepositories.EDRSApplicationV2_1.CertifiedTypeContent;
using DocumentNameContent = BusinessGatewayRepositories.EDRSApplicationV2_1.DocumentNameContent;

namespace eDRS_Land_Registry.ApiConverters
{

    public class ApiConverter
    {
        Services _services = new Services();
        Search[] _search_array = new Search[1];
        RequestApplicationToChangeRegisterV2_1Type _request = new RequestApplicationToChangeRegisterV2_1Type();
        ProductType _product = new ProductType();


        public ApiConverter()
        {
        }

        public RequestApplicationToChangeRegisterV2_1Type ArrangeLrApi(DocumentReference docRef)
        {

            _request.ExternalReference = docRef.ExternalReference;
            _request.MessageId = docRef.MessageID;
            _request.AdditionalProviderFilter = docRef.AdditionalProviderFilter;

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
            var additionalTitleList = new List<string>();

            docRef.Titles.ToList().ForEach(x =>
            {
                titleList.Add(x.TitleNumberCode);
            });

            docRef.Titles.ToList().ForEach(x =>
            {
                additionalTitleList.Add(x.AdditionalTitles);
            });


            if (docRef.ServiceTitleType == "Dealing")
            {

                DealingType dealingType = new DealingType
                {
                    DealingTitles = new TitlesType
                    {
                        TitleNumber = titleList.ToArray()
                    }
                };

                var titlesType = new ServiceTitlesType()
                {
                    Item = dealingType
                };

                _product.Titles = titlesType;

            }
            else if (docRef.ServiceTitleType == "TransferOfPart")
            {

                TransferOfPartType transferOfPartType = new TransferOfPartType
                {

                    TransferorTitles = new TitlesType
                    {
                        TitleNumber = titleList.ToArray()
                    },
                    AdditionalTitles = new TitlesType
                    {
                        TitleNumber = additionalTitleList.ToArray()
                    }

                };

                var titlesType = new ServiceTitlesType()
                {
                    Item = transferOfPartType
                };

                _product.Titles = titlesType;

            }
            else if (docRef.ServiceTitleType == "NewLease")
            {
                NewLeaseType newLeaseType = new NewLeaseType
                {

                    LessorTitles = new TitlesType
                    {
                        TitleNumber = titleList.ToArray()
                    },
                    AdditionalTitles = new TitlesType
                    {
                        TitleNumber = additionalTitleList.ToArray()
                    }
                };

                var titlesType = new ServiceTitlesType()
                {
                    Item = newLeaseType
                };

                _product.Titles = titlesType;

            }
            else if (docRef.ServiceTitleType == "LeaseExtension")
            {

                LeaseExtensionType leaseExtensionType = new LeaseExtensionType
                {

                    LessorTitles = new TitlesType
                    {
                        TitleNumber = titleList.ToArray()
                    },
                    LesseeTitle = docRef.Titles[0].LesseeTitleNumber,
                    AdditionalTitles = new TitlesType
                    {
                        TitleNumber = additionalTitleList.ToArray()
                    }
                };

                var titlesType = new ServiceTitlesType()
                {
                    Item = leaseExtensionType
                };

                _product.Titles = titlesType;

            }

            #endregion

            #region OtherApplication

            var applications = new List<ApplicationType>();

            docRef.Applications.ToList().ForEach(x =>
            {

                if (x.Variety == "charge" || x.Variety == "discharge")
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
                else if (x.Variety == "other")
                {
                    applications.Add(new OtherApplicationType()
                    {
                        Document = new DocumentType { CertifiedCopy = (CertifiedTypeContent)Enum.Parse(typeof(CertifiedTypeContent), x.CertifiedCopy) },
                        Priority = x.Priority.ToString(),
                        Value = x.Value,
                        FeeInPence = x.FeeInPence.ToString(),
                        Type = GetApplicationType(x.Type)
                    }); 
                }

            });

            _product.Applications = applications.ToArray();

            #endregion

            #region Supporting Documents

            //supporting documnets
            SupportingDocumentsType supportingDocuments = new SupportingDocumentsType();
            var supportingDocumentTypes = new List<SupportingDocumentType>();


            if (docRef.SupportingDocuments != null)
            {
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
            }


            #endregion

            #region Representations

            //Representations

            RepresentationsType representations = new RepresentationsType();

            List<RepresentingConveyancerType> representingConveyancerTypes = new List<RepresentingConveyancerType>();
            LodgingConveyancerType lodgingConveyancer = new LodgingConveyancerType();
            IdentityEvidenceType identityEvidence = new IdentityEvidenceType();

            docRef.Representations.ForEach(x =>
            {
                if (x.Type == "RepresentingConveyancer")
                {
                    CareOfAddressType tempDx = new DXAddressType()
                    {
                        DXNumber = x.DxNumber,
                        DXExchange = x.DxExchange,                    
                        CareOfName = !String.IsNullOrEmpty(x.CareOfName) ? x.CareOfName : null,
                        CareOfReference = !String.IsNullOrEmpty(x.CareOfReference) ? x.CareOfReference : null,

                    };
                    CareOfAddressType tempPostal = new PostalAddressType()
                    {
                        CareOfName = !String.IsNullOrEmpty(x.CareOfName) ? x.CareOfName : null,
                        CareOfReference = !String.IsNullOrEmpty(x.CareOfReference) ? x.CareOfReference : null,
                        AddressLine1 = x.AddressLine1,
                        AddressLine2 = x.AddressLine1,
                        AddressLine3 = x.AddressLine1,
                        AddressLine4 = x.AddressLine1,
                        City = x.City,
                        Country = x.Country,
                        County = x.County,
                        Postcode = x.PostCode
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
                        RepresentativeId = docRef.Representations.ToList().Select(w => w.RepresentativeId).FirstOrDefault().ToString(),


                    };

                    if (x.IdentityEvidence_RepresentativeId != null)
                    {

                        identityEvidence.RepresentativeId = x.IdentityEvidence_RepresentativeId.ToString();
                    }

                }
            });

            representations.LodgingConveyancer = lodgingConveyancer;
            representations.RepresentingConveyancer = representingConveyancerTypes.ToArray();

            if (identityEvidence != null && !String.IsNullOrEmpty(identityEvidence.RepresentativeId))
            {
                representations.IdentityEvidence = identityEvidence;
            }

            _product.Representations = representations;

            #endregion

            #region Party

            //Parties
            PartiesType parties = new PartiesType();

            List<PartyType> partyTypes = new List<PartyType>();

            docRef.Parties.ToList().ForEach(x =>
            {
                var roles = x.Roles;
                var partyType = new PartyType { IsApplicant = x.IsApplicant, representativeId = "1" };

                List<PartyRoleType> partyRoleType = new List<PartyRoleType>();

                roles.ToList().ForEach(r =>
                {
                    partyRoleType.Add(new PartyRoleType
                    {
                        Priority = r.Priority.ToString(),
                        RoleType = (RoleTypeContent)Enum.Parse(typeof(RoleTypeContent), r.RoleType)
                    });
                });
                partyType.Roles = partyRoleType.ToArray();

                if (x.PartyType == "Company")
                    partyType.Item = new CompanyType { CompanyName = x.CompanyOrForeName };
                else if (x.PartyType == "Person")
                    partyType.Item = new PersonType { Forenames = x.CompanyOrForeName, Surname = x.Surname };


                //AddressForService

                if (x.AddressForService != null && x.AddressForService.Count() > 0)
                {
                    AddressForServiceType addressForService = new AddressForServiceType();
                    ArrayList addressForServiceList = new ArrayList();

                    foreach (var addressforservice in x.AddressForService)
                    {


                        //POSTAL ADDRESS
                        if (addressforservice.PostalAddress != null)
                        {
                            var p = addressforservice.PostalAddress;

                            PostalAddressType PostalAddressType = new PostalAddressType
                            {
                                CareOfName = !String.IsNullOrEmpty( p.CareOfName) ? p.CareOfName : null,
                                CareOfReference = !String.IsNullOrEmpty(p.CareOfReference) ? p.CareOfReference:null ,
                                AddressLine1 = p.AddressLine1,
                                AddressLine2 = p.AddressLine1,
                                AddressLine3 = p.AddressLine1,
                                AddressLine4 = p.AddressLine1,
                                City = p.City,
                                Country = p.Country,
                                County = p.County,
                                Postcode = p.Postcode,

                            };

                            addressForServiceList.Add(PostalAddressType);

                        }
                        //ADDITIONAL ADDRESSES
                        //Only allowed if PostalAddress selected. Contains an additional address for service if appropriate.

                        if (addressforservice.PostalAddress != null && addressforservice.AdditionalAddresses != null)
                        {

                            foreach (var AdditionalAddress in addressforservice.AdditionalAddresses)
                            {

                                // AdditionalAddressForServiceType
                                AdditionalAddressForServiceType additionalAddressForServiceType = new AdditionalAddressForServiceType();

                                ArrayList AdditionalAddresAarlist = new ArrayList();

                                if (AdditionalAddress.PostalAddress != null)
                                {
                                    var _adPostal = AdditionalAddress.PostalAddress;

                                    PostalAddressType additionalPostalAddress = new PostalAddressType
                                    {
                                        CareOfName = !String.IsNullOrEmpty(_adPostal.CareOfName) ? _adPostal.CareOfName : null,
                                        CareOfReference = !String.IsNullOrEmpty(_adPostal.CareOfReference) ? _adPostal.CareOfReference : null,
                                        AddressLine1 = _adPostal.AddressLine1,
                                        AddressLine2 = _adPostal.AddressLine1,
                                        AddressLine3 = _adPostal.AddressLine1,
                                        AddressLine4 = _adPostal.AddressLine1,
                                        City = _adPostal.City,
                                        Country = _adPostal.Country,
                                        County = _adPostal.County,
                                        Postcode = _adPostal.Postcode
                                    };

                                    AdditionalAddresAarlist.Add(additionalPostalAddress);
                                }
                                if (AdditionalAddress.DXAddress != null)
                                {
                                    var _addDXAddress = AdditionalAddress.DXAddress;

                                    DXAddressType dxAddress = new DXAddressType
                                    {
                                        DXNumber = _addDXAddress.DXNumber,
                                        DXExchange = _addDXAddress.DXExchange,                                  
                                        CareOfName = !String.IsNullOrEmpty(_addDXAddress.CareOfName) ? _addDXAddress.CareOfName : null,
                                        CareOfReference = !String.IsNullOrEmpty(_addDXAddress.CareOfReference) ? _addDXAddress.CareOfReference : null,

                                    };

                                    AdditionalAddresAarlist.Add(dxAddress);
                                }


                                if (AdditionalAddress.DXAddress == null)
                                {
                                    if (AdditionalAddress.EmailAddress != null)
                                    {

                                        var _addEmailAddress = AdditionalAddress.EmailAddress;

                                        EmailAddressType emailAddress = new EmailAddressType
                                        {
                                            Email = _addEmailAddress.Email
                                        };

                                        AdditionalAddresAarlist.Add(emailAddress);
                                    }
                                }

                                additionalAddressForServiceType.Items = AdditionalAddresAarlist.ToArray();

                                addressForServiceList.Add(additionalAddressForServiceType);

                            }

                        }

                        //ADDRESS FOR SERVICE OPTION
                        if (addressforservice.PostalAddress == null)
                        {
                            if (addressforservice.AddressForServiceOption != null)
                            {
                                if (addressforservice.AddressForServiceOption == "A1")
                                {
                                    addressForServiceList.Add(AddressForServiceTypeContent.A1);
                                }

                                if (addressforservice.AddressForServiceOption == "B1")
                                {
                                    addressForServiceList.Add(AddressForServiceTypeContent.B1);
                                }

                                if (addressforservice.AddressForServiceOption == "TA")
                                {
                                    addressForServiceList.Add(AddressForServiceTypeContent.TA);
                                }
                            }
                        }


                    }
                    addressForService.Items = addressForServiceList.ToArray();
                    partyType.AddressForService = addressForService;
                }

                partyTypes.Add(partyType);

            });
            parties.Party = partyTypes.ToArray();

            _product.Parties = parties;
            #endregion


            _request.Product = _product;
            return _request;
        }

        public AttachmentV2_1Type ArrangeAttachmentApi(ApplicationForm applicationForm, SupportingDocuments supportingDocument, string applicationMessageId, string additionalProviderFilter)
        {

            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            AttachmentV2_1Type _request = new AttachmentV2_1Type();

            _request.MessageId = Guid.NewGuid().ToString();
            _request.ExternalReference = applicationForm != null ? applicationForm.ExternalReference : supportingDocument.ExternalReference;
            _request.ApplicationMessageId = applicationMessageId;
            _request.ApplicationService = "104";
            _request.AdditionalProviderFilter = additionalProviderFilter;


            BusinessGatewayRepositories.AttachmentServiceRequestV2_1.AttachmentType attachment = null;
            if (applicationForm != null || (supportingDocument != null && (supportingDocument.DocumentType == "SupDoc" || supportingDocument.DocumentType == "Requisition Response")))
            {
                byte[] fileArray = Convert.FromBase64String(applicationForm != null
                    ? applicationForm.Document.Base64
                    : supportingDocument.Base64);


                attachment = new BusinessGatewayRepositories.AttachmentServiceRequestV2_1.AttachmentType
                {
                    filename = Path.GetFileNameWithoutExtension(applicationForm != null ? applicationForm.Document.FileName : supportingDocument.FileName),
                    format = applicationForm != null ? applicationForm.Document.FileExtension : supportingDocument.FileExtension,
                    Value = fileArray,

                };
            }

            var ItemsElementName = new BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType[3];

            if (applicationForm != null || (supportingDocument != null && (supportingDocument.DocumentType == "SupDoc" || supportingDocument.DocumentType == "Requisition Response")))
            {
                ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.Attachment;
                ItemsElementName[1] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.AttachmentId;
                ItemsElementName[2] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.CertifiedCopy;

                if (supportingDocument!=null && supportingDocument.DocumentType == "Requisition Response")
                {
                    ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.Attachment;
                    ItemsElementName[1] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.DocumentName;
                    ItemsElementName[2] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.CertifiedCopy;

                }

            }
            else
            {
                ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.Notes;

            }

            object[] Items;



            if (applicationForm != null || (supportingDocument != null && (supportingDocument.DocumentType == "SupDoc" || supportingDocument.DocumentType == "Requisition Response")))
            {
                Items = new object[] {
                    attachment,
                    applicationForm != null ? applicationForm.Document.AttachmentId.ToString() :supportingDocument.DocumentId.ToString(),
                    (BusinessGatewayRepositories.AttachmentServiceRequestV2_1.CertifiedTypeContent)Enum.Parse(typeof(BusinessGatewayRepositories.AttachmentServiceRequestV2_1.CertifiedTypeContent),
                        applicationForm != null ? applicationForm.CertifiedCopy : supportingDocument.CertifiedCopy),
                };

                if (supportingDocument != null && supportingDocument.DocumentType == "Requisition Response") {

                    Items = new object[] {
                    attachment,
                    BusinessGatewayRepositories.AttachmentServiceRequestV2_1.DocumentNameContent.LRCorrespondence,
                    (BusinessGatewayRepositories.AttachmentServiceRequestV2_1.CertifiedTypeContent)Enum.Parse(typeof(BusinessGatewayRepositories.AttachmentServiceRequestV2_1.CertifiedTypeContent),
                        applicationForm != null ? applicationForm.CertifiedCopy : supportingDocument.CertifiedCopy),
                };
                }

            }
            else
            {
                Items = new object[] {
                    supportingDocument.Notes
                };
            }

            _request.Items = Items;

            _request.ItemsElementName = ItemsElementName;

            return _request;


        }


        public ApplicationTypeContent GetApplicationType(string type) {

            switch (type) {

                case "Adverse possession of registered land": return ApplicationTypeContent.ADV1;
                case "Notification of adverse possession": return ApplicationTypeContent.ADV2;
                case "Agreed Notice": return ApplicationTypeContent.AN1;
                case "Alteration of Register": return ApplicationTypeContent.AP1;
                case "Appointment of New Trustee":return ApplicationTypeContent.APT;
                case "Assent": return ApplicationTypeContent.AS1;
                case "Assent of Charge":return ApplicationTypeContent.AS2;
                case "Assent of Part": return ApplicationTypeContent.AS3;
                case "Cancellation of Caution": return ApplicationTypeContent.CCD;
                case "Obligation to make Further Advances(CH2)": return ApplicationTypeContent.CH2;
                case "Note Agreed Maximum Amount of Security()CH3)": return ApplicationTypeContent.CH3;
                case "Change of Name": return ApplicationTypeContent.CN;
                case "Cancellation of Noted Lease":return ApplicationTypeContent.CNL;
                case "Cancel Notice": return ApplicationTypeContent.CN1;
                case "Change of Address": return ApplicationTypeContent.COA;
                case "Change of Property Description(CPD)": return ApplicationTypeContent.CPD;
                case "Determine the exact line of boundary": return ApplicationTypeContent.DB;
                case "Discharge": return ApplicationTypeContent.DIS;
                case "Death of Joint Proprietor": return ApplicationTypeContent.DJP;
                case "Determination of a Lease": return ApplicationTypeContent.DOL;
                case "Death of Sole Proprietor": return ApplicationTypeContent.DSP;
                case "Exempt Information Document(EX1)": return ApplicationTypeContent.EX1;
                case "Remove Exempt Information Document(EX3)": return ApplicationTypeContent.EX3;
                case "Notice of Home Rights(HR1)": return ApplicationTypeContent.HR1;
                case "Renew notice of Home Rights(HR2)": return ApplicationTypeContent.HR2;
                case "Cancel notice of Home Rights(HR4)": return ApplicationTypeContent.HR4;
                case "Lease": return ApplicationTypeContent.LEASE;
                case "Noting of Easement": return ApplicationTypeContent.NOE;
                case "Noting of Lease": return ApplicationTypeContent.NOL;
                case "Postponement of Charge": return ApplicationTypeContent.PC;
                case "Entry of Restrictive Covenant": return ApplicationTypeContent.RC;
                case "Rectification of Register": return ApplicationTypeContent.RFN;
                case "Registration of Easements": return ApplicationTypeContent.RGOE;
                case "Release of Covenants - Agreed Notice": return ApplicationTypeContent.ROCA;
                case "Release of Covenants - Cancellation": return ApplicationTypeContent.ROCC;
                case "Release of Covenants -Unilateral Notice": return ApplicationTypeContent.ROCU;
                case "Release of Easements": return ApplicationTypeContent.ROE;
                case "Restriction(Standard)": return ApplicationTypeContent.RX1;
                case "Restriction(Non Standard)": return ApplicationTypeContent.RX2;
                case "Cancel a Restriction": return ApplicationTypeContent.RX3;
                case "Withdraw a Restriction": return ApplicationTypeContent.RX4;
                case "Sub Charge": return ApplicationTypeContent.SBC;
                case "Note overriding priority of a statutory charge": return ApplicationTypeContent.SC;
                case "Severance of Joint Tenancy": return ApplicationTypeContent.SEV;
                case "Surrender of Lease": return ApplicationTypeContent.SL;
                case "Transfer not for Value": return ApplicationTypeContent.TNV;
                case "Transfer of Part": return ApplicationTypeContent.TP1;
                case "Transfer of Part Under Power of Sale": return ApplicationTypeContent.TP2;
                case "Transfer": return ApplicationTypeContent.TR1;
                case "Transfer Under Power of Sale": return ApplicationTypeContent.TR2;
                case "Transfer of Charge": return ApplicationTypeContent.TR4;
                case "Transfer by Operation of Law(On Death)": return ApplicationTypeContent.TRM;
                case "Transfer Subject to a Charge": return ApplicationTypeContent.TSC;
                case "Unilateral Notice": return ApplicationTypeContent.UN1;
                case "Remove Unilateral Notice(UN2)": return ApplicationTypeContent.UN2;
                case "Register Beneficiary of Unilateral Notice(UN3)": return ApplicationTypeContent.UN3;
                case "Cancellation of a Unilateral Notice(UN4)": return ApplicationTypeContent.UN4;
                case "Upgrade Title(UT1)": return ApplicationTypeContent.UT1;
                case "Variation of Charge": return ApplicationTypeContent.VC;
                case "Variation of Lease - Agreed Notice": return ApplicationTypeContent.VLAN;
                case "Variation of Lease": return ApplicationTypeContent.VLAP;
                case "Variation of Lease - Unilateral Notice": return ApplicationTypeContent.VLUN;
                case "Variation of Covenants - Agreed Notice": return ApplicationTypeContent.VOCA;
                case "Variation of Covenants - Unilateral Notice": return ApplicationTypeContent.VOCU;
                case "Variation of Easements": return ApplicationTypeContent.VOE;
                case "Variation of Easements - Agreed Notice": return ApplicationTypeContent.VOEA;
                case "Variation of Easements - Unilateral Notice": return ApplicationTypeContent.VOEU;
                case "Withdraw a Caution": return ApplicationTypeContent.WCT;

                
            }

            return ApplicationTypeContent.ADV1;

        }

    }

}
