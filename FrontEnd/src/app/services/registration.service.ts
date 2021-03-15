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
  private CollectAttachmentResultUrl = environment.apiURL + 'Registration/GetOutStandingPollRequest';
  private GetRequisitionUrl = environment.apiURL + 'Registration/GetRequisition';
  private GetFinalResultUrl = environment.apiURL + 'Registration/GetFinalResult';

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

  GetPoolResponse(docRefId: any): Observable<any> {
    return this.http.get(this.GetPoolResponseUrl, { params: { docRefId } });
  }

  CollectAttachmentResult(docRefId: any, serviceId: string): Observable<any> {
    return this.http.get(this.CollectAttachmentResultUrl, { params: { docRefId, serviceId } });
  }

  GetRequisition(docRefId: any, serviceId: string): Observable<any> {
    return this.http.get(this.GetRequisitionUrl, { params: { docRefId, serviceId } });
  }

  CollectFinalResults(docRefId: any, serviceId: string): Observable<any> {
    return this.http.get(this.GetFinalResultUrl, { params: { docRefId, serviceId } });
  }


}
