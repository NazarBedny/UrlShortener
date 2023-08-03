import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ResponseForUser } from 'src/app/models/responseForUser';


@Injectable({
    providedIn: 'root'
})
export class UserService {
    URLForGetUserInfo = "user/GetAllUserInfo";

    constructor(private http: HttpClient) { }

    public getUserInfo(id: String): Observable<ResponseForUser> {
        return this.http.get<ResponseForUser>(`${environment.apiUrl}/${this.URLForGetUserInfo}?id=${id}`);
    }
}
