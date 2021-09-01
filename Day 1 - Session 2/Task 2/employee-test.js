"use strict";
exports.__esModule = true;
var EmployeeTest = /** @class */ (function () {
    function EmployeeTest(Id, Name, Salary, Permanent, Department, Skills) {
        this.employee = {
            Id: undefined,
            Name: undefined,
            Salary: undefined,
            Permanent: undefined,
            Department: undefined,
            Skills: undefined
        };
        this.employee.Id = Id;
        this.employee.Name = Name;
        this.employee.Salary = Salary;
        this.employee.Permanent = Permanent;
        this.employee.Department = Department;
        this.employee.Skills = Skills;
    }
    EmployeeTest.prototype.display = function () {
        console.log("ID: " + this.employee.Id);
        console.log("Name: " + this.employee.Name);
        console.log("Salary: " + this.employee.Salary);
        console.log("Salary: " + this.employee.Permanent);
        console.log("Department ID: " + this.employee.Department.Id);
        console.log("Department Name: " + this.employee.Department.Name);
        var skills = this.employee.Skills;
        for (var _i = 0; _i < skills.length; _i++) {
            var skill = skills[_i];
            console.log("skill[" + _i + "]:" + skill.Id + ", " + skill.Name);
        }
    };
    return EmployeeTest;
}());
var employeeTs = new EmployeeTest(147, "Vamshi P V", 10000, true, {
    Id: 23,
    Name: "CS"
}, [
    {
        Id: 1,
        Name: "HTML"
    },
    {
        Id: 2,
        Name: "CSS"
    },
    {
        Id: 3,
        Name: "JavaScript"
    }
]);
employeeTs.display();
