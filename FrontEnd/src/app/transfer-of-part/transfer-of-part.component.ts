import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators, Form } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ApplicationViewComponent } from '../angular-dialogs/application-view/application-view.component';
import { ConfirmRegistrationComponent } from '../angular-dialogs/confirm-registration/confirm-registration.component';
import { ApplicationForm, Document } from '../models/application-form';
import { DocumentReference } from '../models/document-reference';
import { Party } from '../models/party';
import { Roles } from '../models/roles';
import { SupportingDocuments } from '../models/supporting-documents';
import { TitleNumber } from '../models/title-number';
import { RegistrationService } from '../services/registration.service';
import * as FileSaver from 'file-saver';
import { DatePipe } from '@angular/common';
import { CommonUtils } from 'src/environments/common-utils';
import Swal from 'sweetalert2';
import { AttachmentNotes } from '../models/attachment-notes';
import { RequestLogs } from '../models/request-logs';

@Component({
  selector: 'app-transfer-of-part',
  templateUrl: './transfer-of-part.component.html',
  styleUrls: ['./transfer-of-part.component.css']
})
export class TransferOfPartComponent implements OnInit {

  rolesList: string[] = ["Borrower", "Lender", "Lessee", "Lessor", "PersonalRepresentative", "PowerOfAttorney", "Proprietor", "Third Party", "Transferee", "Transferor"];
  appTypeList: string[] = [
    "Adverse possession of registered land",
    "Notification of adverse possession",
    "Agreed Notice",
    "Alteration of Register",
    "Appointment of New Trustee",
    "Assent"
  ];
  supDocNameList: string[] = [
    "Abstract",
    "Agreement",
    "Assent",
    "Assignment",
    "Birth Certificate",
    "Charge",
    "Conveyance",
    "Correspondence",
  ];

  titleList: TitleNumber[] = [];
  applicationList: ApplicationForm[] = [];
  supportingDocList: SupportingDocuments[] = [];
  partyList: Party[] = [];
  notesList: AttachmentNotes[] = [];
  logsList: RequestLogs[] = [];

  txtTitle: FormControl = new FormControl();
  applicationGroup!: FormGroup;
  supportingDocGroup!: FormGroup;
  partyGroup!: FormGroup;
  notesGroup!: FormGroup;

  selectedTitleNumber: number | undefined;
  selectedApplicationId: number | undefined;
  selectedsupportingDocId: number | undefined;
  selectedPartyId: number | undefined;
  selectedNotesId: number | undefined;

  documentReferenceGroup!: FormGroup;

  @ViewChild('txtCustomEmail') txtCustomEmail!: ElementRef;

  regType!: number;
  docRefId!: any;
  @ViewChild("file") file: ElementRef | undefined;

  titleSaveBtn = "Add";
  appSaveBtn = "Add";
  supDocSaveBtn = "Add";
  partSaveBtn = "Add";
  notesSaveBtn = "Add";

  constructor(
    private dialog: MatDialog,
    private formBuilder: FormBuilder,
    private registrationService: RegistrationService,
    private route: ActivatedRoute,
    private toastr: ToastrService
  ) { }

