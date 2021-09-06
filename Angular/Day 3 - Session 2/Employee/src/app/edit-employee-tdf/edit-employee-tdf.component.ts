import { Component, OnInit } from '@angular/core';
import { employeeTest } from '../../../Models/employee-test';
import { department } from 'Models/department';
import { Skills } from 'Models/skill';

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

  skills = [{Id:1,Name:"HTML"},{Id:2,Name:"CSS"},{Id:3,Name:"JavaScript"}];
  
  onSubmit():void
  {
    console.log(this.emp);
  }
}
