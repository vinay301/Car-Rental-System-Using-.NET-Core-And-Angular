import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Car } from 'src/app/models/car.model';
import { CarRentalAgreement } from 'src/app/models/rentalAgreement.model';
import { CarsService } from 'src/app/services/cars.service';
import { RentAgreementService } from 'src/app/services/rent-agreement.service';

@Component({
  selector: 'app-car-details',
  templateUrl: './car-details.component.html',
  styleUrls: ['./car-details.component.css']
})
export class CarDetailsComponent implements OnInit{

  carRentalForm : FormGroup;
  carDetail: Car | undefined;
  rentDetail : CarRentalAgreement | undefined; 
  
  constructor(private activeRoute : ActivatedRoute, private carsService : CarsService, private route : Router, private fb: FormBuilder, private rentAgreementService : RentAgreementService) 
  {
    this.carRentalForm = this.fb.group({
     
      customerName : ['', Validators.required],
      startDate:['', Validators.required],
      endDate:['', Validators.required],
      carName:['',Validators.required],
      carModel:['',Validators.required],
      carMaker:['',Validators.required]
    })
  }

  ngOnInit(): void {
    let carId = this.activeRoute.snapshot.paramMap.get('carId');
    console.warn(carId);
    carId && this.carsService.getCarById(carId).subscribe((result) => {
      console.warn(result);
      this.carDetail = result;
    })
  }

  rentCar() {
    if (this.carRentalForm.valid) {
      // Call the ASP.NET Core Web API controller to rent the car
      this.rentAgreementService.createRentalAgreement(this.carRentalForm.value)
        .subscribe(() => {
          // Display a success message to the user
          // this.rent.isRented = true;
          alert('Car rented successfully!');
          //when successfully rented a car then redirect to edit the rent agreement
          let rentId = this.activeRoute.snapshot.paramMap.get('rentId');
          console.warn(rentId);
          rentId && this.rentAgreementService.getRentalAgreementById(rentId).subscribe((result) => {
            console.warn(result);
            this.rentDetail = result;
          })
          this.route.navigateByUrl('edit-agreement/:carId')
        });
    } else {
      // this.rent.isRented = false;
      // Display an error message to the user
      alert('Please enter valid data.');
    }
  }

  

}