  ngOnInit(): void {
    this.regType = +this.route.snapshot.paramMap.get("regTypeId")!;
    this.docRefId = +this.route.snapshot.paramMap.get("docRefId")!;


    this.documentReferenceGroup = this.formBuilder.group({
      Password: ['', Validators.required],
      AdditionalProviderFilter: ['', Validators.required],
      MessageID: [''],
      ExternalReference: ['', Validators.required],
      UserID: [+localStorage.getItem("userId")!],
      Reference: ['', Validators.required],
      TotalFeeInPence: [0],
      Email: ['', [Validators.required, Validators.email]],
      Notes: ['', Validators.required],
      TelephoneNumber: ['', Validators.required],
      AP1WarningUnderstood: [true],
      ApplicationDate: [new Date().toISOString().substring(0, 10), Validators.required],
      DisclosableOveridingInterests: [true],
      RepresentativeId: [0],
      ApplicationAffects: ['', Validators.required],
      RegistrationTypeId: [this.regType],
      PostcodeOfProperty: ['', Validators.required],
      LocalAuthority: ['', Validators.required],
      DocumentReferenceId: 0
    })

    // const _today = CommonUtils.formatDate();
    // this.documentReferenceGroup.controls.ApplicationDate.setValue(_today.toISOString().substring(0, 10););

    this.applicationGroup = this.formBuilder.group({
      Priority: [1, Validators.required],
      Value: ['', Validators.required],
      FeeInPence: [0],
      Type: ['', Validators.required],
      LocalId: [0],
      IsSelected: [false],
      ApplicationFormId: 0,
      DocumentReferenceId: 0,
      DocumentReference: null,
      CertifiedCopy: [''],
      ExternalReference: ['', Validators.required],
      Document: {}
    });

    this.supportingDocGroup = this.formBuilder.group({
      CertifiedCopy: ['', Validators.required],
      DocumentId: ['', Validators.required],
      DocumentName: ['', Validators.required],
      LocalId: [0],
      IsSelected: [false],
      SupportingDocumentId: 0,
      DocumentReferenceId: 0,
      DocumentReference: null,
    });

    this.partyGroup = this.formBuilder.group({
      PartyType: [true],
      IsApplicant: [true],
      CompanyOrForeName: ['', Validators.required],
      Surname: [''],
      Roles: [''],
      ViewModelRoles: [[], Validators.required],
      LocalId: [0],
      IsSelected: [false],
      PartyId: 0,
      DocumentReferenceId: 0,
      DocumentReference: null,
    });

    this.notesGroup = this.formBuilder.group({
      AdditionalProviderFilter: ['', Validators.required],
      MessageId: 1,
      ExternalReference: ['', Validators.required],
      ApplicationMessageId: ['', Validators.required],
      ApplicationService: ['', Validators.required],
      Notes: ['', Validators.required],
      AttachmentNotesId: 0,
      LocalId: [0],
      IsSelected: [false],
      DocumentReferenceId: 0,
      DocumentReference: null,
    });

    if (this.docRefId != 0) {
      this.registrationService.GetRegistration(this.docRefId).subscribe(res => {
        this.documentReferenceGroup = this.formBuilder.group(res);

        this.titleList = res.Titles ?? [];

        this.titleList.forEach(s => {
          s.LocalId = this.titleId++;
        })

        this.applicationList = res.Applications ?? [];

        this.applicationList.forEach(s => {
          s.LocalId = this.appId++;
        })

        this.supportingDocList = res.SupportingDocuments ?? [];

        this.supportingDocList.forEach(s => {
          s.LocalId = this.appId++;
        })

        this.partyList = res.Parties ?? [];

        this.partyList.forEach(s => {
          s.LocalId = this.appId++;
          s.ViewModelRoles = s.Roles!.split(',');
        })

        this.notesList = res.AttachmentNotes ?? [];

        this.notesList.forEach(s => {
          s.LocalId = this.appId++;
        })
        this.logsList = res.RequestLogs ?? [];

      })
    }

    this.partyGroup.get('PartyType')?.valueChanges.subscribe(res => {
      this.partyType = res
    })

  }

  partyType = 'company';

  // Title Numbers

  titleId = 1;
  PushTitleToGrid() {

    var insertObj: TitleNumber = {
      LocalId: this.titleId++,
      TitleNumberCode: this.txtTitle.value,
      IsSelected: false,
      PropertyName: ""
    }

    if (this.titleList.find(s => s.LocalId == this.selectedTitleNumber) == null) {
      this.titleList.push(Object.assign({}, insertObj));
    } else {
      insertObj = this.titleList.find(s => s.LocalId == this.selectedTitleNumber)!;
      this.titleList = this.titleList.filter(s => s.LocalId != this.selectedTitleNumber);

      insertObj.TitleNumberCode = this.txtTitle.value;

      this.titleList.push(Object.assign({}, insertObj));
      this.titleList = this.titleList.sort((a, b) => {
        return a.LocalId! - b.LocalId!;
      });
    }
    this.ClearTitleFields();


  }


  SelectTitleRow(id: any) {
    this.titleSaveBtn = "Update";
    this.selectedTitleNumber = id
    this.titleList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.titleList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedTitleNumber: any = this.titleList?.find(s => s.LocalId == id);
    this.selectedTitleNumber = selectedTitleNumber.LocalId;
    this.txtTitle?.setValue(selectedTitleNumber.TitleNumberCode)
  }

