import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-confirm-registration',
  templateUrl: './confirm-registration.component.html',
  styleUrls: ['./confirm-registration.component.css']
})
export class ConfirmRegistrationComponent implements OnInit {
  result: any
  constructor(public dialogRef: MatDialogRef<ConfirmRegistrationComponent>, @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    this.result = this.data.res
    console.log(this.result)
  }

  onNoClick(): void {
    var send = { type: 'cancel' }

    this.dialogRef.close(send);
  }

}
