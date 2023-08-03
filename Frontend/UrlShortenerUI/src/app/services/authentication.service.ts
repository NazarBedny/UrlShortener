import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginDto } from '../models/login';
import { RegisterDto } from '../models/register'
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { JwtAuth } from '../models/JwtAuth';



@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  registerUrl = "account/no-auth/registration-form";
  loginUrl = "account/no-auth/login";
  constructor(private http:HttpClient ) { }


  public register(user: RegisterDto):Observable<JwtAuth>{
    return this.http.post<JwtAuth>(`${environment.apiUrl}/${this.registerUrl}`,user);
  }
  public login(user: LoginDto):Observable<JwtAuth>{
    return this.http.post<JwtAuth>(`${environment.apiUrl}/${this.loginUrl}`,user);
  }
  logout() {
    localStorage.removeItem('jwtToken');
    localStorage.removeItem('userId');
  }
  
}
