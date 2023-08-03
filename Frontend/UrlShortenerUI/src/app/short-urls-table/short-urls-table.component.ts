import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UrlService } from '../services/UrlTableServices/UrlService.service'; // Import UrlService
import { Helper } from '../services/HelperServices/Helper.sevice'; // Import Helper service
import { environment } from 'src/environments/environment';
import { UserService } from '../services/UserServices/UserService.service'; // Import UserService
import { firstValueFrom } from 'rxjs';

@Component({
  selector: 'app-short-urls-table',
  templateUrl: './short-urls-table.component.html',
  styleUrls: ['./short-urls-table.component.css']
})
export class ShortUrlsTableComponent implements OnInit {
  allUrls: any; // Array to store all URLs
  baseUrl = environment.ForShortUrl; // Base URL for short URLs
  newUrl: string = ''; // Variable to store a new URL
  errorMessage: string = ''; // Error message variable

  isAdmin: boolean = false; // Flag to track admin status
  isLoggedIn: boolean = false; // Flag to track user's login status

  // Constructor with injected dependencies
  constructor(
    private router: Router,
    private urlService: UrlService,
    private helper: Helper,
    private userService: UserService,
    private cdRef: ChangeDetectorRef
  ) { }

  // Initialize component
  async ngOnInit() {
    this.isLoggedIn = this.checkLoggedIn(); // Check user's login status
    if (this.isLoggedIn) {
      const adminStatus = await this.checkAdminStatus(); // Check user's admin status
      this.isAdmin = adminStatus.isAdmin;
      this.errorMessage = adminStatus.errorMessage;
    }
    this.loadUrls(); // Load all URLs
  }

  // Method to check if user is logged in
  checkLoggedIn(): boolean {
    const token = localStorage.getItem('jwtToken');
    return token ? true : false;
  }

  // Method to check user's admin status
  async checkAdminStatus(): Promise<{ isAdmin: boolean; errorMessage: string }> {
    try {
      const userMetaData = this.helper.getJwtTokenAndUserId();
      const res = await firstValueFrom(this.userService.getUserInfo(userMetaData.userId));

      if (res.data.roleId.toUpperCase() === 'ABA6E585-7CEF-4EFA-80BE-6338DED67BAF') {
        return { isAdmin: true, errorMessage: '' };
      } else {
        return { isAdmin: false, errorMessage: '' };
      }
    } catch (error) {
      return { isAdmin: false, errorMessage: 'Error checking admin status' };
    }
  }

  // Method to load all URLs
  loadUrls() {
    this.urlService.getAllUrls().subscribe(response => {
      this.allUrls = response.data;
      this.cdRef.detectChanges(); // Trigger change detection
    });
  }

  // Method to delete a URL by its ID
  deleteUrl(id: string) {
    this.checkLoggedIn();
    this.urlService.deleteUrl(id).subscribe();
    this.cdRef.detectChanges(); // Trigger change detection
  }

  // Method to add a new URL
  addNewUrl(originalUrl: string) {
    this.checkLoggedIn();
    this.urlService.AddNewUrl(originalUrl).subscribe(response => {
      this.urlService.getAllUrls(); // Refresh URL list
      this.cdRef.detectChanges(); // Trigger change detection
    });
  }

  // Method to check if the current user is the creator of a URL
  isCurrentUser(createdBy: string): boolean {
    const userData = this.helper.getJwtTokenAndUserId();
    if (createdBy == userData.userId) {
      return true;
    } else {
      return false;
    }
  }
}