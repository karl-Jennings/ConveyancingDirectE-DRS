import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';

export class AuthInterceptor implements HttpInterceptor {
    intercept(request: HttpRequest<any>, newRequest: HttpHandler): Observable<HttpEvent<any>> {
        // add authorization header to request
        //Get Token data from local storage
        let tokenInfo = localStorage.getItem('jwtToken');
        if (tokenInfo) {
            request = request.clone({
                setHeaders: {
                    Authorization: `Bearer ${tokenInfo}`
                }
            });
        }

        return newRequest.handle(request);
    }
}