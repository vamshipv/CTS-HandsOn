import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditEmployeeTDFComponent } from './edit-employee-tdf.component';

describe('EditEmployeeTDFComponent', () => {
  let component: EditEmployeeTDFComponent;
  let fixture: ComponentFixture<EditEmployeeTDFComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditEmployeeTDFComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditEmployeeTDFComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
