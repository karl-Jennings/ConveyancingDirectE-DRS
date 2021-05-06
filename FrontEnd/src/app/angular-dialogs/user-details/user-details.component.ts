import { CdkNoDataRow } from '@angular/cdk/table';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ToastrService } from 'ngx-toastr';
import { User } from 'src/app/models/user';
import { UserAccountService } from 'src/app/services/user-account.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {

  userGroup!: FormGroup;
  hide = true;

  constructor(
    private formBuilder: FormBuilder,
    private toastr: ToastrService,
    private userService: UserAccountService,
    public dialogRef: MatDialogRef<UserDetailsComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any // the data you are going to receive from parent component
  ) { }

  ngOnInit(): void {

    this.userGroup = this.formBuilder.group({
      UserId: [0],
      Username: ['', Validators.required],
      Email: ['', Validators.required],
      Firstname: ['', Validators.required],
      Lastname: [''],
      Designation: ['admin'],
      Password: ['', Validators.required]
    })
    if (this.data.type == 'view') {
      let user: User = this.data.element;

      this.userGroup.patchValue({
        UserId: user.UserId,
        Username: user.Username,
        Email: user.Email,
        Firstname: user.Firstname,
        Lastname: user.Lastname,
        Designation: user.Designation,
        Password: user.Password,
      });
    }
  }

  onNoClick(): void {
    let send = { type: 'cancel' }
    this.dialogRef.close(send);
  }

  onSubmit() {
    if (this.userGroup.valid) {
      let user: User = this.userGroup.value;
      this.userService.UpdateUser(user).subscribe(res => {
        if (res) {
          let send = { type: 'save' }
          this.dialogRef.close(send);
        }
      })
    }

  }

}