  ClearTitleFields() {
    this.titleSaveBtn = "Add";
    this.selectedTitleNumber = 0;
    this.txtTitle.setValue([])

    this.titleList?.forEach(s => s.IsSelected = false);
  }

  RemoveTitle(id: any) {
    this.titleList = this.titleList.filter(x => x.LocalId != id);
    if (this.selectedTitleNumber == id) {
      this.selectedTitleNumber = undefined;
    }
  }




  // For Applications

  appId = 1;
  fileName: any = "Choose files";
  PushApplicationToGrid() {

    var insertObj: ApplicationForm = {

    }
    if (this.applicationGroup.valid) {

      var documents: Document = {};
      let fileToUpload = this.file?.nativeElement.files[0];

      var that = this;

      insertObj = that.applicationGroup.value;

      if (fileToUpload != undefined) {
        let fileName = fileToUpload.name;
        let fileString: any = "";
        let reader = new FileReader();
        reader.readAsDataURL(fileToUpload);
        reader.onload = function () {
          //me.modelvalue = reader.result;  
          fileString = reader.result;
          let fileExtension = fileToUpload.name.substr(
            fileToUpload.name.lastIndexOf(".") + 1
          );

          insertObj.LocalId = that.appId++
          insertObj.IsSelected = false;

          documents = {
            DocumentId: insertObj.Document?.DocumentId == undefined ? 0 : insertObj.Document.DocumentId,
            ApplicationFormId: insertObj.Document?.ApplicationFormId == undefined ? 0 : insertObj.Document.ApplicationFormId,
            FileName: fileName, Base64: fileString, FileExtension: fileExtension
          };

          that.InsertDataToAppList(insertObj, documents)


        };
        reader.onerror = function (error) {
          console.log('Error: ', error);
        };
      } else if (insertObj.Document?.DocumentId != null) {

        this.InsertDataToAppList(insertObj, insertObj.Document)
      }
    }
  }

  InsertDataToAppList(insertObj: ApplicationForm, documents: Document) {
    insertObj.Document = documents;
    if (this.applicationList.find(s => s.LocalId == this.selectedApplicationId) == null) {
      this.applicationList.push(Object.assign({}, insertObj));

    } else {
      this.applicationList = this.applicationList.filter(s => s.LocalId != this.selectedApplicationId);
      insertObj.LocalId = this.selectedApplicationId;
      this.applicationList.push(Object.assign({}, insertObj));
      this.applicationList = this.applicationList.sort((a, b) => {
        return a.LocalId! - b.LocalId!;
      });
    }
    this.ClearAppFields();
  }

  SelectAppRow(id: any) {
    this.appSaveBtn = "Update"
    this.selectedApplicationId = id
    this.applicationList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.applicationList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedObj: ApplicationForm = this.applicationList?.find(s => s.LocalId == id)!;
    this.selectedApplicationId = selectedObj.LocalId;
    this.applicationGroup.setValue(selectedObj);
    this.fileName = ""
    this.fileName = selectedObj.Document!.FileName;

  }

  ClearAppFields() {
    this.appSaveBtn = "Add"

    this.applicationList.forEach(x => x.IsSelected = false);
    this.selectedApplicationId = 0;
    this.fileName = "Choose File"
    this.applicationGroup.patchValue({
      Priority: 1,
      Value: '',
      FeeInPence: 0,
      Type: '',
      LocalId: 0,
      IsSelected: false,
      ApplicationFormId: 0,
      DocumentReferenceId: 0,
      DocumentReference: null,
      Document: [],
      ExternalReference: ''
    })
  }

  RemoveApp(id: any) {
    this.applicationList = this.applicationList.filter(x => x.LocalId != id);
    if (this.selectedApplicationId == id) {
      this.selectedApplicationId = undefined;
    }
  }

  uploadFile() {
    this.fileName = "";
    var files: any = this.file!.nativeElement.files;

    for (let i = 0; i < files.length; i++) {
      this.fileName += files[i].name + (i + 1 != files.length ? ", " : "");
    }

  }

