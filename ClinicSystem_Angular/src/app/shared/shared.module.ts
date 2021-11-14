import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedRoutingModule } from './shared-routing.module';
import { SharedComponentComponent } from './shared-component/shared-component.component';
import { ClinicComponent } from './clinic/clinic.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { ReservationComponent } from './reservation/reservation.component';


@NgModule({
  declarations: [
    SharedComponentComponent,
    ClinicComponent,
    HeaderComponent,
    FooterComponent,
    ReservationComponent
  ],
  imports: [
    CommonModule,
    SharedRoutingModule
  ]
})
export class SharedModule { }
