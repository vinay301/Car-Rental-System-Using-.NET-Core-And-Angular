import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CarRentalAgreement } from 'src/app/models/rentalAgreement.model';
import { RentAgreementService } from 'src/app/services/rent-agreement.service';

@Component({
  selector: 'app-edit-agreement',
  templateUrl: './edit-agreement.component.html',
  styleUrls: ['./edit-agreement.component.css']
})
export class EditAgreementComponent {

  rentDetail : CarRentalAgreement | undefined;
  carRentalForm : CarRentalAgreement = {
    id: 0 ,
    carId: 0,
    startDate: new Date(),
    endDate: new Date(),
    carName:'',
    customerName : '',
    rentalPrice:0,
    isRented:true
  }

  
constructor(private route : ActivatedRoute, private rentService : RentAgreementService, private router : Router) {
  
}

ngOnInit(): void {
  
 
}
calculateTotalPrice(rent: CarRentalAgreement, startDate: any, endDate: any): number {
  const numberOfDays = endDate - startDate;
  const dailyRentalRate = rent.rentalPrice;
  const totalRentalCost = numberOfDays * dailyRentalRate;

  // Add any additional fees, such as taxes and insurance.

  return totalRentalCost;
}
}
