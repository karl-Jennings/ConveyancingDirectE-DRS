import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { ConfirmRegistrationComponent } from '../angular-dialogs/confirm-registration/confirm-registration.component';
import { ApplicationForm, Document } from '../models/application-form';
import { DocumentReference } from '../models/document-reference';
import { Party } from '../models/party';
import { SupportingDocuments } from '../models/supporting-documents';
import { TitleNumber } from '../models/title-number';
import { RegistrationService } from '../services/registration.service';
import * as FileSaver from 'file-saver';
import Swal from 'sweetalert2';
import { AttachmentNotes } from '../models/attachment-notes';
import { RequestLogs } from '../models/request-logs';
import { Representation } from '../models/representation';

@Component({
  selector: 'app-transfer-of-equity',
  templateUrl: './transfer-of-equity.component.html',
  styleUrls: ['./transfer-of-equity.component.css']
})
export class TransferOfEquityComponent implements OnInit {

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
  representationList: Representation[] = [];

  txtTitle: FormControl = new FormControl();
  applicationGroup!: FormGroup;
  supportingDocGroup!: FormGroup;
  partyGroup!: FormGroup;
  notesGroup!: FormGroup;
  representationGroup!: FormGroup;

  selectedTitleNumber: number | undefined;
  selectedApplicationId: number | undefined;
  selectedsupportingDocId: number | undefined;
  selectedPartyId: number | undefined;
  selectedNotesId: number | undefined;
  selectedRepId: number | undefined;

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
  repSaveBtn = "Add";

  partyType = 'company';
  repType = 'LodgingConveyancer';
  addressType = 'DXAddress';

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
      TelephoneNumber: [0, Validators.required],
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
      Variety: ['other'],
      Type: [''],
      LocalId: [0],
      IsSelected: [false],
      ApplicationFormId: 0,
      DocumentReferenceId: 0,

