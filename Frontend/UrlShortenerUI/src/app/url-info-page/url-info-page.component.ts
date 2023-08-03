import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UrlService } from '../services/UrlTableServices/UrlService.service'; // Import UrlService
import { UserService } from '../services/UserServices/UserService.service'; // Import UserService
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-url-info-page',
  templateUrl: './url-info-page.component.html',
  styleUrls: ['./url-info-page.component.css']
})
export class UrlInfoPageComponent implements OnInit {
  urlId: string | null = null; // Initialize URL ID variable
  baseUrl = environment.ForShortUrl; // Base URL for short URLs
  urlDetails: any = {}; // Initialize object to store URL details
  userDetails: any = {}; // Initialize object to store user details

  // Constructor with injected dependencies
  constructor(private route: ActivatedRoute, private urlService: UrlService, private userService: UserService) { }

  // Initialize component
  ngOnInit(): void {
    // Subscribe to route parameter changes
    this.route.paramMap.subscribe(params => {
      this.urlId = params.get('id'); // Get URL ID from route parameter
      if (this.urlId) {
        // Fetch URL details by ID
        this.urlService.getUrlById(this.urlId).subscribe(response => {
          this.urlDetails = response.data; // Store fetched URL details
          // Fetch user details using user ID from URL details
          this.userService.getUserInfo(response.data.userId).subscribe(userRes => {
            this.userDetails = userRes.data; // Store fetched user details
          });
        });
      }
    });
  }
}