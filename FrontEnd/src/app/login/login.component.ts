import { stringify } from '@angular/compiler/src/util';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { User } from '../models/user';
import { UserAccountService } from '../services/user-account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  user: User = {};
  showProgress = false;
  @Output() loginStatus = new EventEmitter<boolean>();

  userGroup!: FormGroup;

  constructor(private toastr: ToastrService, private formBuilder: FormBuilder, private userAccountServices: UserAccountService) {

  }

  ngOnInit(): void {
    this.InitializeFormGroup();
  }

  InitializeFormGroup() {
    this.userGroup = this.formBuilder.group({
      email: ['', Validators.email],
      password: ['']
    })
  }

  doLogin() {
    if (this.userGroup.valid) {
      this.userAccountServices.login(this.userGroup.value).subscribe(res => {

        let userModel = res as User;
        if (userModel.IsUserValid) {

          localStorage.setItem('jwtToken', userModel.Token!);
          localStorage.setItem('userId', userModel.UserId?.toString()!);
          localStorage.setItem('fullName', userModel.Fullname!);
          this.loginStatus.emit(true);
        } else {
          this.toastr.warning('Invalid Email/Password', 'Please try again');
        }
      })
    }
  }
}
