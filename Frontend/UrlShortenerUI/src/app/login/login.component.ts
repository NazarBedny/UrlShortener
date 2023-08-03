// Import necessary modules and components from Angular
import { Component } from '@angular/core';
import { Router } from '@angular/router';

// Import data models and services
import { LoginDto } from '../models/login'; // Import LoginDto data model
import { JwtAuth } from '../models/JwtAuth'; // Import JwtAuth data model
import { AuthenticationService } from '../services/authentication.service'; // Import authentication service
import { Helper } from '../services/HelperServices/Helper.sevice'; // Import helper service

// Component decorator
@Component({
  selector: 'app-login', // Component selector
  templateUrl: './login.component.html', // Component HTML template
  styleUrls: ['./login.component.css'] // Component CSS styles
})
export class LoginComponent {
  // Initialize variables
  loginDto = new LoginDto(); // Create an instance of LoginDto
  jwtDto = new JwtAuth(); // Create an instance of JwtAuth
  errorMessage = ""; // Initialize error message variable

  // Component constructor
  constructor(private authService: AuthenticationService, private router: Router, private helper: Helper) { }

  // Method to handle user login
  login(loginDto: LoginDto) {
    this.authService.login(loginDto).subscribe(
      response => {
        if (response.success) {
          // If login is successful, set JWT token and user ID using helper service
          this.helper.setJwtTokenAndUserId(response.data.token, response.data.id);
          // Navigate to the 'table' route
          this.router.navigate(['/table']);
        } else {
          // If login is not successful, display error message
          this.errorMessage = "incorrect credentials"
        }
      },
      error => {
        // If an error occurs during login, display error message
        this.errorMessage = "incorrect credentials"
      }
    );
  }
}
