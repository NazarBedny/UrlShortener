// Import necessary modules and components from Angular
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service'; // Import authentication service

// Component decorator
@Component({
  selector: 'app-navbar', // Component selector
  templateUrl: './navbar.component.html', // Component HTML template
  styleUrls: ['./navbar.component.css'] // Component CSS styles
})
export class NavbarComponent {
  isLoggedIn: boolean = false; // Flag to track user's login status

  // Component constructor
  constructor(private router: Router, private authService: AuthenticationService) {
    this.checkLoggedIn(); // Call the method to check if the user is logged in
  }

  // Method to check if the user is logged in
  checkLoggedIn() {
    const token = localStorage.getItem('jwtToken'); // Retrieve JWT token from local storage
    this.isLoggedIn = token ? true : false; // Update isLoggedIn based on the presence of the token
  }

  // Method to handle user logout
  logout() {
    this.authService.logout(); // Call the logout method from the authentication service
    localStorage.removeItem('jwtToken'); // Remove JWT token from local storage
    this.router.navigate(['/login']); // Navigate the user to the 'login' route
  }
}