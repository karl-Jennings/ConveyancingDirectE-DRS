import { Roles } from "./roles"

export class Party {
    IsApplicant?: boolean
    CompanyOrForeName?: string
    Surname?: string
    Roles?: string;
    ViewModelRoles?: string[];
    LocalId?: number;
    IsSelected?: boolean;
    PartyType?: string;
    AddressForService?: string;
}
