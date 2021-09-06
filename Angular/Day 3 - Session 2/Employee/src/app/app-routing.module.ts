import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewEmployeeComponent } from './view-employee/view-employee.component';
import { EditEmployeeComponent } from './edit-employee/edit-employee.component';
import { QuantityIncrementComponent } from './quantity-increment/quantity-increment.component';
import { EditEmployeeTDFComponent } from './edit-employee-tdf/edit-employee-tdf.component';
import { EditEmployeeReactiveComponent } from './edit-employee-reactive/edit-employee-reactive.component';

// paths
const routes: Routes = [{path:"", component:ViewEmployeeComponent},
{path:"EditEmployee", component:EditEmployeeComponent},
{path:"QuantityIncrement",component:QuantityIncrementComponent},
{path:"EditEmployeeTDF",component:EditEmployeeTDFComponent},
{path: "EditEmployeeReactive", component: EditEmployeeReactiveComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
