import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginDto } from '../models/login';
import { JwtAuth } from '../models/JwtAuth';
import { AuthenticationService } from '../services/authentication.service';
import { Helper } from '../services/HelperServices/Helper.sevice';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  loginDto = new LoginDto();
  jwtDto = new JwtAuth();
  errorMessage = "";

  constructor(private authService: AuthenticationService, private router: Router, private helper: Helper) { }


  login(loginDto: LoginDto) {
    this.authService.login(loginDto).subscribe(
      response => {
        if (response.success) {
          this.helper.setJwtTokenAndUserId(response.data.token, response.data.id);
          this.router.navigate(['/table']);
        } else {
          this.errorMessage = "incorrect credentials"
        }
      },
      error => {
        this.errorMessage = "incorrect credentials"
      }
    );
  }
}
