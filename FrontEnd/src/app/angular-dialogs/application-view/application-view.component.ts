import { Component, ElementRef, Inject, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';
import { ApplicationForm } from 'src/app/models/application-form';
import { CommonUtils } from 'src/environments/common-utils';

@Component({
  selector: 'app-application-view',
  templateUrl: './application-view.component.html',
  styleUrls: ['./application-view.component.css']
})
export class ApplicationViewComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  // typeData: any[] = [
  //   { id: 1, Title: "Doc 1" },
  //   { id: 2, Title: "Doc 2" },
  //   { id: 3, Title: "Doc 3" }
  // ];

  // certificates: any[] = [
  //   { id: 1, Title: "I/We certify this attachment is a true copy of the original document" },
  //   { id: 2, Title: "I/We certify this attachment is a true copy of a document which is certified by a conveyancer to be a true copy of the original" },
  //   { id: 3, Title: "This attachment is an uncertified copy" }
  // ];

  // selectedCertificate: { id?: any; Title?: any; } = {};

  // applicationFormList: ApplicationForm[] = [{
  //   Type: { Title: "" },
  //   CertificationType: { Title: "" },
  // }];

  // @ViewChild("file") file: ElementRef | undefined;
  // fileName = "Choose file*";

  // applicationGroup!: FormGroup;

  // documentTypeController = new FormControl();
  // documentTypeOptions: Observable<any[]> | undefined;

  // constructor(
  //   public dialogRef: MatDialogRef<ApplicationViewComponent>,
  //   private formBuilder: FormBuilder,
  //   @Inject(MAT_DIALOG_DATA) public data: any
  // ) { }

  // ngOnInit(): void {

  //   this.data.appForms.forEach((x: any) => {
  //     x.LocalId = this.attachmentId++;
  //     x.Type = this.typeData.find(s => s.Title == x.Type);
  //     x.CertificationType = this.certificates.find(s => s.Title == x.CertificationType);
  //   });
  //   this.applicationFormList = this.data.appForms;


  //   this.applicationGroup = this.formBuilder.group({
  //     Type: ['', Validators.required],
  //     Reference: ['', Validators.required],
  //     ChargeDate: new FormControl(CommonUtils.formatDate(new Date())),
  //     CertificationType: ['', Validators.required],
  //     Fee: [0.00, [Validators.required, Validators.min(1)]],
  //     FileType: [{}],
  //     LocalId: [0]
  //   })

  //   this.documentTypeOptions = this.documentTypeController.valueChanges.pipe(
  //     startWith(''),
  //     map(value => (typeof value === "string" ? value : value.name)),
  //     map(value =>
  //       value ? this.typeData.filter(
  //         option =>
  //           option.name.toLowerCase().includes(value.toLowerCase())
  //       )
  //         : this.typeData.slice()
  //     )
  //   );

  // }

  // RemoveApplication(item: any) {
  //   this.applicationFormList = this.applicationFormList?.filter(s => s.LocalId != item.LocalId);
  // }

  // uploadFile() {
  //   this.fileName = this.file?.nativeElement.files[0].name;
  // }

  // displayFnRegType(model: any) {
  //   return model && model.Title ? model.Title : "";
  // }

  // attachmentId = 1;
  // selectedApplicationId = 0;

  // AttachApplication() {

  //   let appForm = this.applicationGroup.value;
  //   appForm.LocalId = this.attachmentId++;

  //   let fileToUpload = this.file?.nativeElement.files[0];

  //   let reader = new FileReader();

  //   if (fileToUpload != undefined) {
  //     reader.readAsDataURL(fileToUpload);
  //     reader.onload = function () {
  //       //me.modelvalue = reader.result; 
  //       appForm.FileType.base64 = reader.result;
  //     };
  //     reader.onerror = function (error) {
  //       console.log('Error: ', error);
  //     };
  //     appForm.FileName = fileToUpload.name;

  //     appForm.FileType.extension = fileToUpload.name.substr(
  //       fileToUpload.name.lastIndexOf(".") + 1
  //     );
  //   }

  //   if (this.applicationGroup.valid) {
  //     let tempAppForm = this.applicationGroup.value;

  //     if (this.applicationFormList.find(s => s.LocalId == this.selectedApplicationId) == null) {
  //       this.applicationFormList.push(Object.assign({}, tempAppForm));

  //     } else {
  //       this.applicationFormList = this.applicationFormList.filter(s => s.LocalId != this.selectedApplicationId);

  //       tempAppForm.LocalId = this.selectedApplicationId;

  //       this.applicationFormList.push(Object.assign({}, tempAppForm));
  //       this.applicationFormList = this.applicationFormList.sort((a, b) => {
  //         return a.LocalId! - b.LocalId!;
  //       });
  //     }
  //   }
  // }

  // ClearFields() {
  //   this.fileName = "Choose file*";
  //   this.selectedApplicationId = 0;
  //   this.applicationGroup = this.formBuilder.group({
  //     Type: [''],
  //     Reference: [''],
  //     ChargeDate: new FormControl(CommonUtils.formatDate(new Date())),
  //     CertificationType: [''],
  //     Fee: [0.00],
  //     FileType: [{}],
  //     LocalId: [0]
  //   })

  //   this.applicationFormList?.forEach(s => s.IsSelected = false);
  // }


  // SelectAppRow(id: any) {

  //   this.applicationFormList?.filter(s => s.LocalId == id).forEach(s => s.IsSelected = true);
  //   this.applicationFormList?.filter(s => s.LocalId != id).forEach(s => s.IsSelected = false);

  //   var selectedAppForm: any = this.applicationFormList?.find(s => s.LocalId == id);
  //   this.selectedApplicationId = selectedAppForm.LocalId;
  //   this.applicationGroup = this.formBuilder.group(selectedAppForm)

  //   this.applicationGroup.patchValue({
  //     ChargeDate: CommonUtils.formatDate(new Date(selectedAppForm.ChargeDate))
  //   });
  //   this.fileName = selectedAppForm.FileName;

  // }

  // onNoClick(): void {
  //   var send = { type: 'cancel', appList: [] }

  //   this.dialogRef.close(send);
  // }

  // SubmitForm() {
  //   this.applicationFormList.forEach(x => {
  //     x.CertificationType = x.CertificationType.Title;
  //     x.Type = x.Type.Title;
  //   })
  //   var send = { type: 'submit', appList: this.applicationFormList }
  //   this.dialogRef.close(send)
  // }

}
