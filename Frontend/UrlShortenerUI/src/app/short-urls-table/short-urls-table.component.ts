import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-short-urls-table',
  templateUrl: './short-urls-table.component.html',
  styleUrls: ['./short-urls-table.component.css']
})
export class ShortUrlsTableComponent implements OnInit {
  urls: any[] = []; // Приклад даних для таблички, ви можете змінити на свої

  newUrl: string = '';
  errorMessage: string = '';

  // Приклад, чи користувач є авторизованим та адміністратором
  isAuthorized: boolean = true;
  isAdmin: boolean = true;

  constructor() {}

  ngOnInit() {}

  viewUrlInfo(id: number) {
    // Додайте тут логіку для переходу на сторінку з деталями про URL по ID
  }

  deleteUrl(id: number) {
    // Додайте тут логіку для видалення URL за ID
  }

  addNewUrl() {
    // Додайте тут логіку для додавання нового URL
  }

  isCurrentUser(createdBy: string): boolean {
    // Додайте логіку для перевірки, чи поточний користувач є автором URL
    return false;
  }
}