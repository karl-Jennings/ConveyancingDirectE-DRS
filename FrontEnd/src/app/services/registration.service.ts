import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { DocumentReference } from '../models/document-reference';

@Injectable({
  providedIn: 'root'
})
export class RegistrationService {
  private GetRegistrationTypesUrl = environment.apiURL + 'Registration/GetRegistrationTypes';
  private GetRegistrationTypeUrl = environment.apiURL + 'Registration/GetRegistrationType';
  private CreateRegistrationUrl = environment.apiURL + 'Registration/CreateRegistration';
  private UpdateRegistrationUrl = environment.apiURL + 'Registration/UpdateRegistration';
  private DeleteRegistrationUrl = environment.apiURL + 'Registration/DeleteRegistration';
  private GetRegistrationsUrl = environment.apiURL + 'Registration/GetRegistrations';
  private GetRegistrationUrl = environment.apiURL + 'Registration/GetRegistration';
  private GetPoolResponseUrl = environment.apiURL + 'Registration/GetPoolResponse';

  constructor(private http: HttpClient) {

  }

  getRegistrationTypes(): Observable<any> {
    return this.http.get(this.GetRegistrationTypesUrl);
  }

  GetRegistrationType(regType: string): Observable<any> {
    return this.http.get(this.GetRegistrationTypeUrl, { params: { regType } });
  }

  GetRegistration(regId: string): Observable<any> {
    return this.http.get(this.GetRegistrationUrl, { params: { regId } });
  }

  CreateRegistration(model: DocumentReference): Observable<any> {
    return this.http.post(this.CreateRegistrationUrl, model);
  }

  UpdateRegistration(model: DocumentReference): Observable<any> {
    return this.http.post(this.UpdateRegistrationUrl, model);
  }

  DeleteRegistration(regId: string): Observable<any> {
    return this.http.get(this.DeleteRegistrationUrl, { params: { regId } });
  }

  GetRegistrations(regType: string): Observable<any> {
    return this.http.get(this.GetRegistrationsUrl, { params: { regType } });
  }

  GetPoolResponse(regId: any): Observable<any> {
    return this.http.get(this.GetPoolResponseUrl, { params: { regId } });
  }
}
