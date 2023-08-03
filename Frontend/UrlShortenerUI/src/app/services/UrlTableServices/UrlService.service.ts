import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ResponseForUrl } from '../../models/ResponseForUrl';
import { Helper } from '../HelperServices/Helper.sevice';


@Injectable({
  providedIn: 'root'
})
export class UrlService {
  URLForGetAllUrl = "Url/getAllUrls";
  URLForDeleteUrl = "Url/deleteUrl";
  URLForAddNewUrl = "Url/ShortenURL";
  URLForGetUrlById = "Url/getUrlById";
  constructor(private http: HttpClient, private helper: Helper) { }
  JwtTokenAndUserId = this.helper.getJwtTokenAndUserId();
  public AddNewUrl(originalUrl: string): Observable<ResponseForUrl> {
    const data = {};
    return this.http.post<ResponseForUrl>(
      `${environment.apiUrl}/${this.URLForAddNewUrl}?originalURL=${originalUrl}&userId=${this.JwtTokenAndUserId.userId}`,
      data
    );
  }
  public getAllUrls(): Observable<ResponseForUrl> {
    return this.http.get<ResponseForUrl>(`${environment.apiUrl}/${this.URLForGetAllUrl}`);
  }
  public getUrlById(id: string): Observable<ResponseForUrl> {
    return this.http.get<ResponseForUrl>(`${environment.apiUrl}/${this.URLForGetUrlById}?id=${id}`);
  }
  public deleteUrl(id: string): Observable<ResponseForUrl> {
    return this.http.delete<ResponseForUrl>(`${environment.apiUrl}/${this.URLForDeleteUrl}?id=${id}`);
  }

}
