import { Injectable } from '@angular/core';
@Injectable({
    providedIn: 'root'
})
export class Helper {
    setJwtToken(token: string): void {
        localStorage.setItem('jwtToken', token);
    }
    setJwtTokenAndUserId(token: string, id: string): void {
        localStorage.setItem('jwtToken', token);
        localStorage.setItem('userId', id);
    }
    getJwtToken(): string | null {
        return localStorage.getItem('jwtToken');
    }
    getJwtTokenAndUserId(): any | null {
        const JwtTokenAndUserId = {
            token: localStorage.getItem('jwtToken'),
            userId: localStorage.getItem('userId')
        }
        return JwtTokenAndUserId;
    }
    clearJwtToken(): void {
        localStorage.removeItem('jwtToken');
    }

}