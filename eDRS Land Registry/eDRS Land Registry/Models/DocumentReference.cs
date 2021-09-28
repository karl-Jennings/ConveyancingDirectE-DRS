﻿using System;
using System.Collections.Generic;
using eDrsDB.Models;

namespace eDRS_Land_Registry.Models
{
    public class DocumentReference
    {
        public long DocumentReferenceId { get; set; }
        public string Reference { get; set; }
        public int TotalFeeInPence { get; set; }
        public string MessageID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long TelephoneNumber { get; set; }
        public string AdditionalProviderFilter { get; set; }
        public string ExternalReference { get; set; }
        public bool AP1WarningUnderstood { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool DisclosableOveridingInterests { get; set; }
        public string PostcodeOfProperty { get; set; }
        public string LocalAuthority { get; set; }
        public string ApplicationAffects { get; set; }
        public bool Status { get; set; }
        public long RegistrationTypeId { get; set; }
        public RegistrationType RegistrationType { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public string ServiceTitleType { get; set; }
        public List<TitleNumber> Titles { get; set; }
        public List<ApplicationForm> Applications { get; set; }
        public List<SupportingDocuments> SupportingDocuments { get; set; }
        public List<Representation> Representations { get; set; }
        public List<Party> Parties { get; set; }
        public List<AttachmentNote> AttachmentNotes { get; set; }
        public List<RequestLog> RequestLogs { get; set; }

    }
}
