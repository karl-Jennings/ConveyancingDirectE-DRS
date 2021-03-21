import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AttachmentService {

  private GetAttachmentUrl = environment.apiURL + 'Attachment/GetAttachment';


  constructor(private http: HttpClient) { }


  GetAttachment(requestId: number): Observable<any> {
    const params = new HttpParams().set('requestId', requestId.toString());

    return this.http.get(this.GetAttachmentUrl, {
      responseType: 'blob' as 'json', params
    });
  }


}
