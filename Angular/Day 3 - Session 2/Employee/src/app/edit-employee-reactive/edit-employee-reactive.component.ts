import { Component, OnInit } from '@angular/core';
import { Skills } from 'Models/skill';
import { department } from 'Models/department';
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-edit-employee-reactive',
  templateUrl: './edit-employee-reactive.component.html',
  styleUrls: ['./edit-employee-reactive.component.css']
})
export class EditEmployeeReactiveComponent implements OnInit {

    Department : department[] = [];
    skills:Skills[] =[];
    emp:any={};
    editEmp: FormGroup;

    constructor(public fb:FormBuilder,private route:ActivatedRoute,private obj:EmployeeService) { 

    const employeeId = Number(this.route.snapshot.paramMap.get('Id'));


    this.emp = this.obj.getEmployee(employeeId);

    this.editEmp = this.fb.group(
      {
        Name:[this.emp.Name,[Validators.required,Validators.minLength(4),Validators.maxLength(20)]],
        Salary:[this.emp.Salary,[Validators.required,Validators.min(5000),Validators.max(50000)]],
        Permanent:[this.emp.Permanent,[Validators.required]],
        Department:[this.emp.departments,[Validators.required]],
        Skills:new FormArray([],[Validators.required])
      }
    );
    this.skills = [{Id:1,Name:"HTML"},{Id:2,Name:"CSS"},{Id:3,Name:"JavaScript"}];
    this.Department = [
      {Id:1,Name:"PayRoll"},
      {Id:2,Name:"Internal"},
      {Id:3,Name:"HR"}
    ];
  }

  ngOnInit(): void {

  }

  get aliases() 
  {
    return this.editEmp.get('aliases') as FormArray;
  }

  addAlias()
  {
    this.aliases.push(this.fb.control(''));
  }

  onSubmit()
  {
    console.warn(this.editEmp.value);
  }

  onCheckBoxChange(e:any):void
  {
    const temp= <FormArray> this.editEmp.get('Skills');

    if(e.target.checked)
    temp.push(new FormControl(e.target.value));
    else
    {
      let i:number=0;
      
      temp.controls.forEach((item)=>{
        if(item.value==e.target.value)
        {
          temp.removeAt(i);
          return;
        }
        i++;
      });
    }
  }
}
