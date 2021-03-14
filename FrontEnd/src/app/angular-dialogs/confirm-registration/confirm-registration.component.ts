import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-confirm-registration',
  templateUrl: './confirm-registration.component.html',
  styleUrls: ['./confirm-registration.component.css']
})
export class ConfirmRegistrationComponent implements OnInit {
  result: { TypeCode?: string, Description?: string, CreatedDate: Date, ResponseType: string };

  constructor(public dialogRef: MatDialogRef<ConfirmRegistrationComponent>, @Inject(MAT_DIALOG_DATA) public data: any) {
    this.result = this.data.res

  }

  ngOnInit(): void {
    console.log(this.result)
  }

  onNoClick(): void {
    var send = { type: 'cancel' }

    this.dialogRef.close(send);
  }

}
