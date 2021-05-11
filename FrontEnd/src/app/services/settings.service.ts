import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { LrCredential } from '../models/lr-credential';


@Injectable({
  providedIn: 'root'
})
export class SettingsService {

  private ChangeCredentialsUrl = environment.apiURL + 'Settings/ChangeCredentials';
  private GetCredentialssUrl = environment.apiURL + 'Settings/GetCredentials';

  constructor(private http: HttpClient) {

  }

  GetCredentials(): Observable<any> {
    return this.http.get(this.GetCredentialssUrl);
  }

  ChangeCredentials(LrCredentials: LrCredential): Observable<any> {
    return this.http.post(this.ChangeCredentialsUrl, LrCredentials);
  }
}
