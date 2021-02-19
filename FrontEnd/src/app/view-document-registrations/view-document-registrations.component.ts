import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { DocumentReference } from 'src/app/models/document-reference';
import { RegistrationService } from 'src/app/services/registration.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-view-document-registrations',
  templateUrl: './view-document-registrations.component.html',
  styleUrls: ['./view-document-registrations.component.css']
})
export class ViewDocumentRegistrationsComponent implements OnInit {

  dataSource: DocumentReference[] = [];

  regType!: string;

  displayedColumns: string[] = ['ID', 'Reference', 'AppDate', 'View'];

  regTypeComponent = "document-registration";

  constructor(
    private registrationService: RegistrationService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit(): void {

    this.regType = this.route.snapshot.paramMap.get("regTypeId")!;

    this.registrationService.GetRegistrationType(this.regType).subscribe(res => {
      this.regTypeComponent = res.Url;
      console.log(res)
    })

    this.registrationService.GetRegistrations(this.regType).subscribe(res => {
      this.dataSource = res
    })
  }

  DeleteRegistration(refId: any) {
    Swal.fire({
      title: 'Are you sure you want delete this?',
      text: "You won't be able to revert this!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
      if (result.isConfirmed) {
        this.registrationService.DeleteRegistration(refId).subscribe(deleteRes => {
          this.registrationService.GetRegistrations(this.regType).subscribe(res => {
            this.dataSource = res
          })
        })
      }
    })
  }
}
