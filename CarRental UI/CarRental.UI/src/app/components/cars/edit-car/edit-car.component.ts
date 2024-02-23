import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Car } from 'src/app/models/car.model';
import { CarsService } from 'src/app/services/cars.service';

@Component({
  selector: 'app-edit-car',
  templateUrl: './edit-car.component.html',
  styleUrls: ['./edit-car.component.css']
})
export class EditCarComponent implements OnInit{

  editCarRequest : Car = {
    id: '',
    name: '',
    maker: '',
    model: '',
    pricePerDay: 0,
    imageUrl: '',
    isAvailable: false
  }
 
  constructor(private carsService : CarsService, private route : ActivatedRoute, private router : Router) {}
  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next : (params) => {
        const id = params.get('id');
  
        if(id)
        {
          //if id is not undefined, call the API
          this.carsService.getCarById(id).subscribe(
            {
              next : (response) => {
                  this.editCarRequest = response;
              }
            }
          );
        }
      },
    })
  }

  editCars() {
    this.carsService.editCar(this.editCarRequest.id,this.editCarRequest)
    .subscribe({
      next : (response) => {
        this.router.navigate(['']);
      }
    } 
    );
  }

  deleteCar(id:string)
  { 
    this.carsService.deleteCar(id)
    .subscribe({
      next : (response) => {
        this.router.navigate(['']);
      },
    });
    }
}
