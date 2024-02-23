import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CarListComponent } from './components/cars/car-list/car-list.component';
import { HttpClientModule } from '@angular/common/http';
import { AddCarComponent } from './components/cars/add-car/add-car.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EditCarComponent } from './components/cars/edit-car/edit-car.component';

import { ToastrModule, provideToastr } from 'ngx-toastr';
import { BrowserAnimationsModule, provideAnimations } from '@angular/platform-browser/animations';
import { CarDetailsComponent } from './components/cars/car-details/car-details.component';
import { LoginComponent } from './components/users/login/login/login.component';
import { AdminNavbarComponent } from './components/layout/navbar/admin-navbar/admin-navbar/admin-navbar.component';
import { DisplayAgreementsComponent } from './components/rentalAgreements/display-agreements/display-agreements.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { UserDashboardComponent } from './components/user-dashboard/user-dashboard/user-dashboard.component';
import { UserNavbarComponent } from './components/layout/navbar/user-navbar/user-navbar/user-navbar.component';
import { EditAgreementComponent } from './components/rentalAgreements/edit-agreements/edit-agreement/edit-agreement.component';
import { FilterPipe } from './pipes/filter.pipe';
import { SortPipe } from './pipes/sort.pipe';

@NgModule({
  declarations: [
    AppComponent,
    CarListComponent,
    AddCarComponent,
    EditCarComponent,
    CarDetailsComponent,
    LoginComponent,
    AdminNavbarComponent,
    DisplayAgreementsComponent,
    AdminDashboardComponent,
    UserDashboardComponent,
    UserNavbarComponent,
    EditAgreementComponent,
    FilterPipe,
    SortPipe
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot({
      progressBar:true
    }) // ToastrModule added
  ],
  providers: [
    provideAnimations(), // required animations providers
    provideToastr(), // Toastr providers],
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
