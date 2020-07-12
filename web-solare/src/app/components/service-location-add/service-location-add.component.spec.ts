import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceLocationAddComponent } from './service-location-add.component';

describe('ServiceLocationAddComponent', () => {
  let component: ServiceLocationAddComponent;
  let fixture: ComponentFixture<ServiceLocationAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServiceLocationAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServiceLocationAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
