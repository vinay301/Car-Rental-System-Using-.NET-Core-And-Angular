import { CanActivateFn, Router } from '@angular/router';
import { CarsService } from '../services/cars.service';
import { inject } from '@angular/core';

export const authGuard: CanActivateFn = (route, state) => {
  const router = inject(Router)
  const  service = inject(CarsService)

  if (localStorage.getItem('token')!=null) {
    // Return true if the user is authenticated
    let roles = route.data['permittedRoles'] as Array<string>;
      if(roles)
      {
        if(service.roleMatch(roles)) return true;
        else
        {
          // if role is user
          router.navigate(['/user-dashboard']);
          return false;
        }

      }

    return true;

  } else {
    // Redirect the user to the login page if they are not authenticated
    router.navigate(['login']);
    return false;
  }
};
