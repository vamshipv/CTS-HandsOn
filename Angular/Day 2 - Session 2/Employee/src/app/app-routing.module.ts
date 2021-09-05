import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ViewEmployeeComponent } from './view-employee/view-employee.component';
import { EditEmployeeComponent } from './edit-employee/edit-employee.component';
import { QuantityIncrementComponent } from './quantity-increment/quantity-increment.component';

// paths
const routes: Routes = [{path:"", component:ViewEmployeeComponent},
{path:"EditEmployee", component:EditEmployeeComponent},
{path:"QuantityIncrement",component:QuantityIncrementComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
