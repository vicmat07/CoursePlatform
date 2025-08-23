import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { finalize, Observable, tap } from 'rxjs';
import { LoadingService } from './loading.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private tokenKey = 'authToken';

  constructor(
    private http: HttpClient,
    private loadingService: LoadingService
  ) {}

  login(email: string, password: string): Observable<any> {
    this.loadingService.show();
    return this.http.post<any>('auth/login', { email, password })
      .pipe(
        tap(response => {
          if (response && response.token) {
            localStorage.setItem(this.tokenKey, response.token);
          }
        }),
        finalize(() => this.loadingService.hide())
      );
  }

  register(email: string, password: string): Observable<any> {
    this.loadingService.show();
    return this.http.post<any>('auth/register', { email, password })
      .pipe(
        tap(response => {
           if (response && response.token) {
            localStorage.setItem(this.tokenKey, response.token);
          } 
        }),
        finalize(() => this.loadingService.hide())
      )
  }

  logout(): void {
    localStorage.removeItem(this.tokenKey);
  }

  getToken(): string | null {
    return localStorage.getItem(this.tokenKey);
  }

  isLoggedIn(): boolean {
    return !!this.getToken();
  }
}
