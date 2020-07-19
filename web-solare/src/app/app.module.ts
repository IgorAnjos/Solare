import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatIconModule } from '@angular/material/icon';
import { LoginComponent } from './components/login/login.component';
import { CustomerComponent } from './components/customer/customer.component';
import { ScheduleComponent } from './components/schedule/schedule.component';
import { RelationComponent } from './components/relation/relation.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { ServiceLocationComponent } from './components/service-location/service-location.component';
import { ServiceProductComponent } from './components/service-product/service-product.component';
import { CustomerAddComponent } from './components/customer-add/customer-add.component';
import { ServiceProductAddComponent } from './components/service-product-add/service-product-add.component';
import { ServiceLocationAddComponent } from './components/service-location-add/service-location-add.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './components/home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    CustomerComponent,
    ScheduleComponent,
    RelationComponent,
    NavMenuComponent,
    ServiceLocationComponent,
    ServiceProductComponent,
    CustomerAddComponent,
    ServiceProductAddComponent,
    ServiceLocationAddComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatIconModule,
    BsDropdownModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
