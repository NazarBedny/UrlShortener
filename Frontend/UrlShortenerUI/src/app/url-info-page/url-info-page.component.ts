import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UrlService } from '../services/UrlTableServices/UrlService.service';
import { UserService } from '../services/UserServices/UserService.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-url-info-page',
  templateUrl: './url-info-page.component.html',
  styleUrls: ['./url-info-page.component.css']
})
export class UrlInfoPageComponent implements OnInit {
  urlId: string | null = null;
  baseUrl= environment.ForShortUrl;
  urlDetails: any = {}; // Об'єкт для збереження деталей URL
  userDetails:any = {};
  constructor(private route: ActivatedRoute, private urlService: UrlService,private userService:UserService) {}

  ngOnInit(): void {
    // Отримуємо id з параметру маршруту
    this.route.paramMap.subscribe(params => {
      this.urlId = params.get('id');
      if (this.urlId) {
        // Отримуємо деталі URL за id
        this.urlService.getUrlById(this.urlId).subscribe(response => {
          this.urlDetails = response.data;
          this.userService.getUserInfo(response.data.userId).subscribe(userRes=>{
            this.userDetails = userRes.data;
          });
        });
      }
    });
  }
}