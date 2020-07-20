import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatIconModule } from '@angular/material/icon';
import { LoginComponent } from './components/login/login.component';
import { CustomerComponent } from './components/customer/customer.component';
import { NavMenuComponent } from './components/nav-menu/nav-menu.component';
import { ServiceLocationComponent } from './components/service-location/service-location.component';
import { ServiceProductComponent } from './components/service-product/service-product.component';
import { CustomerAddComponent } from './components/customer-add/customer-add.component';
import { ServiceProductAddComponent } from './components/service-product-add/service-product-add.component';
import { ServiceLocationAddComponent } from './components/service-location-add/service-location-add.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './components/home/home.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { CardRelationNextComponent } from './components/card-relation-next/card-relation-next.component';
import { ProfileComponent } from './components/profile/profile.component';
import { ConfigurationComponent } from './components/configuration/configuration.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    CustomerComponent,
    NavMenuComponent,
    ServiceLocationComponent,
    ServiceProductComponent,
    CustomerAddComponent,
    ServiceProductAddComponent,
    ServiceLocationAddComponent,
    HomeComponent,
    CardRelationNextComponent,
    ProfileComponent,
    ConfigurationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatIconModule,
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
