import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-lr-credentials',
  templateUrl: './lr-credentials.component.html',
  styleUrls: ['./lr-credentials.component.css']
})
export class LrCredentialsComponent implements OnInit {

  lrCredentialGroup!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
  ) { }


  ngOnInit(): void {
    this.lrCredentialGroup = this.formBuilder.group({
      LrCredentialsId: 1,
      Username: ['', Validators.required],
      Password: ['', Validators.required]
    })
  }

}
