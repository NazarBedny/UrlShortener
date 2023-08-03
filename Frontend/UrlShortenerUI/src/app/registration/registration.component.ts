import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtAuth } from '../models/JwtAuth';
import { AuthenticationService } from '../services/authentication.service';
import { RegisterDto } from '../models/register';


@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
  registerDto = new RegisterDto();
  jwtDto = new JwtAuth();

// constructor(private router: Router) {
  //   const token = localStorage.getItem('jwtToken');
  //   if (!token) {
  //     this.router.navigate(['/login']); // Редірект на логін сторінку
  //   } else {
  //     this.router.navigate(['/login']); // Редірект на сторінку з таблицею
  //   }
  // }
  constructor(private authService:AuthenticationService,private router: Router) {}


  registration(registerDto: RegisterDto){
    const response = this.authService.register(registerDto).subscribe();
    if (response) {
      this.router.navigate(['/login']); // Редірект на логін сторінку
    }
  }
} 