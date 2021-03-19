import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AttachmentService {

  private GetApplicationPollAttachedUrl = environment.apiURL + 'Attachment/GetApplicationPollAttached';


  constructor(private http: HttpClient) { }


  GetApplicationPollAttached(requestId: number): Observable<any> {
    const params = new HttpParams().set('requestId', requestId.toString());

    return this.http.get(this.GetApplicationPollAttachedUrl, {
      responseType: 'blob' as 'json', params
    });
  }


}
