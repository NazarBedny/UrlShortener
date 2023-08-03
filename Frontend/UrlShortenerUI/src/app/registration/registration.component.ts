// Import necessary modules and components from Angular
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtAuth } from '../models/JwtAuth'; // Import JwtAuth data model
import { AuthenticationService } from '../services/authentication.service'; // Import authentication service
import { RegisterDto } from '../models/register'; // Import RegisterDto data model

// Component decorator
@Component({
  selector: 'app-registration', // Component selector
  templateUrl: './registration.component.html', // Component HTML template
  styleUrls: ['./registration.component.css'] // Component CSS styles
})
export class RegistrationComponent {
  registerDto = new RegisterDto(); // Create an instance of RegisterDto
  jwtDto = new JwtAuth(); // Create an instance of JwtAuth

  // Component constructor
  constructor(private authService: AuthenticationService, private router: Router) { }

  // Method to handle user registration
  registration(registerDto: RegisterDto) {
    // Call the register method from the authentication service and subscribe to the response
    const response = this.authService.register(registerDto).subscribe();

    // Check if the response is truthy (successful registration)
    if (response) {
      this.router.navigate(['/login']); // Navigate the user to the 'login' route
    }
  }
}