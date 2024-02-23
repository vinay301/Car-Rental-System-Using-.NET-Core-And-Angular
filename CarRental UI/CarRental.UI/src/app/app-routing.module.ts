import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarListComponent } from './components/cars/car-list/car-list.component';
import { AddCarComponent } from './components/cars/add-car/add-car.component';
import { EditCarComponent } from './components/cars/edit-car/edit-car.component';
import { CarDetailsComponent } from './components/cars/car-details/car-details.component';
import { LoginComponent } from './components/users/login/login/login.component';
import { DisplayAgreementsComponent } from './components/rentalAgreements/display-agreements/display-agreements.component';
import { AdminDashboardComponent } from './components/admin-dashboard/admin-dashboard.component';
import { authGuard } from './shared/auth.guard';
import { UserDashboardComponent } from './components/user-dashboard/user-dashboard/user-dashboard.component';
import { EditAgreementComponent } from './components/rentalAgreements/edit-agreements/edit-agreement/edit-agreement.component';


const routes: Routes = [
  {
    path:'car-list',
    component:CarListComponent
  },
  {
    path:'add-cars',
    component:AddCarComponent
  },
  {
    component:EditCarComponent,
    path:'edit-cars/:carId'
  },
  {
    path:'car-details/:carId',
    component:CarDetailsComponent
  },
  {
    path:'',
    component:LoginComponent
  },
  {
    path:'display-agreement/:id',
    component:DisplayAgreementsComponent
  },
  {
    path:'edit-agreement/:id',
    component:EditAgreementComponent
  },
  {
    path:'admin-dashboard',
    component:AdminDashboardComponent,
    canActivate:[authGuard], //Admin dashboard is restricted to ADMIN ONLY
    data:{permittedRoles:['Admin']}
  },
  {
    path:'user-dashboard',
    component:UserDashboardComponent,
    canActivate:[authGuard], //Admin dashboard is restricted to USER ONLY
    data:{permittedRoles:['User']}
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
