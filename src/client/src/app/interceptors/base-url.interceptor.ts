import { Injectable, inject } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable()
export class BaseUrlInterceptor implements HttpInterceptor {
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    let apiReq = req;

    if (!req.url.startsWith('http')) {
      apiReq = req.clone({
        url: `${environment.apiUrl}/${req.url}`
      });
    }

    return next.handle(apiReq);
  }
}

