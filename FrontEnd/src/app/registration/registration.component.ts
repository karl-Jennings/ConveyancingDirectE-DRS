import { Component, OnInit } from '@angular/core';
import { RegistrationType } from '../models/registration-type';
import { RegistrationService } from '../services/registration.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit {

  constructor(private registrationServices: RegistrationService) { }

  registrationTypes: RegistrationType[] = [

  ];

  selectedRegistration: RegistrationType = {};

  nextPath: any = "document-registration";
  ngOnInit(): void {
    this.registrationServices.getRegistrationTypes().subscribe(res => {
      this.registrationTypes = res;
    })
  }

  RegistrationTypeChange() {
    this.nextPath = this.selectedRegistration.Url + "/" + this.selectedRegistration.RegistrationTypeId;

  }

}
