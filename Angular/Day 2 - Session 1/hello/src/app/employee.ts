import { department } from "./department";
// import { skill } from "./skill";

export interface employee {
    Id : number;
    Name : string;
    Salary : number;
    Permanent : boolean;
    Dob : Date;
    Department : department;
    skills:string[];
}