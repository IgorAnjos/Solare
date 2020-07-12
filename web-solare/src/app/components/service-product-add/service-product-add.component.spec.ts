import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ServiceProductAddComponent } from './service-product-add.component';

describe('ServiceProductAddComponent', () => {
  let component: ServiceProductAddComponent;
  let fixture: ComponentFixture<ServiceProductAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ServiceProductAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ServiceProductAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
