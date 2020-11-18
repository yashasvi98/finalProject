import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SectordisplayComponent } from './sectordisplay.component';

describe('SectordisplayComponent', () => {
  let component: SectordisplayComponent;
  let fixture: ComponentFixture<SectordisplayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SectordisplayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SectordisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
