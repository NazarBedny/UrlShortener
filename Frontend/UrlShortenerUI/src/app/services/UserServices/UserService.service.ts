import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ResponseForUser } from 'src/app/models/responseForUser'; // Import ResponseForUser data model

@Injectable({
  providedIn: 'root' // This service is available at the root level of the application
})
export class UserService {
  URLForGetUserInfo = "user/GetAllUserInfo"; // URL for getting user information

  // Inject the HttpClient dependency
  constructor(private http: HttpClient) { }

  // Method to get user information by ID
  public getUserInfo(id: String): Observable<ResponseForUser> {
    return this.http.get<ResponseForUser>(
      // Construct the API URL with the provided user ID
      `${environment.apiUrl}/${this.URLForGetUserInfo}?id=${id}`
    );
  }
}