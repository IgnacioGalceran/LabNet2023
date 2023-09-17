import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomersComponent } from './customers/customers.component';
import { DescriptionComponent } from './description/description.component';
import { WeatherComponent } from './weather/weather.component';
import { ContactComponent } from './contact/contact.component';
import { DashboardComponent } from './dashboard.component';
import { FormComponent } from './customers/form/form.component';

const routes: Routes = [
  { path: '', component: DashboardComponent },
  { path: 'home', component: DashboardComponent },
  { path: 'customers', component: CustomersComponent },
  { path: 'description', component: DescriptionComponent },
  { path: 'weather', component: WeatherComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'customers/form', component: FormComponent },
  { path: 'customers/form/:id', component: FormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DashboardRoutingModule { }
