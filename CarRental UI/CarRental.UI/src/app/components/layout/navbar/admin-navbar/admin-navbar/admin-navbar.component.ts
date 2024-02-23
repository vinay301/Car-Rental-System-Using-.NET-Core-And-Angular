import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-admin-navbar',
  templateUrl: './admin-navbar.component.html',
  styleUrls: ['./admin-navbar.component.css']
})
export class AdminNavbarComponent {
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
