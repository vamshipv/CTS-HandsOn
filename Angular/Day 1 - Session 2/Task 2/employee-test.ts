import { employee } from "./employee";
import { department } from "./department";
import { skill } from "./skill";

class EmployeeTest {
    employee : employee = {
        Id : undefined,
        Name : undefined,
        Salary : undefined,
        Permanent : undefined,
        Department : undefined,
        Skills : undefined,
    };

    constructor(
    Id? : number,
    Name? : string,
    Salary? : number,
    Permanent? : boolean,
    Department? : department,
    Skills? : skill[]
    )
    {
        this.employee.Id = Id;
        this.employee.Name = Name;
        this.employee.Salary = Salary;
        this.employee.Permanent = Permanent;
        this.employee.Department = Department;
        this.employee.Skills = Skills;
    }

    display(): void {
        console.log("ID: " + this.employee.Id);
        console.log("Name: " + this.employee.Name);
        console.log("Salary: " + this.employee.Salary);
        console.log("Salary: " + this.employee.Permanent);
        console.log("Department ID: " + this.employee.Department.Id);
        console.log("Department Name: " + this.employee.Department.Name);
        let skills = this.employee.Skills;
        for (var _i = 0; _i < skills.length; _i++) {
          let skill: skill = skills[_i];
          console.log("skill[" + _i + "]:" + skill.Id + ", " + skill.Name);
        }
    }
}

let employeeTs = new EmployeeTest(147,"Vamshi P V",10000,true,
    {
        Id : 23,
        Name : "CS"
    },
    [
      {
        Id: 1,
        Name: "HTML",
      },
      {
        Id: 2,
        Name: "CSS"
      },
      {
        Id: 3,
        Name: "JavaScript"
      }
    ]
  );
  employeeTs.display();