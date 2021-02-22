using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases.Remortgage
{
    public class RemortgageApplicationRequest
    {
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
        public int TelephoneNumber { get; set; }
        public bool AP1WarningUnderstood { get; set; }
        public string ApplicationDate { get; set; }
        public bool DisclosableOveridingInterests { get; set; }
        public string PostcodeOfProperty { get; set; }
        public string LocalAuthority { get; set; }
        public List<Dealing> Titles { get; set; }
        public ApplicationsObject Applications { get; set; }
        public List<Supportingdocument> SupportingDocuments { get; set; }
        public RepresentationsObject Representations { get; set; }
        public List<Party> Parties { get; set; }
        public List<Additionalpartynotification> AdditionalPartyNotifications { get; set; }
        public string Notes { get; set; }
        public string ApplicationAffects { get; set; }
    }

    public class Titles
    {
        public Dealing Dealing { get; set; }
    }

    public class TitleNumber
    {
        public string TitleString { get; set; }
    }


    public class Dealing
    {
        public Dealingtitles DealingTitles { get; set; }
    }

    public class Dealingtitles
    {
        public TitleNumber[] TitleNumber { get; set; }
    }

    public class Applications
    {
        public Chargeapplication ChargeApplication { get; set; }
    }

    public class Chargeapplication
    {
        public int Priority { get; set; }
        public int Value { get; set; }
        public int FeeInPence { get; set; }
        public Document Document { get; set; }
        public string ChargeDate { get; set; }
        public string MDRef { get; set; }
    }

    public class Document
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
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
    }

    public class Representations
    {
        public Lodgingconveyancer LodgingConveyancer { get; set; }
        public Identityevidence IdentityEvidence { get; set; }
    }

    public class Lodgingconveyancer
    {
        public int RepresentativeId { get; set; }
    }

    public class Identityevidence
    {
        public int RepresentativeId { get; set; }
    }

    public class Parties
    {
        public Party[] Party { get; set; }
    }

    public class Party
    {
        public bool IsApplicant { get; set; }
        public Person Person { get; set; }
        public List<Role> Roles { get; set; }
        public Addressforservice AddressForService { get; set; }
        public Company Company { get; set; }
    }

    public class Person
    {
        public string Forenames { get; set; }
        public string Surname { get; set; }
    }

    public class Roles
    {
        public Role Role { get; set; }
    }

    public class Role
    {
        public string RoleType { get; set; }
        public int Priority { get; set; }
    }

    public class Addressforservice
    {
        public string AddressForServiceOption { get; set; }
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyRegistrationNumber { get; set; }
    }
    public class ApplicationsObject
    {
        public List<OtherapplicationObject> OtherApplication { get; set; }

        public List<ChargeapplicationObject> ChargeApplication { get; set; }
    }

    public class OtherapplicationObject
    {
        public int Priority { get; set; }
        public int Value { get; set; }
        public int FeeInPence { get; set; }
        public Document Document { get; set; }
        public string Type { get; set; }
    }
    public class ChargeapplicationObject
    {
        public int Priority { get; set; }
        public decimal Value { get; set; }
        public int FeeInPence { get; set; }
        public Document Document { get; set; }
        public string ChargeDate { get; set; }
        public string MDRef { get; set; }
        public string SortCode { get; set; }
    }
    public class RepresentationsObject
    {
        public LodgingconveyancerObject LodgingConveyancer { get; set; }
        public Certified Certified { get; set; }
        public IdentityevidenceObject IdentityEvidence { get; set; }


    }

    public class LodgingconveyancerObject
    {
        public int RepresentativeId { get; set; }
    }

    public class IdentityevidenceObject{
          public int RepresentativeId { get; set; }
    }

    public class RepresentingConveyancerObject
    {
        public int RepresentativeId { get; set; }
        public string ConveyancerName { get; set; }
        public string Reference { get; set; }
        public DXAddress DXAddress { get; set; }
    }
    public class Certified
    {
        public int RepresentativeId { get; set; }
    }

    public class Additionalpartynotification
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public Address Address { get; set; }
    }

    public class DXAddress
    {

        public CareOfAddressType CareOfAddressType { get; set; }
        public string DXNumber { get; set; }
        public string DXExchange { get; set; }
    }

   

    public class Address
    {
        public DXAddress DXAddress { get; set; }
    }

    public class CareOfAddressType
    {
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
    }

}
