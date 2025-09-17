import { Component } from '@angular/core';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  errorMessages: string[] = [];

  constructor(
    private authService: AuthService,
  ) { }

  register() {
    
  }
}
