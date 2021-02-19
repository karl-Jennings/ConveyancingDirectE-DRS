 
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class UserAccountService {

  private loginUrl = environment.apiURL + 'User/Login';

  constructor(private http: HttpClient) {

  }

  login(user: User): Observable<any> {
    return this.http.post(this.loginUrl, user);
  }
}
