using System;
using System.Collections.Generic;
using System.Text;
using LrApiManager.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace LrApiManager.XMLClases.PollResponse
{
    [Serializable]
    public class PollResponse
    {
        public string TypeCode { get; set; }
        public Acknowledgement Acknowledgement { get; set; }
        public Rejection Rejection { get; set; }
        public Results Results { get; set; }
    }

    public class Results
    {
        public string MessageDetails { get; set; }
        public string ExternalReference { get; set; }
        public string ActualFee { get; set; }
        public string FeeAdjusted { get; set; }
        public string EarlyCompletionIndicator { get; set; }
        public string AdditionalDespatchItemsIndicator { get; set; }
        public string ResultTypeCode { get; set; }
        public Despatchdocument DespatchDocument { get; set; }

        [JsonProperty("XmlRegisters")]
        [JsonConverter(typeof(CustomArrayConverter<Xmlregisters>))]
        public IEnumerable<Xmlregisters> XmlRegisters { get; set; }
    }

    public class Acknowledgement
    {
        public string UniqueID { get; set; }
        public string MessageDescription { get; set; }
        public DateTime ExpectedResponseDateTime { get; set; }
        public DateTime PriorityDateTime { get; set; }
        public string ABR { get; set; }
    }

    public class Rejection
    {
        public string ExternalReference { get; set; }
        public Rejectionresponse RejectionResponse { get; set; }
    }

    public class Rejectionresponse
    {
        public string Reason { get; set; }
        public string Code { get; set; }
        public string OtherDescription { get; set; }

        [JsonProperty("ValidationErrors")]
        [JsonConverter(typeof(CustomArrayConverter<Validationerror>))]
        public IEnumerable<Validationerror> ValidationErrors { get; set; }
    }

    public class Validationerror
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
    public class Despatchdocument
    {
        public string filename { get; set; }
        public string format { get; set; }
        public string byteArray { get; set; }
    }

    public class Xmlregisters
    {
        public string TitleNumber { get; set; }
        public Ocsummarydata OCSummaryData { get; set; }
        public Xmlregisterdata XmlRegisterData { get; set; }
    }

    public class Ocsummarydata
    {
        public DateTime OfficialCopyDateTime { get; set; }
        public string EditionDate { get; set; }
        public Pricepaidentry PricePaidEntry { get; set; }

        [JsonProperty("PropertyAddress")]
        [JsonConverter(typeof(CustomArrayConverter<Propertyaddress>))]
        public IEnumerable<Propertyaddress> PropertyAddress { get; set; }
        public Title Title { get; set; }
        public Registerentryindicators RegisterEntryIndicators { get; set; }
        public Proprietorship Proprietorship { get; set; }
        public Lease Lease { get; set; }
        public Restrictiondetails RestrictionDetails { get; set; }
        public Charge Charge { get; set; }
        public Agreednotice AgreedNotice { get; set; }
        public Bankruptcy Bankruptcy { get; set; }
        public Caution Caution { get; set; }
        public Deedofpostponement DeedOfPostponement { get; set; }
        public Greenoutentry GreenOutEntry { get; set; }
        public Homerights HomeRights { get; set; }
        public Rentcharge RentCharge { get; set; }
        public Vendorslien VendorsLien { get; set; }
        public Rightofpreemption RightOfPreEmption { get; set; }
        public Documentdetails DocumentDetails { get; set; }
        public Unilateralnoticedetails UnilateralNoticeDetails { get; set; }
        public Deathofproprietor DeathOfProprietor { get; set; }
        public Discountcharge DiscountCharge { get; set; }
        public Equitablecharge EquitableCharge { get; set; }
        public Notedcharge NotedCharge { get; set; }
        public Creditorsnotice CreditorsNotice { get; set; }
        public Unidentifiedentry UnidentifiedEntry { get; set; }
        public Ccbientry CCBIEntry { get; set; }
    }

    public class Propertyaddress
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline AddressLine { get; set; }


    }

    public class Addressline
    {
        [JsonProperty("Line")]
        [JsonConverter(typeof(CustomArrayConverter<string>))]
        public IEnumerable<string> Line { get; set; }
    }

    public class TitleResponse
    {
        public string TitleNumber { get; set; }
        public string ClassOfTitleCode { get; set; }
        public string CommonholdIndicator { get; set; }

        [JsonProperty("TitleRegistrationDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Titleregistrationdetails>))]
        public IEnumerable<Titleregistrationdetails> TitleRegistrationDetails { get; set; }
    }

    public class Titleregistrationdetails
    {
        public string DistrictName { get; set; }
        public string AdministrativeArea { get; set; }
        public string LandRegistryOfficeName { get; set; }
        public string LatestEditionDate { get; set; }
        public string RegistrationDate { get; set; }
        public PostcodeZone PostcodeZone { get; set; }
    }

    public class Registerentryindicators
    {
        public string AgreedNoticeIndicator { get; set; }
        public string BankruptcyIndicator { get; set; }
        public string CautionIndicator { get; set; }
        public string CCBIIndicator { get; set; }
        public string ChargeeIndicator { get; set; }
        public string ChargeIndicator { get; set; }
        public string ChargeRelatedRestrictionIndicator { get; set; }
        public string ChargeRestrictionIndicator { get; set; }
        public string CreditorsNoticeIndicator { get; set; }
        public string DeathOfProprietorIndicator { get; set; }
        public string DeedOfPostponementIndicator { get; set; }
        public string DiscountChargeIndicator { get; set; }
        public string EquitableChargeIndicator { get; set; }
        public string GreenOutEntryIndicator { get; set; }
        public string HomeRightsChangeOfAddressIndicator { get; set; }
        public string HomeRightsIndicator { get; set; }
        public string LeaseHoldTitleIndicator { get; set; }
        public string MultipleChargeIndicator { get; set; }
        public string NonChargeRestrictionIndicator { get; set; }
        public string NotedChargeIndicator { get; set; }
        public string PricePaidIndicator { get; set; }
        public string PropertyDescriptionNotesIndicator { get; set; }
        public string RentChargeIndicator { get; set; }
        public string RightOfPreEmptionIndicator { get; set; }
        public string ScheduleOfLeasesIndicator { get; set; }
        public string SubChargeIndicator { get; set; }
        public string UnidentifiedEntryIndicator { get; set; }
        public string UnilateralNoticeBeneficiaryIndicator { get; set; }
        public string UnilateralNoticeIndicator { get; set; }
        public string VendorsLienIndicator { get; set; }
    }

    public class Proprietorship
    {
        public string CurrentProprietorshipDate { get; set; }

        [JsonProperty("RegisteredProprietorParty")]
        [JsonConverter(typeof(CustomArrayConverter<Registeredproprietorparty>))]
        public IEnumerable<Registeredproprietorparty> RegisteredProprietorParty { get; set; }
    }

    public class Registeredproprietorparty
    {
        [JsonProperty("PrivateIndividual")]
        [JsonConverter(typeof(CustomArrayConverter<Privateindividual>))]
        public IEnumerable<Privateindividual> PrivateIndividual { get; set; }

        [JsonProperty("Address")]
        [JsonConverter(typeof(CustomArrayConverter<Address>))]
        public IEnumerable<Address> Address { get; set; }
    }

    public class Privateindividual
    {
        [JsonProperty("Name")]
        [JsonConverter(typeof(CustomArrayConverter<Name>))]
        public IEnumerable<Name> Name { get; set; }
    }

    public class Name
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Address
    {
        [JsonProperty("AddressLine")]
        [JsonConverter(typeof(CustomArrayConverter<Addressline1>))]
        public IEnumerable<Addressline1> AddressLine { get; set; }
    }

    public class Addressline1
    {

        [JsonProperty("Line")]
        [JsonConverter(typeof(CustomArrayConverter<string>))]
        public IEnumerable<string> Line { get; set; }
    }

    public class Restrictiondetails
    {
        [JsonProperty("RestrictionEntry")]
        [JsonConverter(typeof(CustomArrayConverter<Restrictionentry>))]
        public IEnumerable<Restrictionentry> RestrictionEntry { get; set; }
    }

    public class Restrictionentry
    {
        [JsonProperty("ChargeRestriction")]
        [JsonConverter(typeof(CustomArrayConverter<Chargerestriction>))]
        public IEnumerable<Chargerestriction> ChargeRestriction { get; set; }
    }

    public class Chargerestriction
    {
        public string RestrictionTypeCode { get; set; }
        public string ChargeID { get; set; }

        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Entrydetails
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public string ScheduleCode { get; set; }

        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills>))]
        public IEnumerable<Infills> Infills { get; set; }


    }

    public class Infills
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
        public string Date { get; set; }
        public string DeedDate { get; set; }
        public string DeedExtent { get; set; }
        public string DeedParty { get; set; }
        public string DeedType { get; set; }
        public string ExtentOfLand { get; set; }
        public string MiscellaneousText { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string OptionalMiscText { get; set; }
        public string PlansReference { get; set; }
        public string TitleNumber { get; set; }
        public string VerbatimText { get; set; }


    }

    public class Charge
    {
        [JsonProperty("ChargeEntry")]
        [JsonConverter(typeof(CustomArrayConverter<Chargeentry>))]
        public IEnumerable<Chargeentry> ChargeEntry { get; set; }
    }

    public class Chargeentry
    {
        public string ChargeID { get; set; }
        public string ChargeDate { get; set; }

        [JsonProperty("RegisteredCharge")]
        [JsonConverter(typeof(CustomArrayConverter<Registeredcharge>))]
        public IEnumerable<Registeredcharge> RegisteredCharge { get; set; }

        [JsonProperty("ChargeProprietor")]
        [JsonConverter(typeof(CustomArrayConverter<Chargeproprietor>))]
        public IEnumerable<Chargeproprietor> ChargeProprietor { get; set; }
    }

    public class Registeredcharge
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }   


    public class Chargeproprietor
    {
        [JsonProperty("ChargeeParty")]
        [JsonConverter(typeof(CustomArrayConverter<Chargeeparty>))]
        public IEnumerable<Chargeeparty> ChargeeParty { get; set; }

        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Chargeeparty
    {
        [JsonProperty("Organization")]
        [JsonConverter(typeof(CustomArrayConverter<Organization>))]
        public IEnumerable<Organization> Organization { get; set; }

        [JsonProperty("Address")]
        [JsonConverter(typeof(CustomArrayConverter<Address1>))]
        public IEnumerable<Address1> Address { get; set; }
    }

    public class Organization
    {
        public string Name { get; set; }

    }
        public class Address1
        {
            public PostcodeZone PostcodeZone { get; set; }

            [JsonProperty("AddressLine")]
            [JsonConverter(typeof(CustomArrayConverter<Addressline2>))]
            public IEnumerable<Addressline2> AddressLine { get; set; }
        }

        public class PostcodeZone
        {
            [JsonProperty("Postcode")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> Postcode { get; set; }
        }

        public class Addressline2
        {
            [JsonProperty("Line")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> Line { get; set; }
        }

       

        public class Documentdetails
        {
            [JsonProperty("Document")]
            [JsonConverter(typeof(CustomArrayConverter<DocumentReponse>))]
            public IEnumerable<DocumentReponse> Document { get; set; }
        }

        public class DocumentReponse
        {
            public string DocumentType { get; set; }
            public string DocumentDate { get; set; }

            [JsonProperty("EntryNumber")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> EntryNumber { get; set; }
            public string PlanOnlyIndicator { get; set; }
            public string RegisterDescription { get; set; }
        }

        public class Xmlregisterdata
        {
            public string TitleNumber { get; set; }
            public Propertyregister PropertyRegister { get; set; }
            public Proprietorshipregister ProprietorshipRegister { get; set; }
            public Chargesregister ChargesRegister { get; set; }
        }

        public class Propertyregister
        {
            public Districtdetails DistrictDetails { get; set; }

            [JsonProperty("RegisterEntry")]
            [JsonConverter(typeof(CustomArrayConverter<Registerentry>))]
            public IEnumerable<Registerentry> RegisterEntry { get; set; }

            [JsonProperty("Schedule")]
            [JsonConverter(typeof(CustomArrayConverter<Schedule>))]
            public IEnumerable<Schedule> Schedule { get; set; }
        }

        public class Districtdetails
        {
            [JsonProperty("EntryText")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> EntryText { get; set; }
        }

        public class Registerentry
        {
            public string EntryNumber { get; set; }
            public string EntryDate { get; set; }
            public string EntryType { get; set; }

            [JsonProperty("EntryText")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> EntryText { get; set; }
        }

        public class Schedule
        {
            public string ScheduleType { get; set; }

            [JsonProperty("ScheduleEntry")]
            [JsonConverter(typeof(CustomArrayConverter<Scheduleentry>))]
            public IEnumerable<Scheduleentry> ScheduleEntry { get; set; }
        }

        public class Scheduleentry
        {
            public string EntryNumber { get; set; }
            public string EntryDate { get; set; }
            public string EntryType { get; set; }

            [JsonProperty("EntryText")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> EntryText { get; set; }
        }

        public class Proprietorshipregister
        {

            [JsonProperty("RegisterEntry")]
            [JsonConverter(typeof(CustomArrayConverter<Registerentry>))]
            public IEnumerable<Registerentry> RegisterEntry { get; set; }
        }


        public class Chargesregister
        {
            [JsonProperty("RegisterEntry")]
            [JsonConverter(typeof(CustomArrayConverter<Registerentry>))]
            public IEnumerable<Registerentry> RegisterEntry { get; set; }
        }

        public class Lease
        {           
            public Leaseentry LeaseEntry { get; set; }
        }

        public class Leaseentry
        {
            public string LeaseTerm { get; set; }
            public string LeaseDate { get; set; }
            public string Rent { get; set; }

            [JsonProperty("LeaseParty")]
            [JsonConverter(typeof(CustomArrayConverter<Leaseparty>))]
            public IEnumerable<Leaseparty> LeaseParty { get; set; }

            [JsonProperty("EntryDetails")]
            [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
            public IEnumerable<Entrydetails> EntryDetails { get; set; }

        }




        public class Leaseparty
        {
            public Privateindividual PrivateIndividual { get; set; }

            public Organization Organisation { get; set; }

            [JsonProperty("Address")]
            [JsonConverter(typeof(CustomArrayConverter<Address1>))]
            public IEnumerable<Address1> Address { get; set; }
            public Charitydetails CharityDetails { get; set; }
            public string TradingName { get; set; }
            public string PartyNumber { get; set; }
            public string PartyDescription { get; set; }
        }


        public class Charitydetails
        {
            [JsonProperty("CharityName")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> CharityName { get; set; }

            [JsonProperty("CharityAddress")]
            [JsonConverter(typeof(CustomArrayConverter<Charityaddress>))]
            public IEnumerable<Charityaddress> CharityAddress { get; set; }
            public string CharityType { get; set; }
        }

        public class Charityaddress
        {
            public PostcodeZone PostcodeZone { get; set; }
            public Addressline AddressLine { get; set; }
        }


    public class Agreednotice
    {
        [JsonProperty("AgreedNoticeEntry")]
        [JsonConverter(typeof(CustomArrayConverter<Agreednoticeentry>))]
        public IEnumerable<Agreednoticeentry> AgreedNoticeEntry { get; set; }
    }

    public class Agreednoticeentry
    {
        public int AgreedNoticeType { get; set; }

        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }



    public class Pricepaidentry
    {
        public object MultipleTitleIndicator { get; set; }

        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }


    public class Title
    {
        public string TitleNumber { get; set; }
        public int ClassOfTitleCode { get; set; }
        public bool CommonholdIndicator { get; set; }
        public Titleregistrationdetails TitleRegistrationDetails { get; set; }
    }

    public class Bankruptcy
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Caution
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }


    public class Deedofpostponement
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Greenoutentry
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Homerights
    {
        [JsonProperty("HomeRightsEntry")]
        [JsonConverter(typeof(CustomArrayConverter<Homerightsentry>))]
        public IEnumerable<Homerightsentry> HomeRightsEntry { get; set; }
    }

    public class Homerightsentry
    {
        public bool ChangeOfAddressIndicator { get; set; }

        [JsonProperty("HomeRightsEntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Homerightsentrydetails>))]
        public IEnumerable<Homerightsentrydetails> HomeRightsEntryDetails { get; set; }

        [JsonProperty("ChangeOfAddressEntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Changeofaddressentrydetails>))]
        public IEnumerable<Changeofaddressentrydetails> ChangeOfAddressEntryDetails { get; set; }
    }

    public class Homerightsentrydetails
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills>))]
        public IEnumerable<Infills> Infills { get; set; }

    }


    public class Changeofaddressentrydetails
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }

        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills>))]
        public IEnumerable<Infills> Infills { get; set; }

    }

    public class Rentcharge
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Vendorslien
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Rightofpreemption
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Unilateralnoticedetails
    {
        [JsonProperty("UnilateralNoticeEntry")]
        [JsonConverter(typeof(CustomArrayConverter<Unilateralnoticeentry>))]
        public IEnumerable< Unilateralnoticeentry> UnilateralNoticeEntry { get; set; }
    }

    public class Unilateralnoticeentry
    {
        public Unilateralnotice UnilateralNotice { get; set; }
        public Unilateralnoticebeneficiary UnilateralNoticeBeneficiary { get; set; }
    }

    public class Unilateralnotice
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public string ScheduleCode { get; set; }

        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills>))]
        public IEnumerable<Infills> Infills { get; set; }
    }

    public class Unilateralnoticebeneficiary
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; } 
        public string ScheduleCode { get; set; }

        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills>))]
        public IEnumerable<Infills> Infills { get; set; }
    }

    public class Deathofproprietor
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Discountcharge
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Equitablecharge
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Notedcharge
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Creditorsnotice
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Unidentifiedentry
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }

    public class Ccbientry
    {
        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails>))]
        public IEnumerable<Entrydetails> EntryDetails { get; set; }
    }
}




