import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UrlService } from '../services/UrlTableServices/UrlService.service';
import { Helper } from '../services/HelperServices/Helper.sevice';
import { environment } from 'src/environments/environment';
import { UserService } from '../services/UserServices/UserService.service';
import { firstValueFrom } from 'rxjs';



@Component({
  selector: 'app-short-urls-table',
  templateUrl: './short-urls-table.component.html',
  styleUrls: ['./short-urls-table.component.css']
})
export class ShortUrlsTableComponent implements OnInit {
  allUrls: any;
  baseUrl = environment.ForShortUrl;
  newUrl: string = '';
  errorMessage: string = '';

  isAdmin: boolean = false;
  isLoggedIn: boolean = false;

  constructor(
    private router: Router,
    private urlService: UrlService,
    private helper: Helper,
    private userService: UserService,
    private cdRef: ChangeDetectorRef
  ) { }

  async ngOnInit() {
    this.isLoggedIn = this.checkLoggedIn();
    if (this.isLoggedIn) {
      const adminStatus = await this.checkAdminStatus();
      this.isAdmin = adminStatus.isAdmin;
      this.errorMessage = adminStatus.errorMessage;
    }
    this.loadUrls();
  }

  checkLoggedIn(): boolean {
    const token = localStorage.getItem('jwtToken');
    return token ? true : false;
  }

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

  loadUrls() {
    this.urlService.getAllUrls().subscribe(response => {
      this.allUrls = response.data;
      this.cdRef.detectChanges();
    });

  }

  deleteUrl(id: string) {
    this.checkLoggedIn();
    this.urlService.deleteUrl(id).subscribe();
    this.cdRef.detectChanges();
  }

  addNewUrl(originalUrl: string) {
    this.checkLoggedIn();
    this.urlService.AddNewUrl(originalUrl).subscribe(response => {
      this.urlService.getAllUrls();
      this.cdRef.detectChanges();
    });
  }

  isCurrentUser(createdBy: string): boolean {
    const userData = this.helper.getJwtTokenAndUserId();
    if (createdBy == userData.userId) {
      return true
    }
    else {
      return false;
    }

  }
}