  DownloadAttached(item: ApplicationForm) {
    FileSaver.saveAs(item.Document?.Base64!, item.Document?.FileName);
  }


  // For Supporting Documents

  supDocId = 1;
  PushSupDocumentToGrid() {

    var insertObj: SupportingDocuments = {

    }
    if (this.supportingDocGroup.valid) {
      insertObj = this.supportingDocGroup.value;
      insertObj.LocalId = this.supDocId++
      insertObj.IsSelected = false;

      if (this.supportingDocList.find(s => s.LocalId == this.selectedsupportingDocId) == null) {
        this.supportingDocList.push(Object.assign({}, insertObj));
      } else {

        this.supportingDocList = this.supportingDocList.filter(s => s.LocalId != this.selectedsupportingDocId);
        insertObj.LocalId = this.selectedsupportingDocId;
        this.supportingDocList.push(Object.assign({}, insertObj));
        this.supportingDocList = this.supportingDocList.sort((a, b) => {
          return a.LocalId! - b.LocalId!;
        });
      }
      this.ClearSupDocFields();

    }
  }

  SelectSupDocRow(id: any) {
    this.supDocSaveBtn = "Update"
    this.selectedsupportingDocId = id
    this.supportingDocList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.supportingDocList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedObj: any = this.supportingDocList?.find(s => s.LocalId == id);
    this.selectedsupportingDocId = selectedObj.LocalId;
    this.supportingDocGroup.setValue(selectedObj);
  }

  ClearSupDocFields() {
    this.supDocSaveBtn = "Add"

    this.supportingDocList.forEach(x => x.IsSelected = false);

    this.selectedsupportingDocId = 0;
    this.supportingDocGroup.patchValue({
      CertifiedCopy: [''],
      DocumentId: [''],
      DocumentName: [''],
      LocalId: [0],
      IsSelected: [false],
      SupportingDocumentId: 0,
      DocumentReferenceId: 0,
      DocumentReference: null,
    })
  }

  RemoveSupDoc(id: any) {
    this.supportingDocList = this.supportingDocList.filter(x => x.LocalId != id);
    if (this.selectedsupportingDocId == id) {
      this.selectedsupportingDocId = undefined;
    }
  }

  // For Supporting Documents

  partyId = 1;
  PushPartyToGrid() {

    var insertObj: Party = {

    }
    if (this.partyGroup.valid) {
      insertObj = this.partyGroup.value;
      insertObj.LocalId = this.supDocId++
      insertObj.IsSelected = false;

      if (this.partyList.find(s => s.LocalId == this.selectedPartyId) == null) {
        this.partyList.push(Object.assign({}, insertObj));
      } else {

        this.partyList = this.partyList.filter(s => s.LocalId != this.selectedPartyId);
        insertObj.LocalId = this.selectedPartyId;
        this.partyList.push(Object.assign({}, insertObj));
        this.partyList = this.partyList.sort((a, b) => {
          return a.LocalId! - b.LocalId!;
        });
      }
      this.ClearPartyFields();

    }
  }

  SelectPartyRow(id: any) {
    this.partSaveBtn = "Update"
    this.selectedPartyId = id
    this.partyList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.partyList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedObj: any = this.partyList?.find(s => s.LocalId == id);
    this.selectedPartyId = selectedObj.LocalId;
    this.partyGroup.setValue(selectedObj);
  }

  ClearPartyFields() {
    this.partSaveBtn = "Add"
    this.partyList.forEach(x => x.IsSelected = false);

    this.selectedPartyId = 0;
    this.partyGroup.setValue({
      PartyType: true,
      IsApplicant: true,
      CompanyOrForeName: '',
      Surname: '',
      Roles: '',
      ViewModelRoles: [],
      LocalId: [0],
      IsSelected: [false],
      PartyId: 0,
      DocumentReferenceId: 0,
      DocumentReference: null,
    })
  }

  RemoveParty(id: any) {
    this.partyList = this.partyList.filter(x => x.LocalId != id);
    if (this.selectedPartyId == id) {
      this.selectedPartyId = undefined;
    }
  }

  // For Notes

