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


  constructor(private authService:AuthenticationService) {}


  login(registerDto: RegisterDto){
    this.authService.login(registerDto).subscribe();
  }
} 