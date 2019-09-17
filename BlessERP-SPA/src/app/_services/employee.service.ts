import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../Model/Employee';



@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  // tslint:disable-next-line:no-inferrable-types
  baseUrl = 'http://localhost:5000/api/employee';

  constructor( private http: HttpClient ) {  }

  getEmployees(): Observable<Employee[]>  {
    return  this.http.get<Employee[]>(this.baseUrl);
  }

  postEmployee(model: any) {
    return this.http.post(this.baseUrl + '/SaveEmployee', model);
  }

  putEmployee(model: any) {
    return this.http.put(this.baseUrl + '/UpdateEmployee', model);
  }
}
