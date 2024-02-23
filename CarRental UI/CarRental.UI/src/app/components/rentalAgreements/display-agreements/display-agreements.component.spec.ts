import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayAgreementsComponent } from './display-agreements.component';

describe('DisplayAgreementsComponent', () => {
  let component: DisplayAgreementsComponent;
  let fixture: ComponentFixture<DisplayAgreementsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DisplayAgreementsComponent]
    });
    fixture = TestBed.createComponent(DisplayAgreementsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
