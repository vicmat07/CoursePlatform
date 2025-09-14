import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { catchError, tap, throwError } from 'rxjs';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {
  registerForm: FormGroup;
  errorMessages: string[] = [];

  constructor(
    private fb: FormBuilder,
    private authService: AuthService,
    private router: Router
  ) {
    this.registerForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmPassword: ['', Validators.required]
    });
  }

  get f() {
    return this.registerForm.controls;
  }

  onSubmit() {
    this.errorMessages = [];

    if (this.registerForm.invalid) return;

    const { email, password, confirmPassword } = this.registerForm.value;

    if (password !== confirmPassword) {
      this.errorMessages = ['Passwords dont match.'];
      return;
    }

    this.authService.register(email, password)
      .pipe(
        tap(() => this.router.navigate(['/login'])),
        catchError(err => {
          if (err.error && Array.isArray(err.error)) {
          this.errorMessages = err.error.map((e: any) => e.description);
        } else {
          this.errorMessages = ['Error registering user'];
        }
        return throwError(() => err);
        })
      )
      .subscribe();
  }
}
