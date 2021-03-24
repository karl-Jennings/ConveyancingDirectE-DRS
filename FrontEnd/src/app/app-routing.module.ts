import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { Error404Component } from './error404/error404.component';
import { RegistrationComponent } from './registration/registration.component';
import { SettingsComponent } from './settings/settings.component';
import { ScenarioComponent } from './scenario/scenario.component';
import { ViewDocumentRegistrationsComponent } from './view-document-registrations/view-document-registrations.component';

const routes: Routes = [
  { path: '', redirectTo: 'registration', pathMatch: 'full' },
  { path: 'registration', component: RegistrationComponent, data: { title: "Registration", path: "Registration" } },
  { path: 'settings', component: SettingsComponent, data: { title: "Settings", path: "Settings" } },

  { path: 'registration/transfer-and-charge/:regTypeId', component: ScenarioComponent, data: { title: "Transfer And Charge", path: "Registration / Transfer And Charge / Create", animation: "isRight" } },
  { path: 'registration/transfer-and-charge/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer And Charge", path: "Registration / Transfer And Charge / View all", animation: "isRight" } },
  { path: 'registration/transfer-and-charge/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Transfer And Charge", path: "Registration / Transfer And Charge / Update", animation: "isRight" } },

  { path: 'registration/remortgage/:regTypeId', component: ScenarioComponent, data: { title: "Remortgage", path: "Registration / Remortgage / Create", animation: "isRight" } },
  { path: 'registration/remortgage/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Remortgage", path: "Registration / Remortgage / View all", animation: "isRight" } },
  { path: 'registration/remortgage/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Remortgage", path: "Registration / Remortgage / Update", animation: "isRight" } },

  { path: 'registration/transfer-equity/:regTypeId', component: ScenarioComponent, data: { title: "Transfer of equity", path: "Registration / Transfer of equity / Create", animation: "isRight" } },
  { path: 'registration/transfer-equity/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer of equity", path: "Registration / Transfer of equity / View all", animation: "isRight" } },
  { path: 'registration/transfer-equity/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Transfer of equity", path: "Registration / Transfer of equity / Update", animation: "isRight" } },

  { path: 'registration/removal-form/:regTypeId', component: ScenarioComponent, data: { title: "Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / Create", animation: "isRight" } },
  { path: 'registration/removal-form/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / View all", animation: "isRight" } },
  { path: 'registration/removal-form/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Restriction, hostile takeover", path: "Registration / Restriction, hostile takeover / Update", animation: "isRight" } },

  { path: 'registration/change-name/:regTypeId', component: ScenarioComponent, data: { title: "Change of Name", path: "Registration / Change of Name / Create", animation: "isRight" } },
  { path: 'registration/change-name/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Change of Name", path: "Registration / Change of Name / View all", animation: "isRight" } },
  { path: 'registration/change-name/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Change of Name", path: "Registration / Change of Name / Update", animation: "isRight" } },

  { path: 'registration/dispositionary/:regTypeId', component: ScenarioComponent, data: { title: "Dispositionary first lease", path: "Registration / Dispositionary first lease / Create", animation: "isRight" } },
  { path: 'registration/dispositionary/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Dispositionary first lease", path: "Registration / Dispositionary first lease / View all", animation: "isRight" } },
  { path: 'registration/dispositionary/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Dispositionary first lease", path: "Registration / Dispositionary first lease / Update", animation: "isRight" } },

  { path: 'registration/lease-extension/:regTypeId', component: ScenarioComponent, data: { title: "Lease Extension", path: "Registration / Lease Extension / Create", animation: "isRight" } },
  { path: 'registration/lease-extension/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Lease Extensions", path: "Registration / Lease Extension / View all", animation: "isRight" } },
  { path: 'registration/lease-extension/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Lease Extension", path: "Registration / Lease Extension / Update", animation: "isRight" } },

  { path: 'registration/transfer/:regTypeId', component: ScenarioComponent, data: { title: "Transfer of Part", path: "Registration / Transfer of Part / Create", animation: "isRight" } },
  { path: 'registration/transfer/:regTypeId/view-all', component: ViewDocumentRegistrationsComponent, data: { title: "View Transfer of Parts", path: "Registration / Transfer of Part / View all", animation: "isRight" } },
  { path: 'registration/transfer/:regTypeId/:docRefId', component: ScenarioComponent, data: { title: "Update Transfer of Part", path: "Registration / Transfer of Part / Update", animation: "isRight" } },

  { path: '**', component: Error404Component, data: { title: "Error", path: "Error" } },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }