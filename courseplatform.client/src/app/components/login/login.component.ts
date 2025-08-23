import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { catchError, finalize, tap, throwError } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  loginForm: FormGroup;
  loading = false;
  errorMessages: string[] = [];

  constructor(
    private fb: FormBuilder,
    private authService: AuthService, 
    private router: Router) { 
      this.loginForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required]]
    });
    }

    get f() {
      return this.loginForm.controls;
    }

    onSubmit() {
    if (this.loginForm.invalid) {
      return;
    }

    this.loading = true;
    this.errorMessages = [];

    const { email, password } = this.loginForm.value;

    this.authService.login(email, password)
      .pipe(
        tap(() => this.router.navigate(['dashboard'])),
        catchError(err => {
          if (err.status === 401){
            this.errorMessages = ['Invalid credentials']
          }
          return throwError(() => err)
        })
      )
      .subscribe()
  }
}
