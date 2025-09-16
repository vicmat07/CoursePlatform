import { Component } from '@angular/core';
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

  loading = false;
  errorMessages: string[] = [];

  constructor(
    private keycloakService: KeycloakService, 
    private router: Router) { }

    onSubmit() {
      this.keycloakService.login();
  }
}
