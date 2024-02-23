import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor
} from '@angular/common/http';
import { Observable, tap } from 'rxjs';
import { Router } from '@angular/router';

@Injectable()
export class AuthinterceptorInterceptor implements HttpInterceptor {

  constructor(private router: Router) {}

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
      if (localStorage.getItem('token') != null) {
          const clonedReq = req.clone({
              headers: req.headers.set('Authorization', 'Bearer ' + localStorage.getItem('token'))
          });
          return next.handle(clonedReq).pipe(
              tap(
                  succ => { },
                  err => {
                      if (err.status == 401){
                          localStorage.removeItem('token');
                          this.router.navigateByUrl('/user/login');
                      }
                      else if(err.status == 403)
                      this.router.navigateByUrl('/forbidden');
                  }
              )
          )
      }
      else
          return next.handle(req.clone());
  }
}
