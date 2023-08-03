import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { RegisterDto } from '../models/register'; // Import RegisterDto data model
import { LoginDto } from '../models/login'; // Import LoginDto data model
import { JwtAuth } from '../models/JwtAuth'; // Import JwtAuth data model

@Injectable({
  providedIn: 'root' // This service is available at the root level of the application
})
export class AuthenticationService {
  registerUrl = "account/no-auth/registration-form"; // URL for user registration
  loginUrl = "account/no-auth/login"; // URL for user login

  // Inject the HttpClient dependency
  constructor(private http: HttpClient) { }

  // Method to register a new user
  public register(user: RegisterDto): Observable<JwtAuth> {
    return this.http.post<JwtAuth>(
      // Construct the API URL for user registration
      `${environment.apiUrl}/${this.registerUrl}`,
      user
    );
  }

  // Method to log in a user
  public login(user: LoginDto): Observable<JwtAuth> {
    return this.http.post<JwtAuth>(
      // Construct the API URL for user login
      `${environment.apiUrl}/${this.loginUrl}`,
      user
    );
  }

  // Method to log out a user
  logout() {
    localStorage.removeItem('jwtToken'); // Remove JWT token from local storage
    localStorage.removeItem('userId'); // Remove user ID from local storage
  }
}