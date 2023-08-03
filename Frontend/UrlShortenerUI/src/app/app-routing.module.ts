import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { ShortUrlsTableComponent } from './short-urls-table/short-urls-table.component';
import { RegistrationComponent } from './registration/registration.component';
import { UrlInfoPageComponent } from './url-info-page/url-info-page.component';

const routes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'url-info/:id', component: UrlInfoPageComponent },
  { path: 'table', component: ShortUrlsTableComponent },
  { path: 'registration', component: RegistrationComponent },
  { path: '**', redirectTo: 'login', pathMatch: 'full' }, // Перенаправлення за замовчуванням
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
