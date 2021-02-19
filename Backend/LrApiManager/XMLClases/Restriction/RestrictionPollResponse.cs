using System;
using System.Collections.Generic;
using System.Text;
using LrApiManager.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LrApiManager.XMLClases.Restriction
{
    [Serializable]
    public class RestrictionPollResponse
    {
        public string TypeCode { get; set; }

        [JsonProperty("Results")]
        [JsonConverter(typeof(CustomArrayConverter<Results>))]
        public IEnumerable<Results> Results { get; set; }
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

        [JsonProperty("DespatchDocument")]
        [JsonConverter(typeof(CustomArrayConverter<Despatchdocument>))]
        public IEnumerable<Despatchdocument> DespatchDocument { get; set; }

        [JsonProperty("XmlRegisters")]
        [JsonConverter(typeof(CustomArrayConverter<Xmlregisters>))]
        public IEnumerable<Xmlregisters> XmlRegisters { get; set; }
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

        [JsonProperty("OCSummaryData")]
        [JsonConverter(typeof(CustomArrayConverter<Ocsummarydata>))]
        public IEnumerable<Ocsummarydata> OCSummaryData { get; set; }

        [JsonProperty("XmlRegisterData")]
        [JsonConverter(typeof(CustomArrayConverter<Xmlregisterdata>))]
        public IEnumerable<Xmlregisterdata> XmlRegisterData { get; set; }
    }

    public class Ocsummarydata
    {
        public DateTime OfficialCopyDateTime { get; set; }
        public string EditionDate { get; set; }

        [JsonProperty("PropertyAddress")]
        [JsonConverter(typeof(CustomArrayConverter<Propertyaddress>))]
        public IEnumerable<Propertyaddress> PropertyAddress { get; set; }

        [JsonProperty("Title")]
        [JsonConverter(typeof(CustomArrayConverter<TitleResponse>))]
        public IEnumerable<TitleResponse> Title { get; set; }

        [JsonProperty("RegisterEntryIndicators")]
        [JsonConverter(typeof(CustomArrayConverter<Registerentryindicators>))]
        public IEnumerable<Registerentryindicators> RegisterEntryIndicators { get; set; }

        [JsonProperty("Proprietorship")]
        [JsonConverter(typeof(CustomArrayConverter<Proprietorship>))]
        public IEnumerable<Proprietorship> Proprietorship { get; set; }

        [JsonProperty("RestrictionDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Restrictiondetails>))]
        public IEnumerable<Restrictiondetails> RestrictionDetails { get; set; }

        [JsonProperty("Charge")]
        [JsonConverter(typeof(CustomArrayConverter<Charge>))]
        public IEnumerable<Charge> Charge { get; set; }

        [JsonProperty("DocumentDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Documentdetails>))]
        public IEnumerable<Documentdetails> DocumentDetails { get; set; }
    }

    public class Propertyaddress
    {
        public Addressline AddressLine { get; set; }
    }

    public class Addressline
    {
        public string[] Line { get; set; }
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
        public string[] Line { get; set; }
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
        public string EntryText { get; set; }
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
    }

    public class Address1
    {
        [JsonProperty("PostcodeZone")]
        [JsonConverter(typeof(CustomArrayConverter<Postcodezone>))]
        public IEnumerable<Postcodezone> PostcodeZone { get; set; }

        [JsonProperty("AddressLine")]
        [JsonConverter(typeof(CustomArrayConverter<Addressline2>))]
        public IEnumerable<Addressline2> AddressLine { get; set; }
    }

    public class Postcodezone
    {
        public string Postcode { get; set; }
    }

    public class Addressline2
    {
        public string[] Line { get; set; }
    }

    public class Entrydetails2
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
    }

    public class Documentdetails
    {
        public DocumentReponse[] Document { get; set; }
    }

    public class DocumentReponse
    {
        public string DocumentType { get; set; }
        public string DocumentDate { get; set; }
        public string[] EntryNumber { get; set; }
        public string PlanOnlyIndicator { get; set; }
        public string RegisterDescription { get; set; }
    }

    public class Xmlregisterdata
    {
        public string TitleNumber { get; set; }

        [JsonProperty("PropertyRegister")]
        [JsonConverter(typeof(CustomArrayConverter<Propertyregister>))]
        public  IEnumerable<Propertyregister> PropertyRegister { get; set; }

        [JsonProperty("ProprietorshipRegister")]
        [JsonConverter(typeof(CustomArrayConverter<Proprietorshipregister>))]
        public IEnumerable<Proprietorshipregister> ProprietorshipRegister { get; set; }

        [JsonProperty("ChargesRegister")]
        [JsonConverter(typeof(CustomArrayConverter<Chargesregister>))]
        public IEnumerable<Chargesregister> ChargesRegister { get; set; }
    }

    public class Propertyregister
    {
        [JsonProperty("DistrictDetails")]
        [JsonConverter(typeof(CustomArrayConverter<Districtdetails>))]
        public IEnumerable<Districtdetails> DistrictDetails { get; set; }

        public Registerentry[] RegisterEntry { get; set; }
    }

    public class Districtdetails
    {
        public string EntryText { get; set; }
    }

    public class Registerentry
    {
        public string EntryNumber { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public string EntryText { get; set; }
    }

    public class Proprietorshipregister
    {
        public Registerentry1[] RegisterEntry { get; set; }
    }

    public class Registerentry1
    {
        public string EntryNumber { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public string EntryText { get; set; }
    }

    public class Chargesregister
    {
        public Registerentry2[] RegisterEntry { get; set; }
    }

    public class Registerentry2
    {
        public string EntryNumber { get; set; }
        public string EntryType { get; set; }
        public object EntryText { get; set; }
        public string EntryDate { get; set; }
    }



   
}
