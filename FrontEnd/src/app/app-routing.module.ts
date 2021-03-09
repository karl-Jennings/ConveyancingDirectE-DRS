import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { Error404Component } from './error404/error404.component';
import { LeaseExtensionComponent } from './lease-extension/lease-extension.component';
import { RegistrationComponent } from './registration/registration.component';
import { SettingsComponent } from './settings/settings.component';
import { TransferOfPartComponent } from './transfer-of-part/transfer-of-part.component';
import { RemovalOfDefaultComponent } from './removal-of-default/removal-of-default.component';
import { ViewDocumentRegistrationsComponent } from './view-document-registrations/view-document-registrations.component';
import { TransferAndChargeComponent } from './transfer-and-charge/transfer-and-charge.component';
import { RemortgageComponent } from './remortgage/remortgage.component';
import { TransferOfEquityComponent } from './transfer-of-equity/transfer-of-equity.component';
import { ChangeOfNameComponent } from './change-of-name/change-of-name.component';
import { DispositionaryComponent } from './dispositionary/dispositionary.component';

const routes: Routes = [
  { path: '', redirectTo: 'registration', pathMatch: 'full' },
  { path: 'registration', component: RegistrationComponent, data: { title: "Registration", path: "Registration" } },
  { path: 'settings', component: SettingsComponent, data: { title: "Settings", path: "Settings" } },

  { path: 'registration/transfer-and-charge/:regTypeId', component: TransferAndChargeComponent, data: { title: "Transfer And Charge", path: "Registration / Transfer And Charge", animation: "isRight" } },
  { path: 'registration/transfer-and-charge/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer And Charge", path: "Registration / Transfer And Charge / View all", animation: "isRight" } },
  { path: 'registration/transfer-and-charge/:regTypeId/:docRefId', component: TransferAndChargeComponent, data: { title: "Update Transfer And Charge", path: "Registration / Transfer And Charge / Update", animation: "isRight" } },

  { path: 'registration/remortgage/:regTypeId', component: RemortgageComponent, data: { title: "Remortgage", path: "Registration / Remortgage", animation: "isRight" } },
  { path: 'registration/remortgage/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Remortgage", path: "Registration / Remortgage / View all", animation: "isRight" } },
  { path: 'registration/remortgage/:regTypeId/:docRefId', component: RemortgageComponent, data: { title: "Update Remortgage", path: "Registration / Remortgage / Update", animation: "isRight" } },

  { path: 'registration/transfer-equity/:regTypeId', component: TransferOfEquityComponent, data: { title: "Transfer of equity", path: "Registration / Transfer of equity", animation: "isRight" } },
  { path: 'registration/transfer-equity/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer of equity", path: "Registration / Transfer of equity / View all", animation: "isRight" } },
  { path: 'registration/transfer-equity/:regTypeId/:docRefId', component: TransferOfEquityComponent, data: { title: "Update Transfer of equity", path: "Registration / Transfer of equity / Update", animation: "isRight" } },

  { path: 'registration/removal-form/:regTypeId', component: RemovalOfDefaultComponent, data: { title: "Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover", animation: "isRight" } },
  { path: 'registration/removal-form/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / View all", animation: "isRight" } },
  { path: 'registration/removal-form/:regTypeId/:docRefId', component: RemovalOfDefaultComponent, data: { title: "Update Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / Update", animation: "isRight" } },

  { path: 'registration/change-name/:regTypeId', component: ChangeOfNameComponent, data: { title: "Change of Name", path: "Registration / Change of Name", animation: "isRight" } },
  { path: 'registration/change-name/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Change of Name", path: "Registration / Change of Name / View all", animation: "isRight" } },
  { path: 'registration/change-name/:regTypeId/:docRefId', component: ChangeOfNameComponent, data: { title: "Update Change of Name", path: "Registration / Change of Name / Update", animation: "isRight" } },

  { path: 'registration/dispositionary/:regTypeId', component: DispositionaryComponent, data: { title: "Dispositionary first lease", path: "Registration / Dispositionary first lease", animation: "isRight" } },
  { path: 'registration/dispositionary/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Dispositionary first lease", path: "Registration / Dispositionary first lease / View all", animation: "isRight" } },
  { path: 'registration/dispositionary/:regTypeId/:docRefId', component: DispositionaryComponent, data: { title: "Update Dispositionary first lease", path: "Registration / Dispositionary first lease / Update", animation: "isRight" } },

  { path: 'registration/lease-extension/:regTypeId', component: LeaseExtensionComponent, data: { title: "Lease Extension", path: "Registration / Lease Extension", animation: "isRight" } },
  { path: 'registration/lease-extension/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Lease Extensions", path: "Registration / Lease Extension / View all", animation: "isRight" } },
  { path: 'registration/lease-extension/:regTypeId/:docRefId', component: LeaseExtensionComponent, data: { title: "Update Lease Extension", path: "Registration / Lease Extension / Update", animation: "isRight" } },

  { path: 'registration/transfer/:regTypeId', component: TransferOfPartComponent, data: { title: "Transfer of Part", path: "Registration / Transfer of Part", animation: "isRight" } },
  { path: 'registration/transfer/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer of Parts", path: "Registration / Transfer of Part / View all", animation: "isRight" } },
  { path: 'registration/transfer/:regTypeId/:docRefId', component: TransferOfPartComponent, data: { title: "Update Transfer of Part", path: "Registration / Transfer of Part / Update", animation: "isRight" } },

  { path: '**', component: Error404Component, data: { title: "Error", path: "Error" } },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { } 