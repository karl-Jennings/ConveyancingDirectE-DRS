namespace eDRS_Land_Registry.Models
{
    public class SupportingDocuments
    {
        public long SupportingDocumentId { get; set; }

        public string CertifiedCopy { get; set; }
        public long DocumentId { get; set; }
        public string DocumentName { get; set; }

        public string AdditionalProviderFilter { get; set; }
        public long MessageId { get; set; }
        public string ExternalReference { get; set; }
        public string ApplicationMessageId { get; set; }
        public string ApplicationService { get; set; }

        public string ApplicationType { get; set; }
        public string DocumentType { get; set; }

        public string Notes { get; set; }

        public string Base64 { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }

        public bool IsChecked { get; set; }

        public long DocumentReferenceId { get; set; }

    }
}