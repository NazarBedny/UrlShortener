import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root' // This service is available at the root level of the application
})
export class Helper {
  // Method to set the JWT token in local storage
  setJwtToken(token: string): void {
    localStorage.setItem('jwtToken', token);
  }

  // Method to set the JWT token and user ID in local storage
  setJwtTokenAndUserId(token: string, id: string): void {
    localStorage.setItem('jwtToken', token);
    localStorage.setItem('userId', id);
  }

  // Method to retrieve the JWT token from local storage
  getJwtToken(): string | null {
    return localStorage.getItem('jwtToken');
  }

  // Method to retrieve the JWT token and user ID from local storage
  getJwtTokenAndUserId(): any | null {
    const JwtTokenAndUserId = {
      token: localStorage.getItem('jwtToken'),
      userId: localStorage.getItem('userId')
    };
    return JwtTokenAndUserId;
  }

  // Method to clear the JWT token from local storage
  clearJwtToken(): void {
    localStorage.removeItem('jwtToken');
  }
}