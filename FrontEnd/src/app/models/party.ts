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
    Addresses?: Address[];
}

export class Address {
    AddressId?: number;
    Type?: string;
    SubType?: string;

    AddressLine1?: string;

    AddressLine2?: string;
    AddressLine3?: string;
    AddressLine4?: string;
    City?: string;
    County?: string;
    Country?: string;
    PostCode?: string;

    CareOfName?: string;
    CareOfReference?: string;
    DxNumber?: string;
    DxExchange?: string;

    EmailAddress?: string;
}