  noteId = 1;
  PushNotesToGrid() {

    var insertObj: AttachmentNotes = {

    }

    if (this.notesGroup.valid) {
      insertObj = this.notesGroup.value;
      insertObj.LocalId = this.noteId++
      insertObj.IsSelected = false;

      if (this.notesList.find(s => s.LocalId == this.selectedNotesId) == null) {
        try {
          insertObj.MessageId = this.notesList[this.notesList.length - 1].MessageId! + 1;

        } catch (error) { }

        this.notesList.push(Object.assign({}, insertObj));
      } else {

        this.notesList = this.notesList.filter(s => s.LocalId != this.selectedNotesId);
        insertObj.LocalId = this.selectedNotesId;
        this.notesList.push(Object.assign({}, insertObj));
        this.notesList = this.notesList.sort((a, b) => {
          return a.LocalId! - b.LocalId!;
        });
      }
      this.ClearNotesFields();

    }
  }

  SelectNotesRow(id: any) {
    this.notesSaveBtn = "Update"
    this.selectedNotesId = id
    this.notesList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.notesList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedObj: any = this.notesList?.find(s => s.LocalId == id);
    this.selectedNotesId = selectedObj.LocalId;
    this.notesGroup.setValue(selectedObj);
  }

  ClearNotesFields() {
    this.notesSaveBtn = "Add"
    this.notesList.forEach(x => x.IsSelected = false);

    this.selectedNotesId = 0;
    this.notesGroup.setValue({
      AdditionalProviderFilter: '',
      MessageId: 1,
      ExternalReference: '',
      ApplicationMessageId: '',
      ApplicationService: '',
      Notes: '',
      AttachmentNotesId: 0,
      LocalId: [0],
      IsSelected: [false],
      DocumentReferenceId: 0,
      DocumentReference: null,
    })
  }

  RemoveNotes(id: any) {
    this.notesList = this.notesList.filter(x => x.LocalId != id);
    if (this.selectedNotesId == id) {
      this.selectedNotesId = undefined;
    }
  }


  UpdateDatabase() {

    if (this.documentReferenceGroup.valid) {
      let documentRef: DocumentReference = this.documentReferenceGroup.value;
      documentRef.Titles = JSON.parse(JSON.stringify(this.titleList));
      documentRef.Applications = JSON.parse(JSON.stringify(this.applicationList));
      documentRef.SupportingDocuments = JSON.parse(JSON.stringify(this.supportingDocList));
      documentRef.Parties = JSON.parse(JSON.stringify(this.partyList));
      documentRef.AttachmentNotes = JSON.parse(JSON.stringify(this.notesList));
      documentRef.RequestLogs = JSON.parse(JSON.stringify(this.logsList));

      if (this.docRefId == 0) {
        this.registrationService.CreateRegistration(documentRef).subscribe((res) => {
          this.ShowResponse(res);
        }, () => {
          this.toastr.error("Restriction, hostile takeover has not successfully updated", "Changes failed")

        });
      } else {
        this.registrationService.UpdateRegistration(documentRef).subscribe((res) => {
          this.ShowResponse(res);
        }, () => {
          this.toastr.error("Restriction, hostile takeover has not successfully updated", "Changes failed")

        });
      }
    } else {
      this.toastr.warning("Please fill all fields", "Fields missing")
    }
  }

  ShowResponse(res: any) {
    const dialogRef = this.dialog.open(ConfirmRegistrationComponent, {
      width: '550px',
      data: { res }
    });
    dialogRef.afterClosed().subscribe(() => {
    });
  }

  SendPoolRequest() {
    this.registrationService.GetPoolResponse(this.docRefId).subscribe(res => {
      // console.log()

      Swal.fire({
        title: 'Pool Response from Gateway',
        html: `
        
        ${res.Results[0].MessageDetails}
        `,
        icon: 'success',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Download Zip'
      }).then((result) => {
        if (result.isConfirmed) {
          console.log(res)
          FileSaver.saveAs(res.Results[0].DespatchDocument[0].byteArray!, res.Results[0].DespatchDocument[0].filename);

        }
      })

    });
  }

  DownloadAttachedPoll(item: RequestLogs) {
    FileSaver.saveAs(item.File!, "Att_" + item.RequestLogId + ".zip");
  }

}