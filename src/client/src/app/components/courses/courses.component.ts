import { Component, OnInit } from '@angular/core';
import { CourseService } from '../../services/course.service';
import { Observable } from 'rxjs';
import { Course } from '../../models/course.model';
import { EnrollmentService } from '../../services/enrollment.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrl: './courses.component.css'
})
export class CoursesComponent {
  
  courses$: Observable<Array<Course>>;

  constructor(
    private courseServices: CourseService,
    private enrollmentService: EnrollmentService) {
    this.courses$ = this.courseServices.getCourses();
   }
  
   enrollCourse(courseId: number) {
    this.enrollmentService.enroll(courseId)
   }

}
