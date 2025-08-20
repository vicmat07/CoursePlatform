import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private tokenKey = 'authToken';

  constructor(private http: HttpClient) {}

  login(email: string, password: string): Observable<any> {
    return this.http.post<any>('auth/login', { email, password })
      .pipe(
        tap(response => {
          if (response && response.token) {
            localStorage.setItem(this.tokenKey, response.token);
          }
        })
      );
  }

  register(email: string, password: string): Observable<any> {
    return this.http.post<any>('auth/register', { email, password })
      .pipe(
        tap(response => {
           if (response && response.token) {
            localStorage.setItem(this.tokenKey, response.token);
          } 
        })
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
