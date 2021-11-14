import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './managers/dashboard/dashboard.component';
import { VacationsComponent } from './managers/vacations/vacations.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    VacationsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
