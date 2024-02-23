import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { Car } from '../models/car.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CarsService {

  baseApiUrl : string = environment.baseApiUrl;
  car : Car[] = [];
  constructor(private http : HttpClient ) { }

  getAllCarsList() : Observable<Car[]>{
    return this.http.get<Car[]>(this.baseApiUrl + '/api/Car/Cars');
  }

  addCars(addCarRequest : Car) : Observable<Car>{
    addCarRequest.id = '00000000-0000-0000-0000-000000000000'
    return this.http.post<Car>(this.baseApiUrl + '/api/Car/AddCars',addCarRequest);
  }

  getCarById(id : string) : Observable<Car>{
    return this.http.get<Car>(this.baseApiUrl + '/api/Car/' + id);
  }

  editCar(id : string, editCarRequest : Car) : Observable<Car>
  {
    return this.http.put<Car>(this.baseApiUrl + '/api/Car/' + id, editCarRequest);
  }

  deleteCar(id : string) : Observable<Car>{
    return this.http.delete<Car>(this.baseApiUrl + '/api/Car/' + id);
  }

  

  //Login Users
  login(loginObj : any){
    return this.http.post<any>(this.baseApiUrl+'/api/User/Login',loginObj)
  }

  //function to check whether the role is Admin or not
  roleMatch(allowedRoles: any[]): boolean {
    var isMatch = false;
    var tokenObj =localStorage.getItem('token');

    if(tokenObj!=null){

      var payLoad = JSON.parse(window.atob(tokenObj.split('.')[1]));

    }
    var userRole = payLoad.role;
    allowedRoles.forEach(element => {
      if (userRole == element) {
        isMatch = true;
        return false;
      }
      else{
        return true;
      }
    });
    return isMatch;
  }
}
