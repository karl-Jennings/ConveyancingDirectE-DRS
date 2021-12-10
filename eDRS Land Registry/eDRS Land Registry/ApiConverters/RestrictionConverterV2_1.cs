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
using CertifiedTypeContent = BusinessGatewayRepositories.EDRSApplicationV2_1.CertifiedTypeContent;
using DocumentNameContent = BusinessGatewayRepositories.EDRSApplicationV2_1.DocumentNameContent;

namespace eDRS_Land_Registry.ApiConverters
{

    public class RestrictionConverterV2_1
    {
        Services _services = new Services();
        Search[] _search_array = new Search[1];
        RequestApplicationToChangeRegisterV2_1Type _request = new RequestApplicationToChangeRegisterV2_1Type();
        ProductType _product = new ProductType();


        public RestrictionConverterV2_1()
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

                if (x.PartyType == "Company")
                    partyType.Item = new CompanyType { CompanyName = x.CompanyOrForeName };
                else if (x.PartyType == "Person")
                    partyType.Item = new PersonType { Forenames = x.CompanyOrForeName, Surname = x.Surname };


                //AddressForService

                if (x.AddressForService != null && x.AddressForService.Count()>0)
                {
                    AddressForServiceType addressForService = new AddressForServiceType();
                    ArrayList addressForServiceList = new ArrayList();

                    foreach (var addressforservice in x.AddressForService) {                     
                                             

                        //POSTAL ADDRESS
                        if (addressforservice.PostalAddress != null)
                        {
                            var p = addressforservice.PostalAddress;

                            PostalAddressType PostalAddressType = new PostalAddressType
                            {
                                CareOfName = p.CareOfName,
                                CareOfReference = p.CareOfReference,
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

                                var _adPostal = AdditionalAddress.PostalAddress;

                                PostalAddressType additionalPostalAddress = new PostalAddressType
                                {
                                    CareOfName = _adPostal.CareOfName,
                                    CareOfReference = _adPostal.CareOfReference,
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

                                if (AdditionalAddress.DXAddress != null)
                                {
                                    var _addDXAddress = AdditionalAddress.DXAddress;

                                    DXAddressType dxAddress = new DXAddressType
                                    {
                                        DXNumber = _addDXAddress.DXNumber,
                                        DXExchange = _addDXAddress.DXExchange,
                                        CareOfName = _addDXAddress.CareOfName,
                                        CareOfReference = _addDXAddress.CareOfReference

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

        public AttachmentV2_1Type ArrangeAttachmentApi(ApplicationForm applicationForm, SupportingDocuments supportingDocuments, string messageId, int count, string additionalProviderFilter)
        {

            BusinessGatewayServices.Services _services = new BusinessGatewayServices.Services();
            BusinessGatewayModels.Search[] _search_array = new BusinessGatewayModels.Search[1];

            AttachmentV2_1Type _request = new AttachmentV2_1Type();

            _request.MessageId = messageId;
            _request.ExternalReference = applicationForm != null ? applicationForm.ExternalReference : supportingDocuments.ExternalReference;
            _request.ApplicationMessageId = messageId;
            _request.ApplicationService = "104";
            _request.AdditionalProviderFilter = additionalProviderFilter;

            BusinessGatewayRepositories.AttachmentServiceRequestV2_1.AttachmentType attachment = null;
            if (applicationForm != null || (supportingDocuments != null && supportingDocuments.DocumentType == "SupDoc"))
            {
                byte[] fileArray = Convert.FromBase64String(applicationForm != null
                    ? applicationForm.Document.Base64
                    : supportingDocuments.Base64);

                attachment = new BusinessGatewayRepositories.AttachmentServiceRequestV2_1.AttachmentType
                {
                    filename = Path.GetFileNameWithoutExtension(applicationForm != null ? applicationForm.Document.FileName : supportingDocuments.FileName),
                    format = applicationForm != null ? applicationForm.Document.FileExtension : supportingDocuments.FileExtension,
                    Value = fileArray,
                };
            }

            var ItemsElementName = new BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType[3];

            if (applicationForm != null || (supportingDocuments != null && supportingDocuments.DocumentType == "SupDoc"))
            {
                ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.Attachment;
                ItemsElementName[1] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.AttachmentId;
                ItemsElementName[2] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.CertifiedCopy;

            }
            else
            {
                ItemsElementName[0] = BusinessGatewayRepositories.AttachmentServiceRequestV2_1.ItemsChoiceType.Notes;

            }

            object[] Items;



            if (applicationForm != null || (supportingDocuments != null && supportingDocuments.DocumentType == "SupDoc"))
            {
                Items = new object[] {
                    attachment,
                    count.ToString(),
                    (BusinessGatewayRepositories.AttachmentServiceRequestV2_1.CertifiedTypeContent)Enum.Parse(typeof(BusinessGatewayRepositories.AttachmentServiceRequestV2_1.CertifiedTypeContent),
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