      CertifiedCopy: [''],
      ExternalReference: ['', Validators.required],
      Document: {},
      ChargeDate: [new Date().toISOString().substring(0, 10), Validators.required],
      MDRef: ['']
    });

    this.supportingDocGroup = this.formBuilder.group({
      CertifiedCopy: ['', Validators.required],
      DocumentId: ['', Validators.required],
      DocumentName: ['', Validators.required],
      LocalId: [0],
      IsSelected: [false],
      SupportingDocumentId: 0,
      DocumentReferenceId: 0,

    });

    this.partyGroup = this.formBuilder.group({
      PartyType: [true],
      IsApplicant: [true],
      CompanyOrForeName: ['', Validators.required],
      Surname: [''],
      Roles: [''],
      AddressForService: ['', Validators.required],
      ViewModelRoles: [[], Validators.required],
      LocalId: [0],
      IsSelected: [false],
      PartyId: 0,
      DocumentReferenceId: 0,

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

    });

    this.representationGroup = this.formBuilder.group({
      RepresentationId: [0],
      Type: ['LodgingConveyancer'],
      RepresentativeId: [0, Validators.required],
      Name: [''],
      Reference: [''],
      AddressType: ['DXAddress'],

      LocalId: [0],
      IsSelected: [false],
      DocumentReferenceId: 0,


      CareOfName: [''],
      CareOfReference: [''],

      DxNumber: [0],
      DxExchange: [''],

      AddressLine1: [''],
      AddressLine2: [''],
      AddressLine3: [''],
      AddressLine4: [''],
      City: [''],
      County: [''],
      Country: [''],
      PostCode: ['']

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

        this.representationList = res.Representations ?? [];

        this.representationList.forEach(s => {
          s.LocalId = this.appId++;
        })

        this.logsList = res.RequestLogs ?? [];

      })
    }

    this.representationGroup.get('Type')?.valueChanges.subscribe(res => {
      this.repType = res

      this.representationGroup.controls['Name'].clearValidators();
      this.representationGroup.controls['Name'].updateValueAndValidity();

      this.representationGroup.controls['Reference'].clearValidators();
      this.representationGroup.controls['Reference'].updateValueAndValidity();
      this.representationGroup.controls['CareOfName'].clearValidators();
      this.representationGroup.controls['CareOfName'].updateValueAndValidity();
      this.representationGroup.controls['CareOfReference'].clearValidators();
      this.representationGroup.controls['CareOfReference'].updateValueAndValidity();
      this.representationGroup.controls['DxNumber'].clearValidators();
      this.representationGroup.controls['DxNumber'].updateValueAndValidity();
      this.representationGroup.controls['DxExchange'].clearValidators();
      this.representationGroup.controls['DxExchange'].updateValueAndValidity();
      this.representationGroup.controls['AddressLine1'].clearValidators();
      this.representationGroup.controls['AddressLine1'].updateValueAndValidity();

      if (res != 'LodgingConveyancer') {
        this.representationGroup.controls['Name'].setValidators([Validators.required]);
        this.representationGroup.controls['Reference'].setValidators([Validators.required]);
        this.representationGroup.controls['CareOfName'].setValidators([Validators.required]);
        this.representationGroup.controls['CareOfReference'].setValidators([Validators.required]);

        if (this.representationGroup.controls['AddressType'].value == 'DXAddress') {
          this.representationGroup.controls['DxNumber'].setValidators([Validators.required]);
          this.representationGroup.controls['DxExchange'].setValidators([Validators.required]);
        } else {
          this.representationGroup.controls['AddressLine1'].setValidators([Validators.required]);
        }
      }

    })

    this.representationGroup.get('AddressType')?.valueChanges.subscribe(res => {
      this.addressType = res

      this.representationGroup.controls['DxNumber'].clearValidators();
      this.representationGroup.controls['DxNumber'].updateValueAndValidity();
      this.representationGroup.controls['DxExchange'].clearValidators();
      this.representationGroup.controls['DxExchange'].updateValueAndValidity();
      this.representationGroup.controls['AddressLine1'].clearValidators();
      this.representationGroup.controls['AddressLine1'].updateValueAndValidity();

      if (res == 'DXAddress') {
        this.representationGroup.controls['DxNumber'].setValidators([Validators.required]);
        this.representationGroup.controls['DxExchange'].setValidators([Validators.required]);
      } else if (res == 'PostalAddress') {
        this.representationGroup.controls['AddressLine1'].setValidators([Validators.required]);
      }
    })

  }


  // Title Numbers

  titleId = 1;
  PushTitleToGrid() {

    var insertObj: TitleNumber = {
      LocalId: this.titleId++,
      TitleNumberCode: this.txtTitle.value,
      IsSelected: false
    }
    if (this.txtTitle.valid) {
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

      Document: [],
      ExternalReference: '',
      Variety: 'other',
      ChargeDate: new Date().toISOString().substring(0, 10),
      MDRef: ''
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

    })
  }

  RemoveSupDoc(id: any) {
    this.supportingDocList = this.supportingDocList.filter(x => x.LocalId != id);
    if (this.selectedsupportingDocId == id) {
      this.selectedsupportingDocId = undefined;
    }
  }

  // For Parties

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
      AddressForService: '',
      ViewModelRoles: [],
      LocalId: [0],
      IsSelected: [false],
      PartyId: 0,
      DocumentReferenceId: 0,

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

    })
  }

  RemoveNotes(id: any) {
    this.notesList = this.notesList.filter(x => x.LocalId != id);
    if (this.selectedNotesId == id) {
      this.selectedNotesId = undefined;
    }
  }


  // For Representation and Additional Parties

  repId = 1;
  PushRepToGrid() {

    var insertObj: Representation = {

    }
    if (this.representationGroup.valid) {
      insertObj = this.representationGroup.value;
      insertObj.LocalId = this.repId++
      insertObj.IsSelected = false;

      if (this.representationList.find(s => s.LocalId == this.selectedRepId) == null) {
        this.representationList.push(Object.assign({}, insertObj));
      } else {

        this.representationList = this.representationList.filter(s => s.LocalId != this.selectedRepId);
        insertObj.LocalId = this.selectedRepId;
        this.representationList.push(Object.assign({}, insertObj));
        this.representationList = this.representationList.sort((a, b) => {
          return a.LocalId! - b.LocalId!;
        });
      }
      this.ClearRepFields();

    }
  }

  SelectRepRow(id: any) {
    this.repSaveBtn = "Update"
    this.selectedRepId = id
    this.representationList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.representationList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedObj: any = this.representationList?.find(s => s.LocalId == id);
    this.selectedRepId = selectedObj.LocalId;
    this.representationGroup.setValue(selectedObj);
  }

  ClearRepFields() {
    this.repSaveBtn = "Add"

    this.representationList.forEach(x => x.IsSelected = false);

    this.selectedRepId = 0;
    this.representationGroup.patchValue({
      RepresentationId: 0,
      Type: 'LodgingConveyancer',
      RepresentativeId: 0,
      Name: '',
      Reference: '',
      AddressType: 'DXAddress',
      LocalId: [0],
      IsSelected: [false],
      DocumentReferenceId: 0,


      CareOfName: '',
      CareOfReference: '',

      DxNumber: 0,
      DxExchange: '',

      AddressLine1: '',
      AddressLine2: '',
      AddressLine3: '',
      AddressLine4: '',
      City: '',
      County: '',
      Country: '',
      PostCode: '',
    })
  }

  RemoveRep(id: any) {
    this.representationList = this.representationList.filter(x => x.LocalId != id);
    if (this.selectedRepId == id) {
      this.selectedRepId = undefined;
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
      documentRef.Representations = JSON.parse(JSON.stringify(this.representationList));
      documentRef.UserId = parseInt(localStorage.getItem("userId")!);

      if (this.docRefId == 0) {
        this.registrationService.CreateRegistration(documentRef).subscribe((res) => {
          this.ShowResponse(res);
        }, () => {
          this.toastr.error("Transfer of charge has not successfully updated", "Changes failed")

        });
      } else {
        this.registrationService.UpdateRegistration(documentRef).subscribe((res) => {
          this.ShowResponse(res);
        }, () => {
          this.toastr.error("Transfer of charge has not successfully updated", "Changes failed")

        });
      }
    } else {
      this.toastr.warning("Please fill all fields", "Fields missing")
    }
  }

  ShowResponse(res: any) {
    if (res.IsSuccess) {
      const dialogRef = this.dialog.open(ConfirmRegistrationComponent, {

        data: { res }
      });
      dialogRef.afterClosed().subscribe(() => {
      });
    } else {
      this.toastr.error("There was an error occured while trying to connect, please check all fields again", "Error sending request")
    }
  }

  SendPoolRequest() {
    this.registrationService.GetPoolResponse(this.docRefId).subscribe(res => {
      // console.log()
      Swal.fire({
        title: 'Pool Response from Gateway',
        html: `
        ${res.Description}
        `,
        icon: 'success',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Download Zip'
      }).then((result) => {
        if (result.isConfirmed) {
          console.log(res)
          FileSaver.saveAs(res.File);
        }
      })

    });
  }

  DownloadAttachedPoll(item: RequestLogs) {
    FileSaver.saveAs(item.File!, "Att_" + item.RequestLogId + ".zip");
  }

}
