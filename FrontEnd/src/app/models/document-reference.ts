import { ApplicationForm } from "./application-form";
import { AttachmentNotes } from "./attachment-notes";
import { Party } from "./party";
import { Representation } from "./representation";
import { RequestLogs } from "./request-logs";
import { SupportingDocuments } from "./supporting-documents";
import { TitleNumber } from "./title-number";

export class DocumentReference {
    DocumentReferenceId?: number;
    UserID?: string;
    Password?: string;
    AdditionalProviderFilter?: string;
    MessageID?: string;
    ExternalReference?: string;
    Reference?: string;
    TotalFeeInPence?: number;
    Email?: string;
    TelephoneNumber?: number;
    AP1WarningUnderstood?: boolean;
    ApplicationDate?: string;
    DisclosableOveridingInterests?: boolean;
    ApplicationAffects?: string;
    RegistrationTypeId?: string;
    UserId?: number;

    Titles?: TitleNumber[];
    Applications?: ApplicationForm[];
    SupportingDocuments?: SupportingDocuments[];
    Parties?: Party[];
    AttachmentNotes?: AttachmentNotes[];
    RequestLogs?: RequestLogs[];
    Representations?: Representation[];


}
