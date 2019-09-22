/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { NurseHandoverBookService } from './nurseHandoverBook.service';

describe('NurseHandoverBookService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: NurseHandoverBookService = TestBed.get(
      NurseHandoverBookService
    );
    expect(service).toBeTruthy();
  });
});
