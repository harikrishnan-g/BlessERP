import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tasks } from '../Model/Tasks';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  baseUrl = 'http://localhost:5000/api/task';
  constructor(private http: HttpClient) {}

  getTasks(): Observable<Tasks[]> {
    return this.http.get<Tasks[]>(this.baseUrl);
  }

  postTasks(model: any) {
    return this.http.post(this.baseUrl + '/SaveTasks', model);
  }

  putTasks(model: any) {
    return this.http.put(this.baseUrl + '/UpdateTasks', model);
  }
}
