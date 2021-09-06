import { department } from "department";
import { Skills } from "./skill";

export interface employee {
    Id : number;
    Name : string;
    Salary : number;
    Permanent : boolean;
    Dob : Date;
    Department : department;
    skills:Skills[]; 
}