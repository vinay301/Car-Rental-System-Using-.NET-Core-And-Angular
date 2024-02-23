import { Component, NgIterable, OnInit } from '@angular/core';
import { Car } from 'src/app/models/car.model';
import { CarsService } from 'src/app/services/cars.service';
@Component({
  selector: 'app-car-list',
  templateUrl: './car-list.component.html',
  styleUrls: ['./car-list.component.css']
})
export class CarListComponent implements OnInit{

  car : Car[] = [];
  carModel = '';
  SearchModel = '';
  constructor(private carsServices : CarsService) {
   
  }
  ngOnInit(): void {
    this.carsServices.getAllCarsList().subscribe({
      next : (car) => {
        this.car = car;
      },
      error :(err)=> {
        console.log("Error", err)
      }
    })
  }

  onModelFilter() {
    this.SearchModel = this.carModel
  }
  onModelFilterClear(){
    this.SearchModel = '',
    this.carModel = '';
  }
}
