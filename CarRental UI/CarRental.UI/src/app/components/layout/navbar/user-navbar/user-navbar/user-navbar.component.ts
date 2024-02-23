import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-user-navbar',
  templateUrl: './user-navbar.component.html',
  styleUrls: ['./user-navbar.component.css']
})
export class UserNavbarComponent {

  isLogin:boolean = false;
 
  constructor(private router : Router, private toastr : ToastrService) {}
  Logout() {
    console.log("in the log out ");
    localStorage.removeItem('token');
    // this.router.navigateByUrl('/customer/home-page');
    this.router.navigateByUrl('');
    this.toastr.success('Logout Successfully');
  }
}
