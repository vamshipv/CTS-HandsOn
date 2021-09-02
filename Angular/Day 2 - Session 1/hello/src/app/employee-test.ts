import { employee } from "./employee";
import { department } from "./department";
// import { skill } from "./skill";

export class employeeTest implements employee, department  {
        Id : number;
        Name : string;
        Salary : number;
        Permanent : boolean;
        Department : department;
        // Skills1 : skill;
        // Skills2 : skill;
        // Skills3 : skill;
        Dob : Date;
        skills : string[]

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
      this.skills = ["Html","Css","JavaScript"];
    }
}