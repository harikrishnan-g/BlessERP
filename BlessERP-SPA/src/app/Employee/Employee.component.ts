import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../_services/employee.service';
import { Employee } from '../Model/Employee';


@Component({
  // tslint:disable-next-line:component-selector
  selector: 'app-Employee',
  templateUrl: './Employee.component.html',
  styleUrls: ['./Employee.component.css']
})

export class EmployeeComponent implements OnInit {

  employees: Employee[];
  newEmployee: Employee = new Employee();

  constructor(  private employeeService: EmployeeService ) { }

  ngOnInit() {
    this.employeeService.getEmployees()
    .subscribe((response: Employee[]) => {
        this.employees = response;
      }
    );
  }

  onSaveClick() {
    this.employeeService.postEmployee(this.newEmployee).subscribe((response) => {
      this.employees.push(this.newEmployee);
      // this.newEmployee.employeeCode = null;
      // this.newEmployee.firstName = null;
      // this.newEmployee.lastName = null;
      // this.newEmployee.department = null;
    }, (error) => {
      console.log(error);
    });
  }

}
