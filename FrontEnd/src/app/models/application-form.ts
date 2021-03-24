export class ApplicationForm {
    ApplicationFormId?: number;
    Priority?: number;
    Value?: string;
    FeeInPence?: number;
    Type?: string;
    LocalId?: any;
    IsSelected?: boolean;
    Document?: Document;
    Variety?: string;
    IsChecked?: boolean;

}

export class Document {
    DocumentId?: number;
    CertifiedCopy?: string;
    Base64?: string;
    FileName?: string;
    FileExtension?: string;
    ApplicationFormId?: number;

}
