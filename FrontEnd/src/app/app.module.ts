import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SettingsComponent } from './settings/settings.component';
import { RegistrationComponent } from './registration/registration.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { MatButtonModule } from '@angular/material/button';
import { MatRadioModule } from '@angular/material/radio';
import { Error404Component } from './error404/error404.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatDialogModule } from '@angular/material/dialog';
import { ConfirmRegistrationComponent } from './angular-dialogs/confirm-registration/confirm-registration.component';
import { LoginComponent } from './login/login.component';
import { ToastrModule } from 'ngx-toastr';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterceptor } from './Interceptor/AuthIntercepter';
import { MatTableModule } from '@angular/material/table';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { ApplicationViewComponent } from './angular-dialogs/application-view/application-view.component';
import { ViewDocumentRegistrationsComponent } from './view-document-registrations/view-document-registrations.component';
import { ScenarioComponent } from './scenario/scenario.component';
import { MatTabsModule } from '@angular/material/tabs';
import { MatSliderModule } from '@angular/material/slider';
import { MatExpansionModule } from '@angular/material/expansion';
import { LrCredentialsComponent } from './settings/lr-credentials/lr-credentials.component';
import { MatBadgeModule } from '@angular/material/badge';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { ProgressComponent } from './angular-dialogs/progress/progress.component';
import { UserDetailsComponent } from './angular-dialogs/user-details/user-details.component';

@NgModule({
  declarations: [
    AppComponent,
    SettingsComponent,
    RegistrationComponent,
    Error404Component,
    ConfirmRegistrationComponent,
    LoginComponent,
    ViewDocumentRegistrationsComponent,
    ApplicationViewComponent,
    ScenarioComponent,
    LrCredentialsComponent,
    ProgressComponent,
    UserDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MDBBootstrapModule.forRoot(),
    FormsModule,
    MatButtonModule,
    MatRadioModule,
    MatIconModule,
    MatInputModule,
    HttpClientModule,
    MatSelectModule,
    MatAutocompleteModule,
    ReactiveFormsModule,
    MatDialogModule,
    ToastrModule.forRoot(),
    MatTableModule,
    MatDatepickerModule,
    MatCheckboxModule,
    MatTabsModule,
    MatExpansionModule,
    MatBadgeModule,
    MatSliderModule,
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
