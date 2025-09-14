import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {

  constructor(private http: HttpClient) { }

  enroll(courseId: Number): Observable<any> {
    return this.http.post<any>('api/enrollments', { courseId });
  }
}
