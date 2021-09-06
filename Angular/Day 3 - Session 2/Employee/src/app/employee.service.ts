import { Injectable } from '@angular/core';
import { employee } from 'Models/employee';

@Injectable({
  providedIn: 'root'
})

export class EmployeeService 
{
  //Creating a list of Employees.
  employeeList:employee[]=
  [
    {
      Id:1,
      Name:"John",
      Salary:10000,
      Permanent:true,
      Department:{Id:1,Name:"PayRoll"},
      skills:[{Id:1,Name:"HTML"},{Id:2,Name:"CSS"},{Id:3,Name:"JavaScript"}],
      Dob:new Date("2000-07-15")
    }
  ];

  constructor() { }
  
  //Creating an empty employee object.
  empty_emp:any={};

  //Get all employees.
  getAllEmployees():employee[]
  {
    return this.employeeList;
  }

  //Get employee by id.
  getEmployee(employeeId:number):employee
  {
    this.employeeList.forEach(item => {
      if(item.Id==employeeId)
      this.empty_emp=item;  
    });
    
    return this.empty_emp;
  }

}