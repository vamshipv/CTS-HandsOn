import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view-employee',
  templateUrl: './view-employee.component.html',
  styleUrls: ['./view-employee.component.css']
})
export class ViewEmployeeComponent {

  public Id: number = 1;
  public Name :string = "John";
  public Salary :number = 10000;
  public Permanent : boolean = true;
  public DepartmentId : number = 1;
  public DepartmentName : string = "PayRoll";
  public Skills:string[] = ["HTML","CSS","JAVASCRIPT"];
  public Dob : Date = new Date('09/14/2019');

}
