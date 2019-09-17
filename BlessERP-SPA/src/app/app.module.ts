import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AlertPromise } from 'selenium-webdriver';
import { AlertifyService } from './_services/alertify.service';
import { DepartmentComponent } from './Department/Department.component';
import { EmployeeComponent } from './Employee/Employee.component';
import { EmployeeService } from './_services/employee.service';
import { RouterModule } from '@angular/router';
import { appRoutes } from './routes';
import { TasksComponent } from './Tasks/Tasks.component';

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      DepartmentComponent,
      EmployeeComponent,
      TasksComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      HttpClientModule,
      FormsModule,
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      AlertifyService,
      EmployeeService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
