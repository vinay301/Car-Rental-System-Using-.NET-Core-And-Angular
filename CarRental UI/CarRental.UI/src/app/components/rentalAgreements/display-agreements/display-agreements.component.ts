import { Component, OnInit } from '@angular/core';
import { CarRentalAgreement } from 'src/app/models/rentalAgreement.model';
import { RentAgreementService } from 'src/app/services/rent-agreement.service';

@Component({
  selector: 'app-display-agreements',
  templateUrl: './display-agreements.component.html',
  styleUrls: ['./display-agreements.component.css']
})
export class DisplayAgreementsComponent implements OnInit {

  rentalAgreements: CarRentalAgreement[] = [];

  constructor(private rentAgreementService: RentAgreementService) {}
  ngOnInit(): void {
    this.rentAgreementService.getAllRentalAgreements()
    .subscribe(rentalAgreements => {
      this.rentalAgreements = rentalAgreements;
    });
  }
}

