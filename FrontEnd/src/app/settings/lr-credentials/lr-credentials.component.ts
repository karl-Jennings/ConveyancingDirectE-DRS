import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { SettingsService } from 'src/app/services/settings.service';

@Component({
  selector: 'app-lr-credentials',
  templateUrl: './lr-credentials.component.html',
  styleUrls: ['./lr-credentials.component.css']
})
export class LrCredentialsComponent implements OnInit {

  lrCredentialGroup!: FormGroup;
  hide = true;

  constructor(
    private formBuilder: FormBuilder,
    private toastr: ToastrService,
    private settingService: SettingsService
  ) { }


  ngOnInit(): void {
    this.lrCredentialGroup = this.formBuilder.group({
      LrCredentialsId: 1,
      Username: ['', Validators.required],
      Password: ['', Validators.required]
    })
    this.settingService.GetCredentials().subscribe(res => {
      this.lrCredentialGroup.setValue(res);
    })
  }

  onSubmit() {
    if (this.lrCredentialGroup.valid) {
      var object = this.lrCredentialGroup.value;
      this.settingService.ChangeCredentials(object).subscribe(res => {
        this.toastr.success("Username/Password has been changed", "Successfully Updated")
      }, err => {
        this.toastr.error("Username/Password has not been changed", "Operation Failed")
      })
    } else {
      this.toastr.warning("Please check the Username/Password", "Fields missing/invalid")
    }
  }

}
