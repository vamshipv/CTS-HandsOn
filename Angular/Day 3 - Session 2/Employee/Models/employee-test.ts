import { employee } from "./employee";
import { department } from "department";
import { Skills } from "./skill";
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class employeeTest implements employee, department,Skills  {
      Id : number;
      Name : string;
      Salary : number;
      Permanent : boolean;
      Department : department;
      Dob : Date;
      skills:Skills[];

    constructor () 
    {
      this.Id = 3;
      this.Name = "John";
      this.Salary = 10000;
      this.Permanent = true;
      this.Dob = new Date('04/21/2019');
      this.Department = {
        Id : 1,
        Name : "Payroll"
      }
      // [{}] correct format for list
      this.skills = [{Id:1,Name:"HTML"},{Id:2,Name:"CSS"},{Id:3,Name:"JavaScript"}];
    }
}