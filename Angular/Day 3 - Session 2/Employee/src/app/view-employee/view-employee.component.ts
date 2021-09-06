import { Component, OnInit } from '@angular/core';
import { employeeTest  } from '../../../Models/employee-test';

@Component({
  selector: 'app-view-employee',
  templateUrl: './view-employee.component.html',
  styleUrls: ['./view-employee.component.css']
})
export class ViewEmployeeComponent {

  emp = new employeeTest();
  public Id: number = 1;
  public Name :string;
  public Salary :number = 10000;
  public Permanent : boolean = true;
  public DepartmentId : number = 1;
  public DepartmentName : string = "PayRoll";
  public Skills:string[] = ["HTML","CSS","JAVASCRIPT"];
  public Dob : Date = new Date('09/14/2019');

  constructor() {
    this.Name = "John";
  }

}
