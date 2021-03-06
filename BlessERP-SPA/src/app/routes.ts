// tslint:disable-next-line: quotemark
import { Routes } from "@angular/router";
import { EmployeeComponent } from './Employee/Employee.component';
import { DepartmentComponent } from './Department/Department.component';
import { TasksComponent } from './Tasks/Tasks.component';
import { NurseHandoverBookComponent } from './NurseHandoverBook/NurseHandoverBook.component';

export const appRoutes: Routes = [
  { path: 'employees', component: EmployeeComponent },
  { path: 'departments', component: DepartmentComponent },
  { path: 'tasks', component: TasksComponent },
  { path: 'nurseHandoverBook', component: NurseHandoverBookComponent }
];
