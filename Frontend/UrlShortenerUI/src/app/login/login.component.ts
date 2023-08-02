import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginDto } from '../models/login';
import { JwtAuth } from '../models/JwtAuth';
import { AuthenticationService } from '../services/authentication.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginDto = new LoginDto();
  jwtDto = new JwtAuth();


  constructor(private authService:AuthenticationService) {}


  login(loginDto: LoginDto){
    this.authService.login(loginDto).subscribe((jwtDto)=>{
      localStorage.setItem('jwtToken',jwtDto.token)
    });
  }
} 