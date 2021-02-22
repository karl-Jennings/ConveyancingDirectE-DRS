using System;
using System.Collections.Generic;
using System.Text;
using static LrApiManager.XMLClases.Restriction.Organization;

namespace LrApiManager.XMLClases
{

    public class Rootobject
    {
        public Responseapplicationtochangeregisterv2_0 ResponseApplicationToChangeRegisterV2_0 { get; set; }
    }

    public class Responseapplicationtochangeregisterv2_0
    {
        public Gatewayresponse GatewayResponse { get; set; }
    }

    public class Gatewayresponse
    {
        public int TypeCode { get; set; }
        public Acknowledgement Acknowledgement { get; set; }
        public Rejection Rejection { get; set; }
        public Results Results { get; set; }
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
        public Validationerror[] ValidationErrors { get; set; }
    }

    public class Validationerror
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class Results
    {
        public string MessageDetails { get; set; }
        public string ExternalReference { get; set; }
        public int ActualFee { get; set; }
        public bool FeeAdjusted { get; set; }
        public bool EarlyCompletionIndicator { get; set; }
        public bool AdditionalDespatchItemsIndicator { get; set; }
        public int ResultTypeCode { get; set; }
        public string DespatchDocument { get; set; }
        public Xmlregister[] XmlRegisters { get; set; }
    }

    public class Xmlregister
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
        public Propertyaddress[] PropertyAddress { get; set; }
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

    public class Pricepaidentry
    {
        public object MultipleTitleIndicator { get; set; }
        public Entrydetails EntryDetails { get; set; }
    }

