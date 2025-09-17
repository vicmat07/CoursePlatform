import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, finalize, Observable, tap } from 'rxjs';
import { LoadingService } from './loading.service';
import { KeycloakService } from 'keycloak-angular';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private isLoggedInSubject = new BehaviorSubject<boolean>(false);
  private usernameSubject = new BehaviorSubject<string | null>(null);
  private rolesSubject = new BehaviorSubject<string[]>([]);

  isLoggedIn$ = this.isLoggedInSubject.asObservable();
  username$ = this.usernameSubject.asObservable();
  roles$ = this.rolesSubject.asObservable();

  constructor(
    private keycloakService: KeycloakService
  ) {
    this.loadUserData();
  }

  async loadUserData() {
    const loggedIn = await this.keycloakService.isLoggedIn();
    this.isLoggedInSubject.next(loggedIn);

    if (loggedIn) {
      const profile = await this.keycloakService.loadUserProfile();
      this.usernameSubject.next(profile.firstName || profile.username || null);

      const roles = this.keycloakService.getUserRoles();
      this.rolesSubject.next(roles);
    } else {
      this.usernameSubject.next(null);
      this.rolesSubject.next([]);
    }
  }

  login(): void {
    this.keycloakService.login();
  }

  logout(): void {
    this.keycloakService.logout();
  }

  register() {
    this.keycloakService.register();
  }
}
