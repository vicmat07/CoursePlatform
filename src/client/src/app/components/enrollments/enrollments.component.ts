import { Component } from '@angular/core';
import { EnrollmentService } from '../../services/enrollment.service';

@Component({
  selector: 'app-enrollments',
  templateUrl: './enrollments.component.html',
  styleUrl: './enrollments.component.css'
})
export class EnrollmentsComponent {

  constructor(private enrollmentService: EnrollmentService) { }
}
