using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Configuration;
using BusinessGatewayModels;


namespace BusinessGatewayModels
{
    public class RESResponse
    {
        public string MessageId { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public bool Successful { get; set; }
        public List<Proprietors> Proprietors { get; set; }
        public List<AgreedNotice> AgreedNotice { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Charge> Charges { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Restrictions> Restrictions { get; set; }
        public List<Lease> Leases { get; set; }
        public ResDetail ResDetails { get; set; }
        public List<ProprietorRegister> ProprietorRegister { get; set; }
        public List<PropertyRegister> PropertyRegister { get; set; }
        public DateTime? PollDateTime { get; set; }
        public File Attachment { get; set; }
        public string XML { get; set; }
        public RESResponse() { }
        public RESResponse(string FileName, BusinessGatewayRepositories.RES.ResponseOCWithSummaryV2_1Type item, string Username)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BusinessGatewayRepositories.RES.ResponseOCWithSummaryV2_1Type));
            this.WriteXML(FileName, item);
            if (item.GatewayResponse != null)
            {
                if (item.GatewayResponse.Results != null)
                {
                    this.Successful = true;
                    //item.GatewayResponse.Results.OCSummaryData.Proprietorship.Items
                    if (item.GatewayResponse.Results.OCSummaryData.Proprietorship != null)
                    {
                        this.Proprietors = item.GatewayResponse.Results.OCSummaryData.Proprietorship.Items.Select(s => new Proprietors(s)).ToList();
                        this.UpdateProprietors(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, Proprietors);
                    }
                    if (item.GatewayResponse.Results.OCSummaryData.PropertyAddress != null)
                    {
                        this.Addresses = item.GatewayResponse.Results.OCSummaryData.PropertyAddress.Select(s => new Address(s)).ToList();
                        this.UpdateAddress(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, Addresses);
                    }
                    if (item.GatewayResponse.Results.OCSummaryData.RestrictionDetails != null)
                    {
                        this.Restrictions = item.GatewayResponse.Results.OCSummaryData.RestrictionDetails.Select(s => new Restrictions(s.Item)).ToList();
                        this.UpdateRestrictions(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, Restrictions);
                    }
                    if (item.GatewayResponse.Results.OCSummaryData.AgreedNotice != null)
                    {
                        this.AgreedNotice = item.GatewayResponse.Results.OCSummaryData.AgreedNotice.Select(s => new AgreedNotice(s)).ToList();
                        this.UpdateAgreedNotices(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, AgreedNotice);

                    }
                    if (item.GatewayResponse.Results.OCRegisterData.ChargesRegister != null)
                    {
                        this.Charges = item.GatewayResponse.Results.OCRegisterData.ChargesRegister.RegisterEntry.Select(s => new Charge(s)).ToList();
                        this.UpdateCharges(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, Charges);
                        if (item.GatewayResponse.Results.OCRegisterData.ChargesRegister.Schedule != null)
                        {
                            this.Schedules = new List<Schedule>();
                            foreach (var _item in item.GatewayResponse.Results.OCRegisterData.ChargesRegister.Schedule)
                            {
                                this.Schedules.AddRange(_item.ScheduleEntry.Select(s => new Schedule(s)).ToList());
                            }
                            this.UpdateSchedules(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, Schedules);
                        }
                    }
                    if (item.GatewayResponse.Results.OCSummaryData != null)
                    {
                        this.ResDetails = new ResDetail(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, item.GatewayResponse.Results.OCSummaryData);
                        this.UpdateResDetails(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, ResDetails);
                    }
                    if (item.GatewayResponse.Results.OCRegisterData.ProprietorshipRegister != null)
                    {
                        this.ProprietorRegister = item.GatewayResponse.Results.OCRegisterData.ProprietorshipRegister.RegisterEntry.Select(s => new ProprietorRegister(s)).ToList();
                        this.UpdateProprietorRegister(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, this.ProprietorRegister);
                    }
                    if (item.GatewayResponse.Results.OCRegisterData.PropertyRegister != null)
                    {
                        this.PropertyRegister = item.GatewayResponse.Results.OCRegisterData.PropertyRegister.RegisterEntry.Select(s => new PropertyRegister(s)).ToList();
                        this.UpdatePropertyRegister(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, this.PropertyRegister);
                    }
                    if (item.GatewayResponse.Results.OCSummaryData.Lease != null)
                    {
                        this.Leases = item.GatewayResponse.Results.OCSummaryData.Lease.Select(s => new Lease(s)).ToList();
                        this.UpdateLeases(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, this.Leases);
                    }
                    if (item.GatewayResponse.Results.Attachment != null)
                    {
                        var _attachment = new File();
                        _attachment.Contents = item.GatewayResponse.Results.Attachment.EmbeddedFileBinaryObject.Value;
                        _attachment.FileName = item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value + "." + item.GatewayResponse.Results.Attachment.EmbeddedFileBinaryObject.format;
                        this.Attachment = _attachment;
                        WriteAttachment(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, item.GatewayResponse.Results.Attachment);
                    }
                    this.XML = ToXML(item);
                    WriteXML(item.GatewayResponse.Results.ExternalReference.Reference.Value, item);
                    this.UpdateRes(item.GatewayResponse.Results.OCSummaryData.Title.TitleNumber.Value, Username);
                }
                if (item.GatewayResponse.Acknowledgement != null)
                {
                    this.Successful = true;
                    this.Message = item.GatewayResponse.Acknowledgement.AcknowledgementDetails != null ? item.GatewayResponse.Acknowledgement.AcknowledgementDetails.MessageDescription.Value : "";
                    this.PollDateTime = item.GatewayResponse.Acknowledgement.AcknowledgementDetails != null ?
                       (DateTime?)item.GatewayResponse.Acknowledgement.AcknowledgementDetails.ExpectedResponseDateTime.Value : null;
                }
                if (item.GatewayResponse.Rejection != null)
                {
                    this.Successful = false;
                    this.Message = item.GatewayResponse.Rejection.RejectionResponse != null ? item.GatewayResponse.Rejection.RejectionResponse.Reason.Value : "";
                    UpdateFail(FileName, this.Message);
                }
            }
            else
            {
                throw new Exception("Unable to find RES for given title number");
            }

        }
        private void UpdateAddress(string TitleNumber, List<Address> Addresses)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //foreach (var Address in Addresses)
            //{
            //    var _address = new BusinessGatewayDB.PropertyAddress
            //    {
            //        TitleNumber = TitleNumber,
            //        AddressLine = Address.AddressLine,
            //        Postcode = Address.Postcode                    
            //    };
            //    _Context.PropertyAddresses.Add(_address);
            //}
            //_Context.SaveChanges();
        }
        private void UpdateLeases(string TitleNumber, List<BusinessGatewayModels.Lease> Leases)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //foreach (var lease in Leases)
            //{
            //    var _lease = new BusinessGatewayDB.Lease
            //    {
            //         TitleNumber = TitleNumber,
            //         Description = lease.Description,
            //        //LeaseDate = lease.LeaseDate.Value.ToShortDateString(),
            //        LeaseDate = lease.LeaseDate,
            //        LeaseTerm = lease.LeaseTerm,
            //         Parties = lease.Parties
            //    };
            //    _Context.Leases.Add(_lease);
            //}
            //_Context.SaveChanges();
        }
        private void UpdateFail(string TitleNumber, string Error)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //var _fail = new BusinessGatewayDB.ReqFail();
            //_fail.TitleNumber = TitleNumber;
            //_fail.Description = Error;
            //_Context.ReqFails.Add(_fail);
            //_Context.SaveChanges();

        }
        private void UpdateResDetails(string TitleNumber, ResDetail Details)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //var _res = new BusinessGatewayDB.ResDetail();
            //_res.TitleNumber = TitleNumber;
            //_res.DistrictName = Details.DistrictName;
            //_res.AdministrativeArea = Details.AdministrativeArea;
            //_res.LandRegOfficeName = Details.LandRegOfficeName;
            ////_res.DateOfOfficeCopy = Details.DateOfOfficeCopy.Value.ToShortDateString();
            //_res.DateOfOfficeCopy = Details.DateOfOfficeCopy;
            //_res.ClassOfTitle = Details.ClassOfTitle;
            //_res.AgreedNoticeIndicator = Details.AgreedNoticeIndicator;
            //_res.BankruptcyIndicator = Details.BankruptcyIndicator;
            //_res.CautionIndicator = Details.CautionIndicator;
            //_res.CCBIIndicator = Details.CCBIIndicator;
            //_res.ChargeeIndicator = Details.ChargeeIndicator;
            //_res.ChargeIndicator = Details.ChargeIndicator;
            //_res.ChargeRelatedRestrictionIndicator = Details.ChargeRelatedRestrictionIndicator;
            //_res.ChargeRestrictionIndicator = Details.ChargeRestrictionIndicator;
            //_res.CreditorsNoticeIndicator = Details.CreditorsNoticeIndicator;
            //_res.DeathOfProprietorIndicator = Details.DeathOfProprietorIndicator;
            //_res.DeedOfPostponementIndicator = Details.DeedOfPostponementIndicator;
            //_res.DiscountChargeIndicator = Details.DiscountChargeIndicator;
            //_res.EquitableChargeIndicator = Details.EquitableChargeIndicator;
            //_res.GreenOutEntryIndicator = Details.GreenOutEntryIndicator;
            //_res.HomeRightsChangeOfAddressIndicator = Details.HomeRightsChangeOfAddressIndicator;
            //_res.HomeRightsIndicator = Details.HomeRightsIndicator;
            //_res.LeaseHoldTitleIndicator = Details.LeaseHoldTitleIndicator;
            //_res.MultipleChargeIndicator = Details.MultipleChargeIndicator;
            //_res.NonChargeRestrictionIndicator = Details.NonChargeRestrictionIndicator;
            //_res.NotedChargeIndicator = Details.NotedChargeIndicator;
            //_res.PricePaidIndicator = Details.PricePaidIndicator;
            //_res.PropertyDescriptionNotesIndicator = Details.PropertyDescriptionNotesIndicator;
            //_res.RentChargeIndicator = Details.RentChargeIndicator;
            //_res.RightOfPreEmptionIndicator = Details.RightOfPreEmptionIndicator;
            //_res.ScheduleOfLeasesIndicator = Details.ScheduleOfLeasesIndicator;
            //_res.SubChargeIndicator = Details.SubChargeIndicator;
            //_res.UnidentifiedEntryIndicator = Details.UnidentifiedEntryIndicator;
            //_res.UnilateralNoticeBeneficiaryIndicator = Details.UnilateralNoticeBeneficiaryIndicator;
            //_res.UnilateralNoticeIndicator = Details.UnilateralNoticeIndicator;
            //_res.VendorsLienIndicator = Details.VendorsLienIndicator;
            //_Context.ResDetails.Add(_res);
            //_Context.SaveChanges();

        }
        private void UpdatePropertyRegister(string TitleNumber, List<BusinessGatewayModels.PropertyRegister> PropertyRegisters)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //foreach (var _register in PropertyRegisters)
            //{
            //    var _charge = new BusinessGatewayDB.PropertyRegister
            //    {
            //        TitleNumber = TitleNumber,
            //        EntryDescription = _register.EntryDescription,
            //        //EntryDate = _register.EntryDate.Value.ToShortDateString(),
            //        EntryDate = _register.EntryDate,
            //        EntryNumber = _register.EntryNumber,
            //        EntryType = _register.EntryType
            //    };
            //    _Context.PropertyRegisters.Add(_charge);
            //}
            //_Context.SaveChanges();
        }
        private void UpdateProprietorRegister(string TitleNumber, List<BusinessGatewayModels.ProprietorRegister> PropertyRegisters)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //foreach (var _register in PropertyRegisters)
            //{
            //    var _charge = new BusinessGatewayDB.ProprietorRegister
            //    {
            //        TitleNumber = TitleNumber,
            //        EntryDescription = _register.EntryDescription,
            //        //EntryDate = _register.EntryDate.Value.ToShortDateString(),
            //        EntryDate = _register.EntryDate,
            //        EntryNumber = _register.EntryNumber,
            //        EntryType = _register.EntryType
            //    };
            //    _Context.ProprietorRegisters.Add(_charge);
            //}
            //_Context.SaveChanges();
        }
        private void UpdateSchedules(string TitleNumber, List<BusinessGatewayModels.Schedule> Schedules)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //foreach (var schedule in Schedules)
            //{
            //    var _schedule = new BusinessGatewayDB.Schedule
            //    {
            //        TitleNumber = TitleNumber,
            //        EntryDescription = schedule.EntryDescription,
            //        EntryNumber = schedule.EntryNumber,
            //        EntryType = schedule.EntryType
            //    };
            //    _Context.Schedules.Add(_schedule);
            //}
            //_Context.SaveChanges();
        }
        private void UpdateAgreedNotices(string TitleNumber, List<BusinessGatewayModels.AgreedNotice> AgreedNotices)
        {
            //    BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //    foreach (var agreedNotice in AgreedNotices)
            //    {
            //        var _agreedNotice = new BusinessGatewayDB.AgreedNotice
            //        {
            //            TitleNumber = TitleNumber,
            //            EntryDescription = agreedNotice.EntryDescription,
            //            EntryNumber = agreedNotice.EntryNumber,
            //             NoticeType = agreedNotice.EntryType
            //        };
            //        _Context.AgreedNotices.Add(_agreedNotice);
            //    }
            //    _Context.SaveChanges();
        }
        private void UpdateCharges(string TitleNumber, List<BusinessGatewayModels.Charge> Charges)
        {
            //BusinessGatewayDB.BGEntities _Context = new BGEntities();
            //foreach (var charge in Charges)
            //{
            //    var _charge = new BusinessGatewayDB.Charge
            //    {
            //        TitleNumber = TitleNumber,
            //        EntryDescription = charge.EntryDescription,
            //        //EntryDate = charge.EntryDate.Value.ToShortDateString(),
            //        EntryDate = charge.EntryDate,
            //        EntryNumber = charge.EntryNumber,
            //        EntryType = charge.EntryType
            //    };
            //    _Context.Charges.Add(_charge);
            //}
            //_Context.SaveChanges();
        }
        private void UpdateRestrictions(string TitleNumber, List<BusinessGatewayModels.Restrictions> Restrictions)
        {
            BusinessGatewayDB.BGEntities _Context = new BGEntities();
            foreach (var restrictions in Restrictions)
            {
                var _restriction = new BusinessGatewayDB.Restriction
                {
                    TitleNumber = TitleNumber,
                    EntryDescription = restrictions.Description,
                    EntryNumber = restrictions.EntryNumber,
                };
                _Context.Restrictions.Add(_restriction);
            }
            _Context.SaveChanges();
        }
        private void UpdateRes(string TitleNumber, string Username)
        {
            BusinessGatewayDB.BGEntities _Context = new BGEntities();
            var _res = new BusinessGatewayDB.ResRequest
            {
                DateRequested = DateTime.Now,
                MessageId = TitleNumber,
                TitleNumber = TitleNumber,
                UserName = Username,
                //ResDate = DateTime.Now.ToShortDateString()
                ResDate = DateTime.Now
            };
            _Context.ResRequests.Add(_res);
            _Context.SaveChanges();

        }
        private void UpdateProprietors(string TitleNumber, List<BusinessGatewayModels.Proprietors> Proprietors)
        {
            BusinessGatewayDB.BGEntities _Context = new BGEntities();
            foreach (var proprietor in Proprietors)
            {
                var _proprietor = new BusinessGatewayDB.Proprietor
                {
                    TitleNumber = TitleNumber,
                    Firstname = proprietor.Firstname,
                    Surname = proprietor.Surname,
                    CompanyName = proprietor.CompanyName,
                    CompanyRegistrationNumber = proprietor.CompanyRegistrationNumber
                };
                _Context.Proprietors.Add(_proprietor);
            }
            _Context.SaveChanges();
        }
        public void WriteAttachment(string TitleNumber, BusinessGatewayRepositories.RES.Q1AttachmentType Attachment)
        {
            // string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + TitleNumber + "." + Attachment.EmbeddedFileBinaryObject.format;
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + TitleNumber + "." + Attachment.EmbeddedFileBinaryObject.format; ;
            //We want to get the pdf from the value of the byte array and write it.
            BusinessGatewayRepositories.RES.BinaryObjectType _binaryFile = Attachment.EmbeddedFileBinaryObject;

            byte[] buff;
            buff = _binaryFile.Value;
            try
            {
                FileStream fs = new FileStream(_FileLocation, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(buff);
                bw.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public string ToXML(BusinessGatewayRepositories.RES.ResponseOCWithSummaryV2_1Type item)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.NewLineHandling = NewLineHandling.None;
            settings.Indent = false;
            StringWriter StringWriter = new StringWriter();
            StringWriter.NewLine = ""; //tried to change it but without effect
            XmlWriter writer = XmlWriter.Create(StringWriter, settings);
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);
            XmlSerializer MySerializer = new XmlSerializer(typeof(BusinessGatewayRepositories.RES.ResponseOCWithSummaryV2_1Type));

            MySerializer.Serialize(writer, item, namespaces);
            return StringWriter.ToString();
        }
        public void WriteXML(string FileNumber, BusinessGatewayRepositories.RES.ResponseOCWithSummaryV2_1Type Response)
        {
            string _File = FileNumber;
            // string _FileLocation = ConfigurationManager.AppSettings["FileLocation"] + _File + ".xml";
            string _FileLocation = AppSettings.Resolve.GetSetting_ByName("FileLocation").Value + _File + ".xml";

            //If the file exists for some reason then we don't want to create it twice
            if (System.IO.File.Exists(_FileLocation) == false)
            {
                System.IO.FileStream f = System.IO.File.Create(_FileLocation);
                f.Close();
            }

            //We then want to serialise the response object and write it out to the xml file
            XmlSerializer serializer = new XmlSerializer(Response.GetType());
            TextWriter tw = new StreamWriter(_FileLocation);
            serializer.Serialize(tw, Response);
            tw.Close();


        }

    }
    public class AgreedNotice
    {
        public string EntryNumber { get; set; }
        public string EntryDescription { get; set; }
        public string SubRegisterCode { get; set; }
        public string EntryType { get; set; }
        public AgreedNotice(BusinessGatewayRepositories.RES.Q1AgreedNoticeType item)
        {
            if (item.AgreedNoticeType != null)
                EntryType = item.AgreedNoticeType.ToString();
            if (item.EntryDetails != null)
            {
                EntryDescription = item.EntryDetails.EntryText != null ? item.EntryDetails.EntryText.Value : "";
                EntryNumber = item.EntryDetails.EntryNumber != null ? item.EntryDetails.EntryNumber.Value : "";
            }
        }

    }
    public class Proprietors
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public Proprietors(BusinessGatewayRepositories.RES.Q1PartyType item)
        {
            switch (item.Item.GetType().ToString())
            {
                case "BusinessGatewayRepositories.RES.Q1PrivateIndividualType":
                    BusinessGatewayRepositories.RES.Q1PrivateIndividualType _private = new BusinessGatewayRepositories.RES.Q1PrivateIndividualType();
                    _private = (BusinessGatewayRepositories.RES.Q1PrivateIndividualType)item.Item;
                    this.Firstname = _private.Name.ForenamesName != null ? _private.Name.ForenamesName.Value : "";
                    this.Surname = _private.Name.SurnameName != null ? _private.Name.SurnameName.Value : "";
                    break;
                case "BusinessGatewayRepositories.RES.Q1OrganizationType":
                    BusinessGatewayRepositories.RES.Q1OrganizationType _organisation = new BusinessGatewayRepositories.RES.Q1OrganizationType();
                    _organisation = (BusinessGatewayRepositories.RES.Q1OrganizationType)item.Item;
                    this.CompanyName = _organisation.Name.Value;
                    this.CompanyRegistrationNumber = _organisation.CompanyRegistrationNumber != null ? _organisation.CompanyRegistrationNumber.Value : "";
                    break;
            }
        }
    }
    public class Address
    {
        public string AddressLine { get; set; }
        public string Postcode { get; set; }
        public Address(BusinessGatewayRepositories.RES.Q1AddressType item)
        {
            this.AddressLine = String.Join(",", item.AddressLine.Line.Select(s => s.Value).ToList());
            this.Postcode = item.PostcodeZone != null ? item.PostcodeZone.Postcode.Value : "";
        }
    }
    public class Charge
    {
        public string EntryDescription { get; set; }
        public string EntryNumber { get; set; }
        public string EntryType { get; set; }
        public DateTime? EntryDate { get; set; }
        public Charge(BusinessGatewayRepositories.RES.Q1RegisterEntryType item)
        {
            EntryNumber = item.EntryNumber != null ? item.EntryNumber.Value : "";
            EntryType = item.EntryType != null ? item.EntryType.Value : "";
            EntryDescription = String.Join(",", item.EntryText.Select(s => s.Value).ToList());
            EntryDate = item.EntryDate != null ? Convert.ToDateTime(item.EntryDate.Value) : (DateTime?)null;

        }
    }
    public class Lease
    {
        public string LeaseTerm { get; set; }
        public DateTime? LeaseDate { get; set; }
        public string Description { get; set; }
        public string Parties { get; set; }
        public Lease(BusinessGatewayRepositories.RES.Q1LeaseType item)
        {
            LeaseTerm = item.LeaseTerm != null ? item.LeaseTerm.Value : null;
            LeaseDate = item.LeaseDate != null ? Convert.ToDateTime(item.LeaseDate.Value) : (DateTime?)null;
            if (item.EntryDetails != null)
            {
                Description = item.EntryDetails.EntryText != null ? item.EntryDetails.EntryText.Value : null;
            }

            if (item.LeaseParty != null)
            {
                foreach (var _party in item.LeaseParty)
                {
                    var _partyName = _party.Item;
                    string _type = _partyName.GetType().ToString();
                    switch (_type)
                    {
                        case "BusinessGatewayRepositories.RES.Q1PrivateIndividualType":
                            var _private = (BusinessGatewayRepositories.RES.Q1PrivateIndividualType)_party.Item;
                            Parties += !String.IsNullOrEmpty(Parties) ? " and " + _private.Name.ForenamesName.Value + " " + _private.Name.SurnameName.Value : _private.Name.ForenamesName.Value + " " + _private.Name.SurnameName.Value;
                            break;
                        case "BusinessGatewayRepositories.RES.Q1OrganizationType":
                            var _organisation = (BusinessGatewayRepositories.RES.Q1OrganizationType)_party.Item;
                            Parties += !String.IsNullOrEmpty(Parties) ? " and " + _organisation.Name.Value : _organisation.Name.Value;
                            break;

                    }
                }
            }

        }
    }
    public class Schedule
    {
        public string EntryDescription { get; set; }
        public string EntryNumber { get; set; }
        public string EntryType { get; set; }
        public Schedule(BusinessGatewayRepositories.RES.Q1RegisterEntryType item)
        {
            EntryNumber = item.EntryNumber != null ? item.EntryNumber.Value : "";
            EntryType = item.EntryType != null ? item.EntryType.Value : "";
            EntryDescription = String.Join(",", item.EntryText.Select(s => s.Value).ToList());
        }
    }
    public class File
    {
        public byte[] Contents { get; set; }
        public string FileName { get; set; }
    }
    public class Restrictions
    {
        public string EntryNumber { get; set; }
        public string Description { get; set; }
        public Restrictions(BusinessGatewayRepositories.RES.Q1RestrictionType item)
        {
            if (item.EntryDetails != null)
            {
                this.EntryNumber = item.EntryDetails.EntryNumber != null ? item.EntryDetails.EntryNumber.Value : "";
                this.Description = item.EntryDetails.EntryText != null ? item.EntryDetails.EntryText.Value : "";
            }
        }
    }
    public class ResDetails
    {
        public string TitleNumber { get; set; }
        public string ClassOfTitle { get; set; }
        public string DistrictName { get; set; }
        public string AdministrativeArea { get; set; }
        public string LandRegOfficeName { get; set; }
        public DateTime? DateOfRegisteredExtract { get; set; }
        public ResDetails(BusinessGatewayRepositories.RES.Q1ResultsType item)
        {
            if (item.OCSummaryData != null)
            {
                if (item.OCSummaryData.Title != null)
                {
                    this.TitleNumber = item.OCSummaryData.Title.TitleNumber.Value;
                    this.DistrictName = item.OCSummaryData.Title.TitleRegistrationDetails.DistrictName != null ? item.OCSummaryData.Title.TitleRegistrationDetails.DistrictName.Value : "";
                    this.AdministrativeArea = item.OCSummaryData.Title.TitleRegistrationDetails.AdministrativeArea != null ? item.OCSummaryData.Title.TitleRegistrationDetails.AdministrativeArea.Value : "";
                    this.LandRegOfficeName = item.OCSummaryData.Title.TitleRegistrationDetails.LandRegistryOfficeName != null ? item.OCSummaryData.Title.TitleRegistrationDetails.LandRegistryOfficeName.Value : "";
                    this.DateOfRegisteredExtract = item.OCSummaryData.OfficialCopyDateTime != null ? (DateTime?)item.OCSummaryData.OfficialCopyDateTime.Value : (DateTime?)null;
                    if (item.OCSummaryData.Title.ClassOfTitleCode != null)
                    {
                        this.ClassOfTitle = ClassOfTitleCode(item.OCSummaryData.Title.ClassOfTitleCode.Value.ToString());
                    }
                }
            }
        }
        public string ClassOfTitleCode(string Class)
        {
            switch (Class)
            {
                case "10":
                    return "Absolute Freehold";
                case "20":
                    return "Possessory Freehold";
                case "30":
                    return "Qualified Freehold";
                case "40":
                    return "Scheme Title - Freehold";
                case "50":
                    return "Scheme Title - Leasehold";
                case "60":
                    return "Absolute Leasehold";
                case "70":
                    return "Good Leasehold";
                case "80":
                    return "Qualified Leasehold";
                case "90":
                    return "Possessory Leasehold";
                case "100":
                    return "Absolute Rentcharge";
                case "110":
                    return "Possessory Rentcharge";
                case "120":
                    return "Qualified Rentcharge";
                case "130":
                    return "Caution Against First Registration";
                default:
                    return "";
            }
        }
    }
    public class ProprietorRegister
    {
        public string EntryDescription { get; set; }
        public string EntryNumber { get; set; }
        public string EntryType { get; set; }
        public DateTime? EntryDate { get; set; }
        public ProprietorRegister(BusinessGatewayRepositories.RES.Q1RegisterEntryType item)
        {
            if (item != null)
            {
                EntryNumber = item.EntryNumber != null ? item.EntryNumber.Value : "";
                EntryType = item.EntryType != null ? item.EntryType.Value : "";
                EntryDescription = String.Join(",", item.EntryText.Select(s => s.Value).ToList());
                EntryDate = item.EntryDate != null ? Convert.ToDateTime(item.EntryDate.Value) : (DateTime?)null;
            }
        }
    }
    public class PropertyRegister
    {
        public string EntryDescription { get; set; }
        public string EntryNumber { get; set; }
        public string EntryType { get; set; }
        public DateTime? EntryDate { get; set; }
        public PropertyRegister(BusinessGatewayRepositories.RES.Q1RegisterEntryType item)
        {
            if (item != null)
            {
                EntryNumber = item.EntryNumber != null ? item.EntryNumber.Value : "";
                EntryType = item.EntryType != null ? item.EntryType.Value : "";
                EntryDescription = String.Join(",", item.EntryText.Select(s => s.Value).ToList());
                EntryDate = item.EntryDate != null ? Convert.ToDateTime(item.EntryDate.Value) : (DateTime?)null;
            }
        }
    }
    public class ResDetail
    {
        public string TitleNumber { get; set; }
        public string DistrictName { get; set; }
        public string AdministrativeArea { get; set; }
        public string LandRegOfficeName { get; set; }
        public string ClassOfTitle { get; set; }
        public DateTime? DateOfOfficeCopy { get; set; }
        public Nullable<bool> AgreedNoticeIndicator { get; set; }
        public Nullable<bool> BankruptcyIndicator { get; set; }
        public Nullable<bool> CautionIndicator { get; set; }
        public Nullable<bool> CCBIIndicator { get; set; }
        public Nullable<bool> ChargeeIndicator { get; set; }
        public Nullable<bool> ChargeIndicator { get; set; }
        public Nullable<bool> ChargeRelatedRestrictionIndicator { get; set; }
        public Nullable<bool> ChargeRestrictionIndicator { get; set; }
        public Nullable<bool> CreditorsNoticeIndicator { get; set; }
        public Nullable<bool> DeathOfProprietorIndicator { get; set; }
        public Nullable<bool> DeedOfPostponementIndicator { get; set; }
        public Nullable<bool> DiscountChargeIndicator { get; set; }
        public Nullable<bool> EquitableChargeIndicator { get; set; }
        public Nullable<bool> GreenOutEntryIndicator { get; set; }
        public Nullable<bool> HomeRightsChangeOfAddressIndicator { get; set; }
        public Nullable<bool> HomeRightsIndicator { get; set; }
        public Nullable<bool> LeaseHoldTitleIndicator { get; set; }
        public Nullable<bool> MultipleChargeIndicator { get; set; }
        public Nullable<bool> NonChargeRestrictionIndicator { get; set; }
        public Nullable<bool> NotedChargeIndicator { get; set; }
        public Nullable<bool> PricePaidIndicator { get; set; }
        public Nullable<bool> PropertyDescriptionNotesIndicator { get; set; }
        public Nullable<bool> RentChargeIndicator { get; set; }
        public Nullable<bool> RightOfPreEmptionIndicator { get; set; }
        public Nullable<bool> ScheduleOfLeasesIndicator { get; set; }
        public Nullable<bool> SubChargeIndicator { get; set; }
        public Nullable<bool> UnidentifiedEntryIndicator { get; set; }
        public Nullable<bool> UnilateralNoticeBeneficiaryIndicator { get; set; }
        public Nullable<bool> UnilateralNoticeIndicator { get; set; }
        public Nullable<bool> VendorsLienIndicator { get; set; }
        public ResDetail(string TitleNumber, BusinessGatewayRepositories.RES.Q1OCSummaryDataType item)
        {
            this.TitleNumber = TitleNumber;
            this.DistrictName = item.Title.TitleRegistrationDetails.DistrictName.Value;
            this.AdministrativeArea = item.Title.TitleRegistrationDetails.AdministrativeArea.Value;
            this.LandRegOfficeName = item.Title.TitleRegistrationDetails.LandRegistryOfficeName.Value;
            this.DateOfOfficeCopy = item.OfficialCopyDateTime.Value;
            if (item.Title.ClassOfTitleCode != null)
            {
                this.ClassOfTitle = ClassOfTitleCode(item.Title.ClassOfTitleCode.Value);
            }
            this.AgreedNoticeIndicator = item.RegisterEntryIndicators.AgreedNoticeIndicator.Value;
            this.BankruptcyIndicator = item.RegisterEntryIndicators.BankruptcyIndicator.Value;
            this.CautionIndicator = item.RegisterEntryIndicators.CautionIndicator.Value;
            this.CCBIIndicator = item.RegisterEntryIndicators.CCBIIndicator.Value;
            this.ChargeeIndicator = item.RegisterEntryIndicators.ChargeeIndicator.Value;
            this.ChargeIndicator = item.RegisterEntryIndicators.ChargeIndicator.Value;
            this.ChargeRelatedRestrictionIndicator = item.RegisterEntryIndicators.ChargeRelatedRestrictionIndicator.Value;
            this.ChargeRestrictionIndicator = item.RegisterEntryIndicators.ChargeRestrictionIndicator.Value;
            this.CreditorsNoticeIndicator = item.RegisterEntryIndicators.CreditorsNoticeIndicator.Value;
            this.DeathOfProprietorIndicator = item.RegisterEntryIndicators.DeathOfProprietorIndicator.Value;
            this.DeedOfPostponementIndicator = item.RegisterEntryIndicators.DeedOfPostponementIndicator.Value;
            this.DiscountChargeIndicator = item.RegisterEntryIndicators.DiscountChargeIndicator.Value;
            this.EquitableChargeIndicator = item.RegisterEntryIndicators.EquitableChargeIndicator.Value;
            this.GreenOutEntryIndicator = item.RegisterEntryIndicators.GreenOutEntryIndicator.Value;
            this.HomeRightsChangeOfAddressIndicator = item.RegisterEntryIndicators.HomeRightsChangeOfAddressIndicator.Value;
            this.HomeRightsIndicator = item.RegisterEntryIndicators.HomeRightsIndicator.Value;
            this.LeaseHoldTitleIndicator = item.RegisterEntryIndicators.LeaseHoldTitleIndicator.Value;
            this.MultipleChargeIndicator = item.RegisterEntryIndicators.MultipleChargeIndicator.Value;
            this.NonChargeRestrictionIndicator = item.RegisterEntryIndicators.NonChargeRestrictionIndicator.Value;
            this.NotedChargeIndicator = item.RegisterEntryIndicators.NotedChargeIndicator.Value;
            this.PricePaidIndicator = item.RegisterEntryIndicators.PricePaidIndicator.Value;
            this.PropertyDescriptionNotesIndicator = item.RegisterEntryIndicators.PropertyDescriptionNotesIndicator.Value;
            this.RentChargeIndicator = item.RegisterEntryIndicators.RentChargeIndicator.Value;
            this.RightOfPreEmptionIndicator = item.RegisterEntryIndicators.RightOfPreEmptionIndicator.Value;
            this.ScheduleOfLeasesIndicator = item.RegisterEntryIndicators.ScheduleOfLeasesIndicator.Value;
            this.SubChargeIndicator = item.RegisterEntryIndicators.SubChargeIndicator.Value;
            this.UnidentifiedEntryIndicator = item.RegisterEntryIndicators.UnidentifiedEntryIndicator.Value;
            this.UnilateralNoticeBeneficiaryIndicator = item.RegisterEntryIndicators.UnilateralNoticeBeneficiaryIndicator.Value;
            this.UnilateralNoticeIndicator = item.RegisterEntryIndicators.UnilateralNoticeIndicator.Value;
            this.VendorsLienIndicator = item.RegisterEntryIndicators.VendorsLienIndicator.Value;

        }
        public string ClassOfTitleCode(BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType Class)
        {
            switch (Class)
            {
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item10:
                    return "Absolute Freehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item20:
                    return "Possessory Freehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item30:
                    return "Qualified Freehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item40:
                    return "Scheme Title - Freehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item50:
                    return "Scheme Title - Leasehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item60:
                    return "Absolute Leasehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item70:
                    return "Good Leasehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item80:
                    return "Qualified Leasehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item90:
                    return "Possessory Leasehold";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item100:
                    return "Absolute Rentcharge";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item110:
                    return "Possessory Rentcharge";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item120:
                    return "Qualified Rentcharge";
                case BusinessGatewayRepositories.RES.ClassOfTitleCodeContentType.Item130:
                    return "Caution Against First Registration";
                default:
                    return "";
            }
        }
    }
}
