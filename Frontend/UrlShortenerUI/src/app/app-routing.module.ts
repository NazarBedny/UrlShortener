import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component'; // Import LoginComponent
import { ShortUrlsTableComponent } from './short-urls-table/short-urls-table.component'; // Import ShortUrlsTableComponent
import { RegistrationComponent } from './registration/registration.component'; // Import RegistrationComponent
import { UrlInfoPageComponent } from './url-info-page/url-info-page.component'; // Import UrlInfoPageComponent

// Define application routes
const routes: Routes = [
  { path: 'login', component: LoginComponent }, // Route to LoginComponent
  { path: 'url-info/:id', component: UrlInfoPageComponent }, // Route to UrlInfoPageComponent with a dynamic parameter 'id'
  { path: 'table', component: ShortUrlsTableComponent }, // Route to ShortUrlsTableComponent
  { path: 'registration', component: RegistrationComponent }, // Route to RegistrationComponent
  { path: '**', redirectTo: 'table', pathMatch: 'full' }, // Redirect any unmatched route to ShortUrlsTableComponent
];

@NgModule({
  imports: [RouterModule.forRoot(routes)], // Import and configure the defined routes
  exports: [RouterModule] // Export the RouterModule for other modules to use
})
export class AppRoutingModule { }