    public class Entrydetails
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills Infills { get; set; }
    }

    public class Infills
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Title
    {
        public string TitleNumber { get; set; }
        public int ClassOfTitleCode { get; set; }
        public bool CommonholdIndicator { get; set; }
        public Titleregistrationdetails TitleRegistrationDetails { get; set; }
    }

    public class Titleregistrationdetails
    {
        public string DistrictName { get; set; }
        public string AdministrativeArea { get; set; }
        public string LandRegistryOfficeName { get; set; }
        public string LatestEditionDate { get; set; }
        public PostcodeZone[] PostcodeZone { get; set; }
        public string RegistrationDate { get; set; }
    }

 
    public class Registerentryindicators
    {
        public bool AgreedNoticeIndicator { get; set; }
        public bool BankruptcyIndicator { get; set; }
        public bool CautionIndicator { get; set; }
        public bool CCBIIndicator { get; set; }
        public bool ChargeeIndicator { get; set; }
        public bool ChargeIndicator { get; set; }
        public bool ChargeRelatedRestrictionIndicator { get; set; }
        public bool ChargeRestrictionIndicator { get; set; }
        public bool CreditorsNoticeIndicator { get; set; }
        public bool DeathOfProprietorIndicator { get; set; }
        public bool DeedOfPostponementIndicator { get; set; }
        public bool DiscountChargeIndicator { get; set; }
        public bool EquitableChargeIndicator { get; set; }
        public bool GreenOutEntryIndicator { get; set; }
        public bool HomeRightsChangeOfAddressIndicator { get; set; }
        public bool HomeRightsIndicator { get; set; }
        public bool LeaseHoldTitleIndicator { get; set; }
        public bool MultipleChargeIndicator { get; set; }
        public bool NonChargeRestrictionIndicator { get; set; }
        public bool NotedChargeIndicator { get; set; }
        public bool PricePaidIndicator { get; set; }
        public bool PropertyDescriptionNotesIndicator { get; set; }
        public bool RentChargeIndicator { get; set; }
        public bool RightOfPreEmptionIndicator { get; set; }
        public bool ScheduleOfLeasesIndicator { get; set; }
        public bool SubChargeIndicator { get; set; }
        public bool UnidentifiedEntryIndicator { get; set; }
        public bool UnilateralNoticeBeneficiaryIndicator { get; set; }
        public bool UnilateralNoticeIndicator { get; set; }
        public bool VendorsLienIndicator { get; set; }
    }

    public class Proprietorship
    {
        public string CurrentProprietorshipDate { get; set; }
        public Cautionerparty[] CautionerParty { get; set; }
    }

    public class Cautionerparty
    {
        public Privateindividual PrivateIndividual { get; set; }
        public Address[] Address { get; set; }
        public Charitydetails CharityDetails { get; set; }
        public string TradingName { get; set; }
        public string PartyNumber { get; set; }
        public string PartyDescription { get; set; }
    }

    public class Privateindividual
    {
        public Name Name { get; set; }
        public Alias[] Alias { get; set; }
    }

    public class Name
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Alias
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Charitydetails
    {
        public string[] CharityName { get; set; }
        public Charityaddress[] CharityAddress { get; set; }
        public string CharityType { get; set; }
    }

    public class Charityaddress
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline AddressLine { get; set; }
    }

  

    public class Addressline
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
    }

    public class Address
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline1 AddressLine { get; set; }
    }

   

    public class Addressline1
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
    }

    public class Lease
    {
        public Leaseentry[] LeaseEntry { get; set; }
    }

    public class Leaseentry
    {
        public string LeaseTerm { get; set; }
        public string LeaseDate { get; set; }
        public string Rent { get; set; }
        public Leaseparty[] LeaseParty { get; set; }
        public Entrydetails1 EntryDetails { get; set; }
    }

    public class Entrydetails1
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills1 Infills { get; set; }
    }

    public class Infills1
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Leaseparty
    {
        public Privateindividual1 PrivateIndividual { get; set; }
        public Address1[] Address { get; set; }
        public Charitydetails1 CharityDetails { get; set; }
        public string TradingName { get; set; }
        public string PartyNumber { get; set; }
        public string PartyDescription { get; set; }
    }

    public class Privateindividual1
    {
        public Name1 Name { get; set; }
        public Alias1[] Alias { get; set; }
    }

    public class Name1
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Alias1
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Charitydetails1
    {
        public string[] CharityName { get; set; }
        public Charityaddress1[] CharityAddress { get; set; }
        public string CharityType { get; set; }
    }

    public class Charityaddress1
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline2 AddressLine { get; set; }
    }

  
    public class Addressline2
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
    }

    public class Address1
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline3 AddressLine { get; set; }
    }

   

    public class Addressline3
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
    }

    public class Restrictiondetails
    {
        public Restrictionentry[] RestrictionEntry { get; set; }
    }

    public class Restrictionentry
    {
        public Chargerelatedrestriction ChargeRelatedRestriction { get; set; }
    }

    public class Chargerelatedrestriction
    {
        public int RestrictionTypeCode { get; set; }
        public string ChargeID { get; set; }
        public Entrydetails2 EntryDetails { get; set; }
    }

    public class Entrydetails2
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills2 Infills { get; set; }
    }

    public class Infills2
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Charge
    {
        public Chargeentry[] ChargeEntry { get; set; }
    }

    public class Chargeentry
    {
        public string ChargeID { get; set; }
        public string ChargeDate { get; set; }
        public Registeredcharge RegisteredCharge { get; set; }
        public Chargeproprietor ChargeProprietor { get; set; }
        public Subcharge[] SubCharge { get; set; }
    }

    public class Registeredcharge
    {
        public string MultipleTitleIndicator { get; set; }
        public Entrydetails3 EntryDetails { get; set; }
    }

    public class Entrydetails3
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills3 Infills { get; set; }
    }

    public class Infills3
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Chargeproprietor
    {
        public object ChargeeParty { get; set; }
        public Entrydetails4 EntryDetails { get; set; }
    }

    public class Entrydetails4
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills4 Infills { get; set; }
    }

    public class Infills4
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Subcharge
    {
        public string ChargeDate { get; set; }
        public Registeredcharge1 RegisteredCharge { get; set; }
        public Chargeproprietor1 ChargeProprietor { get; set; }
    }

    public class Registeredcharge1
    {
        public string MultipleTitleIndicator { get; set; }
        public Entrydetails5 EntryDetails { get; set; }
    }

    public class Entrydetails5
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills5 Infills { get; set; }
    }

    public class Infills5
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Chargeproprietor1
    {
        public Chargeeparty[] ChargeeParty { get; set; }
        public Entrydetails6 EntryDetails { get; set; }
    }

    public class Entrydetails6
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills6 Infills { get; set; }
    }

    public class Infills6
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Chargeeparty
    {
        public Privateindividual2 PrivateIndividual { get; set; }
        public Address2[] Address { get; set; }
        public Charitydetails2 CharityDetails { get; set; }
        public string TradingName { get; set; }
        public string PartyNumber { get; set; }
        public string PartyDescription { get; set; }
    }

    public class Privateindividual2
    {
        public Name2 Name { get; set; }
        public Alias2[] Alias { get; set; }
    }

    public class Name2
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Alias2
    {
        public string ForenamesName { get; set; }
        public string SurnameName { get; set; }
    }

    public class Charitydetails2
    {
        public string[] CharityName { get; set; }
        public Charityaddress2[] CharityAddress { get; set; }
        public string CharityType { get; set; }
    }

    public class Charityaddress2
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline4 AddressLine { get; set; }
    }

    

    public class Addressline4
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
    }

    public class Address2
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline5 AddressLine { get; set; }
    }

   
    public class Addressline5
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
    }

    public class Agreednotice
    {
        public Agreednoticeentry[] AgreedNoticeEntry { get; set; }
    }

    public class Agreednoticeentry
    {
        public int AgreedNoticeType { get; set; }
        public Entrydetails7 EntryDetails { get; set; }
    }

    public class Entrydetails7
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills7 Infills { get; set; }
    }

    public class Infills7
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Bankruptcy
    {
        public Entrydetail[] EntryDetails { get; set; }
    }

    public class Entrydetail
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills8 Infills { get; set; }
    }

    public class Infills8
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Caution
    {
        public Entrydetail1[] EntryDetails { get; set; }
    }

    public class Entrydetail1
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills9 Infills { get; set; }
    }

    public class Infills9
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Deedofpostponement
    {
        public Entrydetail2[] EntryDetails { get; set; }
    }

    public class Entrydetail2
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills10 Infills { get; set; }
    }

    public class Infills10
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Greenoutentry
    {
        public Entrydetail3[] EntryDetails { get; set; }
    }

    public class Entrydetail3
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills11 Infills { get; set; }
    }

    public class Infills11
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Homerights
    {
        public Homerightsentry[] HomeRightsEntry { get; set; }
    }

    public class Homerightsentry
    {
        public bool ChangeOfAddressIndicator { get; set; }
        public Homerightsentrydetails HomeRightsEntryDetails { get; set; }
        public Changeofaddressentrydetails ChangeOfAddressEntryDetails { get; set; }
    }

    public class Homerightsentrydetails
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills12 Infills { get; set; }
    }

    public class Infills12
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Changeofaddressentrydetails
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills13 Infills { get; set; }
    }

    public class Infills13
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Rentcharge
    {
        public Entrydetail4[] EntryDetails { get; set; }
    }

    public class Entrydetail4
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills14 Infills { get; set; }
    }

    public class Infills14
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Vendorslien
    {
        public Entrydetail5[] EntryDetails { get; set; }
    }

    public class Entrydetail5
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills15 Infills { get; set; }
    }

    public class Infills15
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Rightofpreemption
    {
        public Entrydetail6[] EntryDetails { get; set; }
    }

    public class Entrydetail6
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills16 Infills { get; set; }
    }

    public class Infills16
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Documentdetails
    {
        public Document[] Document { get; set; }
    }

    public class Document
    {
        public int DocumentType { get; set; }
        public string DocumentDate { get; set; }
        public string[] EntryNumber { get; set; }
        public bool PlanOnlyIndicator { get; set; }
        public string FiledUnder { get; set; }
        public string RegisterDescription { get; set; }
    }

    public class Unilateralnoticedetails
    {
        public Unilateralnoticeentry[] UnilateralNoticeEntry { get; set; }
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
        public Infills17 Infills { get; set; }
    }

    public class Infills17
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Unilateralnoticebeneficiary
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills18 Infills { get; set; }
    }

    public class Infills18
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Deathofproprietor
    {
        public Entrydetail7[] EntryDetails { get; set; }
    }

    public class Entrydetail7
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills19 Infills { get; set; }
    }

    public class Infills19
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Discountcharge
    {
        public Entrydetail8[] EntryDetails { get; set; }
    }

    public class Entrydetail8
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills20 Infills { get; set; }
    }

    public class Infills20
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Equitablecharge
    {
        public Entrydetail9[] EntryDetails { get; set; }
    }

    public class Entrydetail9
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills21 Infills { get; set; }
    }

    public class Infills21
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Notedcharge
    {
        public Entrydetail10[] EntryDetails { get; set; }
    }

    public class Entrydetail10
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills22 Infills { get; set; }
    }

    public class Infills22
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Creditorsnotice
    {
        public Entrydetail11[] EntryDetails { get; set; }
    }

    public class Entrydetail11
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills23 Infills { get; set; }
    }

    public class Infills23
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Unidentifiedentry
    {
        public Entrydetail12[] EntryDetails { get; set; }
    }

    public class Entrydetail12
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills24 Infills { get; set; }
    }

    public class Infills24
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Ccbientry
    {
        public Entrydetail13[] EntryDetails { get; set; }
    }

    public class Entrydetail13
    {
        public string EntryNumber { get; set; }
        public string EntryText { get; set; }
        public string RegistrationDate { get; set; }
        public string SubRegisterCode { get; set; }
        public Infills25 Infills { get; set; }
    }

    public class Infills25
    {
        public string Amount { get; set; }
        public string ChargeDate { get; set; }
        public string ChargeParty { get; set; }
    }

    public class Propertyaddress
    {
        public PostcodeZone PostcodeZone { get; set; }
        public Addressline6 AddressLine { get; set; }
    }

   

    public class Addressline6
    {
        public float[] IndexNumeric { get; set; }
        public string[] Line { get; set; }
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
        public object RegisterEntry { get; set; }
        public Schedule[] Schedule { get; set; }
    }

    public class Districtdetails
    {
        public string[] EntryText { get; set; }
    }

    public class Schedule
    {
        public string ScheduleType { get; set; }
        public Scheduleentry[] ScheduleEntry { get; set; }
    }

    public class Scheduleentry
    {
        public string EntryNumber { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public string[] EntryText { get; set; }
    }

    public class Proprietorshipregister
    {
        public Districtdetails1 DistrictDetails { get; set; }
        public object RegisterEntry { get; set; }
        public Schedule1[] Schedule { get; set; }
    }

    public class Districtdetails1
    {
        public string[] EntryText { get; set; }
    }

    public class Schedule1
    {
        public string ScheduleType { get; set; }
        public Scheduleentry1[] ScheduleEntry { get; set; }
    }

    public class Scheduleentry1
    {
        public string EntryNumber { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public string[] EntryText { get; set; }
    }

    public class Chargesregister
    {
        public Districtdetails2 DistrictDetails { get; set; }
        public Registerentry[] RegisterEntry { get; set; }
        public Schedule2[] Schedule { get; set; }
    }

    public class Districtdetails2
    {
        public string[] EntryText { get; set; }
    }

    public class Registerentry
    {
        public string EntryNumber { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public string[] EntryText { get; set; }
    }

    public class Schedule2
    {
        public string ScheduleType { get; set; }
        public Scheduleentry2[] ScheduleEntry { get; set; }
    }

    public class Scheduleentry2
    {
        public string EntryNumber { get; set; }
        public string EntryDate { get; set; }
        public string EntryType { get; set; }
        public string[] EntryText { get; set; }
    }


    /////
    ///

  

}
