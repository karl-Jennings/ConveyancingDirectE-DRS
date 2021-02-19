import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { Error404Component } from './error404/error404.component';
import { LeaseExtensionComponent } from './lease-extension/lease-extension.component';
import { RegistrationComponent } from './registration/registration.component';
import { SettingsComponent } from './settings/settings.component';
import { TransferOfPartComponent } from './transfer-of-part/transfer-of-part.component';
import { RemovalOfDefaultComponent } from './removal-of-default/removal-of-default.component';
import { ViewDocumentRegistrationsComponent } from './view-document-registrations/view-document-registrations.component';

const routes: Routes = [
  { path: '', redirectTo: 'registration', pathMatch: 'full' },
  { path: 'registration', component: RegistrationComponent, data: { title: "Registration", path: "Registration" } },
  { path: 'settings', component: SettingsComponent, data: { title: "Settings", path: "Settings" } },

  { path: 'registration/lease-extension/:regTypeId', component: LeaseExtensionComponent, data: { title: "Lease Extension", path: "Registration / Lease Extension", animation: "isRight" } },
  { path: 'registration/lease-extension/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Lease Extensions", path: "Registration / Lease Extension / View all", animation: "isRight" } },
  { path: 'registration/lease-extension/:regTypeId/:docRefId', component: LeaseExtensionComponent, data: { title: "Update Lease Extension", path: "Registration / Lease Extension / Update", animation: "isRight" } },

  { path: 'registration/transfer/:regTypeId', component: TransferOfPartComponent, data: { title: "Transfer of Part", path: "Registration / Transfer of Part", animation: "isRight" } },
  { path: 'registration/transfer/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer of Parts", path: "Registration / Transfer of Part / View all", animation: "isRight" } },
  { path: 'registration/transfer/:regTypeId/:docRefId', component: TransferOfPartComponent, data: { title: "Update Transfer of Part", path: "Registration / Transfer of Part / Update", animation: "isRight" } },

  { path: 'registration/removal-form/:regTypeId', component: RemovalOfDefaultComponent, data: { title: "Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover", animation: "isRight" } },
  { path: 'registration/removal-form/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / View all", animation: "isRight" } },
  { path: 'registration/removal-form/:regTypeId/:docRefId', component: RemovalOfDefaultComponent, data: { title: "Update Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / Update", animation: "isRight" } },

  { path: '**', component: Error404Component, data: { title: "Error", path: "Error" } },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }