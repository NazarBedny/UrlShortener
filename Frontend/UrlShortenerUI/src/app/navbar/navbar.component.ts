import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from '../services/authentication.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {
  isLoggedIn: boolean = false; // Змінна для визначення, чи користувач ввійшов в систему

  constructor(private router: Router, private authService: AuthenticationService) {
    this.checkLoggedIn(); // Виклик функції перевірки при створенні компонента
  }

  checkLoggedIn() {
    const token = localStorage.getItem('jwtToken');
    this.isLoggedIn = token ? true : false;
  }

  logout() {
    this.authService.logout();
    localStorage.removeItem('jwtToken');
    this.router.navigate(['/login']);
  }
}