using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases.Requestapplicationtochangeregisterv2_1
{
 
    public class Requestapplicationtochangeregisterv2_1
    {

        public Requestapplicationtochangeregisterv2_1()
        {

        }
        public string AdditionalProviderFilter { get; set; }
        public string MessageId { get; set; }
        public string ExternalReference { get; set; }
        public Product Product { get; set; }
    }

    public class Product
    {
        public string Reference { get; set; }
        public int TotalFeeInPence { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
        public bool AP1WarningUnderstood { get; set; }
        public string ApplicationDate { get; set; }
        public bool DisclosableOveridingInterests { get; set; }
        public string PostcodeOfProperty { get; set; }
        public string LocalAuthority { get; set; }
        public Titles Titles { get; set; }
        public Applications Applications { get; set; }
        public Supportingdocuments SupportingDocuments { get; set; }
        public Representations Representations { get; set; }
        public Parties Parties { get; set; }
        public Additionalpartynotifications AdditionalPartyNotifications { get; set; }
        public string Notes { get; set; }
        public string ApplicationAffects { get; set; }
    }

    public class Titles
    {
        public Dealing Dealing { get; set; }
    }

    public class Dealing
    {
        public Dealingtitles DealingTitles { get; set; }
    }

    public class Dealingtitles


    {
        public string[] TitleNumber { get; set; }
    }

    public class Applications
    {
        public Otherapplication[] OtherApplication { get; set; }
        public Chargeapplication[] ChargeApplication { get; set; }
    }

    public class Chargeapplication
    {
        public int Priority { get; set; }
        public string Value { get; set; }
        public int FeeInPence { get; set; }
        public Document Document { get; set; }
        public string ChargeDate { get; set; }
        public string MDRef { get; set; }
        public string SortCode { get; set; }
    }

    public class Document
    {
        public string CertifiedCopy { get; set; }
    }

    public class Otherapplication
    {
        public float Priority { get; set; }
        public string Value { get; set; }
        public float FeeInPence { get; set; }
        public Document1 Document { get; set; }
        public string Type { get; set; }
    }

    public class Document1
    {
        public string CertifiedCopy { get; set; }
    }

    public class Supportingdocuments
    {
        public Supportingdocument[] SupportingDocument { get; set; }
    }

    public class Supportingdocument
    {
        public string CertifiedCopy { get; set; }
        public float DocumentId { get; set; }
        public string DocumentName { get; set; }
    }

    public class Representations
    {
        public Lodgingconveyancer LodgingConveyancer { get; set; }
        public Representingconveyancer[] RepresentingConveyancer { get; set; }
        public Certified Certified { get; set; }
        public Identityevidence IdentityEvidence { get; set; }
    }

    public class Lodgingconveyancer
    {
        public int RepresentativeId { get; set; }
    }

    public class Certified
    {
        public int RepresentativeId { get; set; }
    }

    public class Identityevidence
    {
        public int RepresentativeId { get; set; }
    }

    public class Representingconveyancer
    {
        public float RepresentativeId { get; set; }
        public string ConveyancerName { get; set; }
        public string Reference { get; set; }
        public Dxaddress DXAddress { get; set; }
    }

    public class Dxaddress
    {
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
        public string DXNumber { get; set; }
        public string DXExchange { get; set; }
    }

    public class Parties
    {
        public Party[] Party { get; set; }
    }

    public class Party
    {
        public bool IsApplicant { get; set; }
        public Company Company { get; set; }
        public Roles Roles { get; set; }
        public Addressforservice AddressForService { get; set; }
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string OverseasTerritory { get; set; }
        public string OverseasNumberInTheUnitedKingdom { get; set; }
    }

    public class Roles
    {
        public Role[] Role { get; set; }
    }

    public class Role
    {
        public string RoleType { get; set; }
        public float Priority { get; set; }
    }

    public class Addressforservice
    {
        public Postaladdress PostalAddress { get; set; }
        public Additionaladdresses AdditionalAddresses { get; set; }
    }

    public class Postaladdress
    {
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }

    public class Additionaladdresses
    {
        public Postaladdress1 PostalAddress { get; set; }
        public Emailaddress EmailAddress { get; set; }
    }

    public class Postaladdress1
    {
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }

    public class Emailaddress
    {
        public string Email { get; set; }
    }

    public class Additionalpartynotifications
    {
        public Additionalpartynotification[] AdditionalPartyNotification { get; set; }
    }

    public class Additionalpartynotification
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public Emailaddress1 EmailAddress { get; set; }
    }

    public class Emailaddress1
    {
        public string Email { get; set; }
    }

}
