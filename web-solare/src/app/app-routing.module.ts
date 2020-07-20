import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CustomerComponent } from './components/customer/customer.component';
import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { CustomerAddComponent } from './components/customer-add/customer-add.component';
import { ServiceLocationAddComponent } from './components/service-location-add/service-location-add.component';
import { ServiceLocationComponent } from './components/service-location/service-location.component';
import { ServiceProductComponent } from './components/service-product/service-product.component';
import { ServiceProductAddComponent } from './components/service-product-add/service-product-add.component';
import { ProfileComponent } from './components/profile/profile.component';
import { ConfigurationComponent } from './components/configuration/configuration.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'customer', component: CustomerComponent },
  { path: 'login', component: LoginComponent },
  { path: 'home', component: HomeComponent },
  { path: 'customer-add', component: CustomerAddComponent },
  { path: 'service-location-add', component: ServiceLocationAddComponent },
  { path: 'service-location', component: ServiceLocationComponent },
  { path: 'service-product', component: ServiceProductComponent },
  { path: 'service-product-add', component: ServiceProductAddComponent },
  { path: 'profile', component: ProfileComponent },
  { path: 'configuration', component: ConfigurationComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
