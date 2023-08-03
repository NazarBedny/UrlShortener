import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ResponseForUrl } from '../../models/ResponseForUrl'; // Import ResponseForUrl data model
import { Helper } from '../HelperServices/Helper.sevice'; // Import Helper service

@Injectable({
  providedIn: 'root' // This service is available at the root level of the application
})
export class UrlService {
  URLForGetAllUrl = "Url/getAllUrls";
  URLForDeleteUrl = "Url/deleteUrl";
  URLForAddNewUrl = "Url/ShortenURL";
  URLForGetUrlById = "Url/getUrlById";

  // Inject the required dependencies: HttpClient and Helper service
  constructor(private http: HttpClient, private helper: Helper) { }

  // Get JWT token and user ID from Helper service
  JwtTokenAndUserId = this.helper.getJwtTokenAndUserId();

  // Method to add a new URL
  public AddNewUrl(originalUrl: string): Observable<ResponseForUrl> {
    const data = {};
    return this.http.post<ResponseForUrl>(
      // Construct the API URL with the provided parameters
      `${environment.apiUrl}/${this.URLForAddNewUrl}?originalURL=${originalUrl}&userId=${this.JwtTokenAndUserId.userId}`,
      data
    );
  }

  // Method to get all URLs
  public getAllUrls(): Observable<ResponseForUrl> {
    return this.http.get<ResponseForUrl>(`${environment.apiUrl}/${this.URLForGetAllUrl}`);
  }

  // Method to get a URL by its ID
  public getUrlById(id: string): Observable<ResponseForUrl> {
    return this.http.get<ResponseForUrl>(`${environment.apiUrl}/${this.URLForGetUrlById}?id=${id}`);
  }

  // Method to delete a URL by its ID
  public deleteUrl(id: string): Observable<ResponseForUrl> {
    return this.http.delete<ResponseForUrl>(`${environment.apiUrl}/${this.URLForDeleteUrl}?id=${id}`);
  }
}