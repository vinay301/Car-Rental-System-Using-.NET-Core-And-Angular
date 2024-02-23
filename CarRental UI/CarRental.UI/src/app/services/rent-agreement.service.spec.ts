import { TestBed } from '@angular/core/testing';

import { RentAgreementService } from './rent-agreement.service';

describe('RentAgreementService', () => {
  let service: RentAgreementService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RentAgreementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
