import { Component, OnInit } from '@angular/core';
import { employeeTest } from '../view-employee/employee-test';
import { department } from '../view-employee/department';

@Component({
  selector: 'app-edit-employee-tdf',
  templateUrl: './edit-employee-tdf.component.html',
  styleUrls: ['./edit-employee-tdf.component.css']
})
export class EditEmployeeTDFComponent {
  
  emp = new employeeTest();

  Departments: department[] = [
    {Id: 1, Name:"Payroll"},
    {Id: 2, Name:"Internal"},
    {Id: 3, Name:"HR"}
  ]

  onSubmit():void
  {
    console.log(this.emp);
  }
}
