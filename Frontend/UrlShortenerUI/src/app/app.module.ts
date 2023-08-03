import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http'
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './registration/registration.component';
import { LoginComponent } from './login/login.component';
import { ShortUrlsTableComponent } from './short-urls-table/short-urls-table.component';
import { FormsModule } from '@angular/forms';
import { NavbarComponent } from './navbar/navbar.component'
import { Helper } from './services/HelperServices/Helper.sevice';
import { UrlInfoPageComponent } from './url-info-page/url-info-page.component';
@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    LoginComponent,
    ShortUrlsTableComponent,
    NavbarComponent,
    UrlInfoPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
