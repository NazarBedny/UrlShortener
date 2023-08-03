import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UrlInfoPageComponent } from './url-info-page.component';

describe('UrlInfoPageComponent', () => {
  let component: UrlInfoPageComponent;
  let fixture: ComponentFixture<UrlInfoPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UrlInfoPageComponent]
    });
    fixture = TestBed.createComponent(UrlInfoPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
