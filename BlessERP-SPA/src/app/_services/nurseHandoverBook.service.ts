import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { NurseHandoverBook } from '../Model/NurseHandoverBook';

@Injectable({
  providedIn: 'root'
})
export class NurseHandoverBookService {
  baseUrl = 'http://localhost:5000/api/nursing';

  constructor(private http: HttpClient) {}
  getNurseHandoverBook(): Observable<NurseHandoverBook[]> {
    return this.http.get<NurseHandoverBook[]>(this.baseUrl);
  }

  postNurseHandoverBook(model: any) {
    return this.http.post(this.baseUrl + '/SaveNursingHandoverBook', model);
  }

  putNurseHandoverBook(model: any) {
    return this.http.put(this.baseUrl + '/UpdateNursingHandoverBook', model);
  }
}
