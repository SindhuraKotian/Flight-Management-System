import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayPassengersComponent } from './display-passengers.component';

describe('DisplayPassengersComponent', () => {
  let component: DisplayPassengersComponent;
  let fixture: ComponentFixture<DisplayPassengersComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DisplayPassengersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DisplayPassengersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
