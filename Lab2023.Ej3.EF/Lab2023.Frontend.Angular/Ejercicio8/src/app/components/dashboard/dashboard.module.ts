import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DashboardRoutingModule } from './dashboard-routing.module';
import { HomeComponent } from './home/home.component';
import { SharedModule } from '../shared/shared.module';
import { CustomersComponent } from './customers/customers.component';
import { WeatherComponent } from './weather/weather.component';
import { ContactComponent } from './contact/contact.component';
import { DescriptionComponent } from './description/description.component';
import { FormComponent } from './customers/form/form.component';


@NgModule({
  declarations: [
    HomeComponent,
    CustomersComponent,
    WeatherComponent,
    ContactComponent,
    DescriptionComponent,
    FormComponent
  ],
  imports: [
    CommonModule,
    DashboardRoutingModule,
    SharedModule
  ]
})
export class DashboardModule { }
