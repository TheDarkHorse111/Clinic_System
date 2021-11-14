import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { ManagersComponent } from './managers/managers.component';
import { CustomersComponent } from './customers/customers.component';


@NgModule({
  declarations: [
    DashboardComponent,
    ManagersComponent,
    CustomersComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule
  ]
})
export class AdminModule { }
