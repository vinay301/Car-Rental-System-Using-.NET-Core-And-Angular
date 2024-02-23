import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CarsService } from 'src/app/services/cars.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  loginForm! :  FormGroup;
  type: string = 'password';
  isText: boolean = false;
  isLogin : boolean = false;
  constructor( private fb: FormBuilder, private auth : CarsService, private router: Router, private toastr : ToastrService)
     {
      this.loginForm = this.fb.group({
        email:['', Validators.required],
        password:['', Validators.required]
      })
    }

  

  ngOnInit(): void {
    if (localStorage.getItem('token') != null)
    {
      this.router.navigateByUrl('');
    }
    this.loginForm = this.fb.group({
      email: ['', Validators.required],
      password: ['', Validators.required],
    });
  }

  onLogin() {
    console.log(this.loginForm.value.email);
    this.auth.login(this.loginForm.value).subscribe({

     next: (res: any) => {
        localStorage.setItem('token', res.token);
        this.isLogin = true;
        this.router.navigateByUrl('admin-dashboard');
        alert('Login Successfully');
        this.toastr.success('Login Successfully');
      },
      error :err => {
        if (err.status == 400)
          this.toastr.error('Incorrect username or password.', 'Authentication failed.');
        else
          console.log(err);
      }
  });
  }


}
