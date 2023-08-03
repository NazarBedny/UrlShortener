import { Component } from '@angular/core';
import { Router } from '@angular/router';



@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  // constructor(private router: Router) {
  //   const token = localStorage.getItem('jwtToken');
  //   if (!token) {
  //     this.router.navigate(['/login']); // Редірект на логін сторінку
  //   } else {
  //     this.router.navigate(['/login']); // Редірект на сторінку з таблицею
  //   }
  // }
}
