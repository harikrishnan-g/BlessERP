/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { NurseHandoverBookComponent } from './NurseHandoverBook.component';

describe('NurseHandoverBookComponent', () => {
  let component: NurseHandoverBookComponent;
  let fixture: ComponentFixture<NurseHandoverBookComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NurseHandoverBookComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NurseHandoverBookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
