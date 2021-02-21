﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LrApiManager.XMLClases.LeaseExtension
{

    public class LeaseExtensionApplicationRequest
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
        public List<Leaseextension> Titles { get; set; }
        public List<Otherapplication> Applications { get; set; }
        public List<Supportingdocument> SupportingDocuments { get; set; }

        public Representations Representations { get; set; }
        public List<Party> Parties { get; set; }
        public string Notes { get; set; }
        public string ApplicationAffects { get; set; }
    }
   

    public class Leaseextension
    {
        public TitleNumber[] LessorTitles { get; set; }
        public LesseeTitle[] LesseeTitle { get; set; }
    }

    public class TitleNumber
    {
        public string TitleString { get; set; }
    }
    public class LesseeTitle {

        public string TitleString { get; set; }
    }

    public class Applications
    {
        public List<Otherapplication> OtherApplication { get; set; }
    }

    public class Otherapplication
    {
        public int Priority { get; set; }
        public int Value { get; set; }
        public int FeeInPence { get; set; }
        public Document Document { get; set; }
        public string Type { get; set; }
    }

    public class Document
    {
        public string CertifiedCopy { get; set; }
    }

    public class Supportingdocuments
    {
        public List<Supportingdocument> SupportingDocument { get; set; }
        public List<Chargeapplication> ChargeApplication { get; set; }

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

    public class Supportingdocument
    {
        public string CertifiedCopy { get; set; }
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
    }

    public class Representations
    {
        public Lodgingconveyancer LodgingConveyancer { get; set; }
        public Certified Certified { get; set; }
    }

    public class Lodgingconveyancer
    {
        public int RepresentativeId { get; set; }
    }

    public class Certified
    {
        public int RepresentativeId { get; set; }
    }

    public class Parties
    {
        public List<Party> Party { get; set; }
    }

    public class Party
    {
        public bool IsApplicant { get; set; }
        public Person Person { get; set; }
        public Company Company { get; set; }
        public List<Role> Roles { get; set; }
        public Addressforservice AddressForService { get; set; }

    }

    public class Person
    {
        public string Forenames { get; set; }
        public string Surname { get; set; }
    }

    public class Roles
    {
        public List<Role> Role { get; set; }
    }

    public class Role
    {
        public string RoleType { get; set; }
        public int Priority { get; set; }
    }

    public class Addressforservice
    {
        /* String values are A1, B1 or TA, where A1 is the
           address of the property(A1 register), B1 is current
           proprietor address(B1 register) and TA is address from
           Transfer/Assent. */
        public string AddressForServiceOption { get; set; }

        public PostalAddress PostalAddress { get; set; }

        public List<AdditionalAddresses> AdditionalAddresses { get; set; }
    }

    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyRegistrationNumber { get; set; }
        public string OverseasTerritory { get; set; }
        public string OverseasNumberInTheUnitedKingdom { get; set; }
    }

    public class PostalAddress
    {

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine4 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }

        public CareOfAddressType CareOfAddressType { get; set; }

    }

    public class CareOfAddressType
    {
        public string CareOfName { get; set; }
        public string CareOfReference { get; set; }
    }

    public class AdditionalAddresses
    {

        public PostalAddress PostalAddress { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public DXAddress DXAddress { get; set; }
    }

    public class EmailAddress
    {
        public string Email { get; set; }
    }

    public class DXAddress
    {

        public CareOfAddressType CareOfAddressType { get; set; }
        public string DXNumber { get; set; }
        public string DXExchange { get; set; }
    }

}