import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.development';
import { CarRentalAgreement } from '../models/rentalAgreement.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RentAgreementService {
  baseApiUrl : string = environment.baseApiUrl;
  constructor(private http : HttpClient) { }

    getAllRentalAgreements()  : Observable<CarRentalAgreement[]>{
    return this.http.get<CarRentalAgreement[]>(this.baseApiUrl + '/api/RentalAgreement');
    }
    
    getRentalAgreementById(id: string) :Observable<CarRentalAgreement>{
    return this.http.get<CarRentalAgreement>(this.baseApiUrl + '/api/RentalAgreement/' + id);
    }
    createRentalAgreement(addCarRentalAgreement: CarRentalAgreement) : Observable<CarRentalAgreement>{
    return this.http.post<CarRentalAgreement>(this.baseApiUrl + '/api/RentalAgreement', addCarRentalAgreement);
    }
    updateRentalAgreement(id: number, editCarRentalAgreement: CarRentalAgreement) : Observable<CarRentalAgreement>{
    return this.http.put<CarRentalAgreement>(this.baseApiUrl + '/api/RentalAgreement/' + id, editCarRentalAgreement);
    }
    
    deleteRentalAgreement(id: number) : Observable<any>{
    return this.http.delete(this.baseApiUrl + '/api/RentalAgreement/' + id);
    }

    
}
