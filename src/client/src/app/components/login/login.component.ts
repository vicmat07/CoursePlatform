import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { catchError, finalize, tap, throwError } from 'rxjs';
import { KeycloakService } from 'keycloak-angular';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  username: string | null = null;
  loading = false;
  errorMessages: string[] = [];

  constructor(
    public authService: AuthService
  ) { }

  login(): void {
    this.authService.login();
  }

  logout(): void {
    this.authService.logout();
  }
}
