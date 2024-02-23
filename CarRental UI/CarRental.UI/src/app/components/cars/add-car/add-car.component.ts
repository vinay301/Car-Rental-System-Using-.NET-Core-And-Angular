import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Car } from 'src/app/models/car.model';
import { CarsService } from 'src/app/services/cars.service';

@Component({
  selector: 'app-add-car',
  templateUrl: './add-car.component.html',
  styleUrls: ['./add-car.component.css']
})
export class AddCarComponent implements OnInit{
 
  addCarRequest : Car = {
    id: '',
    name: '',
    maker: '',
    model: '',
    pricePerDay: 0,
    imageUrl: '',
    isAvailable: false
  }
  constructor(private carsService : CarsService, private router : Router) {}

ngOnInit(): void {
  
}

addCars(){
  this.carsService.addCars(this.addCarRequest)
  .subscribe({
    next:(car)=>
    {
      console.log("Car Details", car);
      //After Successful addition of cars into databse, navigate to homepage
      this.router.navigate(['/admin-dashboard']);
    },
    error :(err)=>
    {
      console.log('Error Occured while adding the new car ', err)
    }
  })
  console.log(this.addCarRequest);
}

}
