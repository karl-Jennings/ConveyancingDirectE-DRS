using System;
using System.Collections.Generic;
using System.Text;
using LrApiManager.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static LrApiManager.XMLClases.Restriction.Organization;

namespace LrApiManager.XMLClases.Restriction
{
    [Serializable]
    public class RestrictionPollResponse
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
        public  IEnumerable<string> Line { get; set; }
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

        [JsonProperty("EntryText")]
        [JsonConverter(typeof(CustomArrayConverter<string>))]
        public IEnumerable<string> EntryText { get; set; }
        public string SubRegisterCode { get; set; }

        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills>))]
        public IEnumerable<Infills> Infills { get; set; }
    }

    public class Infills
    {
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
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
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails1>))]
        public IEnumerable<Entrydetails1> EntryDetails { get; set; }
    }

    public class Entrydetails1
    {
        public string EntryNumber { get; set; }

        [JsonProperty("EntryText")]
        [JsonConverter(typeof(CustomArrayConverter<string>))]
        public IEnumerable<string> EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }

        [JsonProperty("Infills")]
        [JsonConverter(typeof(CustomArrayConverter<Infills1>))]
        public IEnumerable<Infills1> Infills { get; set; }
    }

    public class Infills1
    {
        public string ChargeDate { get; set; }
    }

    public class Chargeproprietor
    {
        [JsonProperty("ChargeeParty")]
        [JsonConverter(typeof(CustomArrayConverter<Chargeeparty>))]
        public IEnumerable<Chargeeparty> ChargeeParty { get; set; }

        [JsonProperty("EntryDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Entrydetails2>))]
        public IEnumerable<Entrydetails2> EntryDetails { get; set; }
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

        public class Entrydetails2
        {
            public string EntryNumber { get; set; }

            [JsonProperty("EntryText")]
            [JsonConverter(typeof(CustomArrayConverter<string>))]
            public IEnumerable<string> EntryText { get; set; }
            public string RegistrationDate { get; set; }
            public string SubRegisterCode { get; set; }
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


    }


   
}
