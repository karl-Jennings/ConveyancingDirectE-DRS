import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators, Form, FormGroupDirective } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
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
import { Representation } from '../models/representation';
import { Outstanding } from '../models/outstanding';
import { AttachmentService } from '../services/attachment.service';

@Component({
  selector: 'app-scenario',
  templateUrl: './scenario.component.html',
  styleUrls: ['./scenario.component.css']
})
export class ScenarioComponent implements OnInit {

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
  representationList: Representation[] = [];

  logsList: RequestLogs[] = [];
  outstandingList: Outstanding[] = [];

  txtTitle: FormControl = new FormControl();
  applicationGroup!: FormGroup;
  supportingDocGroup!: FormGroup;
  partyGroup!: FormGroup;
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
  @ViewChild("supportingDocumentfile") supportingDocumentfile: ElementRef | undefined;

  supportingDocumentFileObject: any = {};

  titleSaveBtn = "Add";
  appSaveBtn = "Add";
  supDocSaveBtn = "Add";
  partSaveBtn = "Add";
  notesSaveBtn = "Add";
  repSaveBtn = "Add";

  appType = 'other';
  repType = 'LodgingConveyancer';
  addressType = 'DXAddress';

  supDocType = 'supDoc';

  isOtherApplication = true;

  constructor(
    private dialog: MatDialog,
    private formBuilder: FormBuilder,
    private registrationService: RegistrationService,
    private attachmentServices: AttachmentService,
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
      TotalFeeInPence: ['', Validators.required],
      Email: ['', [Validators.required, Validators.email]],
      TelephoneNumber: ['', Validators.required],
      AP1WarningUnderstood: [true],
      ApplicationDate: [new Date().toISOString().substring(0, 10), Validators.required],
      DisclosableOveridingInterests: [true],
      ApplicationAffects: ['', Validators.required],
      RegistrationTypeId: [this.regType],
      PostcodeOfProperty: [''],
      LocalAuthority: [''],
      DocumentReferenceId: 0
    })

    // const _today = CommonUtils.formatDate();
    // this.documentReferenceGroup.controls.ApplicationDate.setValue(_today.toISOString().substring(0, 10););

    this.applicationGroup = this.formBuilder.group({
      Priority: [],
      Value: [],
      FeeInPence: [],
      Type: [''],
      LocalId: [0],
      IsSelected: [false],
      ApplicationFormId: 0,
      DocumentReferenceId: 0,
      CertifiedCopy: [''],
      ExternalReference: ['', Validators.required],
      Document: {},
      Variety: [this.appType],
      ChargeDate: [new Date().toISOString().substring(0, 10)],
      IsMdRef: ['yes'],
      MdRef: [''],
      SortCode: ['']
    });

    this.supportingDocGroup = this.formBuilder.group({
      CertifiedCopy: [],
      DocumentName: [],
      AdditionalProviderFilter: ['', Validators.required],
      MessageId: 1,
      ExternalReference: ['', Validators.required],
      ApplicationMessageId: ['', Validators.required],
      ApplicationService: ['104'],
      //ApplicationType: ['', Validators.required],

      DocumentType: [this.supDocType],

      FileName: [''],
      Base64: [''],
      FileExtension: [''],

      Notes: [''],

      LocalId: [0],
      IsSelected: [false],
      SupportingDocumentId: 0,
      DocumentReferenceId: 0
    });

    this.representationGroup = this.formBuilder.group({
      RepresentationId: [0],
      Type: ['LodgingConveyancer'],
      RepresentativeId: [1, Validators.required],
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

        this.logsList = res.RequestLogs ?? [];
        this.outstandingList = res.Outstanding ?? [];

        this.representationList = res.Representations ?? [];

        this.representationList.forEach(s => {
          s.LocalId = this.appId++;
        })

      })
    }

    this.applicationGroup.get('Variety')?.valueChanges.subscribe(res => {
      this.appType = res

    })

    this.supportingDocGroup.get('DocumentType')?.valueChanges.subscribe(res => {
      this.supDocType = res

    })

    this.applicationGroup.get('IsMdRef')?.valueChanges.subscribe(res => {

      if (res == 'yes') {
        this.applicationGroup.controls.MdRef.enable();
      } else {
        this.applicationGroup.controls.MdRef.disable();
        this.applicationGroup.controls.MdRef.setValue("");
      }
    })

    this.partyGroup.get('PartyType')?.valueChanges.subscribe(res => {
      this.partyType = res
    })

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


    // set validations in Support documents form based on selected Attachment Type
    this.onAttcmntTypeChange();
  }

  partyType = 'company';

  // Title Numbers

  titleId = 1;
  PushTitleToGrid() {

    var insertObj: TitleNumber = {
      LocalId: this.titleId++,
      TitleNumberCode: this.txtTitle.value,
      IsSelected: false,
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
  PushApplicationToGrid(formDirective: FormGroupDirective) {

    var insertObj: ApplicationForm = {

    }

    debugger;
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

          that.InsertDataToAppList(insertObj, documents, formDirective);


        };
        reader.onerror = function (error) {
          console.log('Error: ', error);
        };
      } else if (insertObj.Document?.DocumentId != null) {
        this.InsertDataToAppList(insertObj, insertObj.Document, formDirective);
      }
    }
  }

  InsertDataToAppList(insertObj: ApplicationForm, documents: Document, formDirective: FormGroupDirective) {
    insertObj.Document = documents;
    if (this.applicationList.find(s => s.LocalId == this.selectedApplicationId) == null) {

      if (this.applicationList.length == 0) {

        insertObj.Priority = 1;

      } else {

        insertObj.Priority = this.applicationList[this.applicationList.length - 1].Priority! + 1;
      }

      this.applicationList.push(Object.assign({}, insertObj));

    } else {
      this.applicationList = this.applicationList.filter(s => s.LocalId != this.selectedApplicationId);
      insertObj.LocalId = this.selectedApplicationId;
      this.applicationList.push(Object.assign({}, insertObj));
      this.applicationList = this.applicationList.sort((a, b) => {
        return a.LocalId! - b.LocalId!;
      });
    }
    this.ClearAppFields(formDirective);
  }

  SelectAppRow(id: any) {
    this.appSaveBtn = "Update"
    this.selectedApplicationId = id
    this.applicationList.filter(x => x.LocalId == id).forEach(x => x.IsSelected = true);
    this.applicationList.filter(x => x.LocalId != id).forEach(x => x.IsSelected = false);

    var selectedObj: ApplicationForm = this.applicationList.find(s => s.LocalId == id)!;
    this.selectedApplicationId = selectedObj.LocalId;
    this.applicationGroup.setValue(selectedObj);
    this.fileName = ""
    this.fileName = selectedObj.Document!.FileName;

  }

  ClearAppFields(formDirective: FormGroupDirective) {
    this.appSaveBtn = "Add"

    this.applicationList.forEach(x => x.IsSelected = false);
    this.selectedApplicationId = 0;
    this.fileName = "Choose File";


    formDirective.resetForm();
    this.applicationGroup.reset();


    // this.applicationGroup.patchValue({
    //   Priority: 1,
    //   Value: '',
    //   FeeInPence: null,
    //   Type: '',
    //   LocalId: 0,
    //   IsSelected: false,
    //   ApplicationFormId: 0,
    //   DocumentReferenceId: 0,

    //   Document: [],
    //   ExternalReference: '',
    //   Variety: 'other',
    //   MDRef: '',
    //   ChargeDate: new Date().toISOString().substring(0, 10),
    //   IsMdRef: 'yes',
    //   SortCode: ''
    // })
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


  //handle application varity change event
  VarietyChange(value: any) {

    console.log('change value:', value);

    if (value == 'other') {
      this.isOtherApplication = true;
      this.applicationGroup.controls['Type'].setValidators([Validators.required]);
    } else {
      this.isOtherApplication = false;
      this.applicationGroup.controls['Type'].clearValidators();
      this.applicationGroup.controls['Type'].updateValueAndValidity();
    }

  }

  DownloadAttached(item: ApplicationForm) {
    FileSaver.saveAs(item.Document?.Base64!, item.Document?.FileName);
  }


  // For Supporting Documents
  supDocfileName: any = "Choose files";
  supDocId = 1;

  async PushSupDocumentToGrid() {

    var insertObj: SupportingDocuments = {

    }

    if (this.supportingDocGroup.valid) {
      insertObj = this.supportingDocGroup.value;
      insertObj.LocalId = this.supDocId++
      insertObj.IsSelected = false;


      if (insertObj.DocumentType == "supDoc") {
        insertObj.FileName = this.supportingDocumentFileObject.FileName;
        insertObj.Base64 = this.supportingDocumentFileObject.Base64;
        insertObj.FileExtension = this.supportingDocumentFileObject.FileExtension;
      }

      if (this.supportingDocList.find(s => s.LocalId == this.selectedsupportingDocId) == null) {
        // insertObj.MessageId = this.supportingDocList[this.supportingDocList.length - 1].MessageId! + 1;
        insertObj.MessageId = 1;
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
    this.supDocfileName = "Choose File";

    this.supportingDocList.forEach(x => x.IsSelected = false);

    this.selectedsupportingDocId = 0;
    this.supportingDocGroup.patchValue({
      CertifiedCopy: [],
      DocumentName: [],
      LocalId: [0],
      IsSelected: [false],
      SupportingDocumentId: 0,
      DocumentReferenceId: 0,

      AdditionalProviderFilter: '',
      MessageId: 1,
      ExternalReference: '',
      ApplicationMessageId: '',
      ApplicationService: '104',
      //ApplicationType: '',

      DocumentType: [this.supDocType],

      FileName: [''],
      Base64: [''],
      FileExtension: [''],

      Notes: [''],

    })
  }

  RemoveSupDoc(id: any) {
    this.supportingDocList = this.supportingDocList.filter(x => x.LocalId != id);
    if (this.selectedsupportingDocId == id) {
      this.selectedsupportingDocId = undefined;
    }
  }

  uploadSupDocFile() {

    this.supDocfileName = "";
    var fileToUpload: any = this.supportingDocumentfile!.nativeElement.files[0];


    /**** Uploading file if the type is Supporting Document */

    var that = this;
    if (fileToUpload != undefined) {
      this.supDocfileName = fileToUpload.name;
      let fileName = this.supDocfileName.split('.').slice(0, -1).join('.')
      let fileString: any = "";
      let reader = new FileReader();
      reader.readAsDataURL(fileToUpload);
      reader.onload = function () {
        fileString = reader.result;
        let fileExtension = fileToUpload.name.substr(
          fileToUpload.name.lastIndexOf(".") + 1
        );

        that.supportingDocumentFileObject.FileName = fileName;
        that.supportingDocumentFileObject.Base64 = fileString;
        that.supportingDocumentFileObject.FileExtension = fileExtension;

      };
      reader.onerror = function (error) {
        console.log('Error: ', error);
      };
    }

  }

  /********* For Supporting Documents End ************/

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

    })
  }

  RemoveParty(id: any) {
    this.partyList = this.partyList.filter(x => x.LocalId != id);
    if (this.selectedPartyId == id) {
      this.selectedPartyId = undefined;
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
        try {

          insertObj.RepresentativeId = this.representationList[this.representationList.length - 1].RepresentativeId! + 1;

        } catch (error) { }

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

    this.representationGroup.controls.Type.setValue("LodgingConveyancer");
  }

  RemoveRep(id: any) {
    this.representationList = this.representationList.filter(x => x.LocalId != id);
    if (this.selectedRepId == id) {
      this.selectedRepId = undefined;
    }
  }

  UpdateDatabase() {

    let documentRef: DocumentReference = this.documentReferenceGroup.value;
    documentRef.Titles = JSON.parse(JSON.stringify(this.titleList));
    documentRef.Applications = JSON.parse(JSON.stringify(this.applicationList));
    documentRef.SupportingDocuments = JSON.parse(JSON.stringify(this.supportingDocList));
    documentRef.Representations = JSON.parse(JSON.stringify(this.representationList));
    documentRef.Parties = JSON.parse(JSON.stringify(this.partyList));
    documentRef.RequestLogs = JSON.parse(JSON.stringify(this.logsList));
    documentRef.UserId = parseInt(localStorage.getItem("userId")!);

    if (documentRef.Titles?.length! < 1) {
      this.toastr.warning("Please add at least one Title", "Fields missing")
    } else if (documentRef.Applications?.length! < 1) {
      this.toastr.warning("Please add at least one Application", "Fields missing")
    } else if (documentRef.SupportingDocuments?.length! < 1) {
      this.toastr.warning("Please add at least one Supporting Document", "Fields missing")
    } else if (documentRef.Representations?.length! < 1) {
      this.toastr.warning("Please add at least one Representation", "Fields missing")
    } else if (documentRef.Parties?.length! < 1) {
      this.toastr.warning("Please add at least one Party", "Fields missing")
    } else if (documentRef.Representations?.filter(s => s.Type == "LodgingConveyancer").length! < 1) {
      this.toastr.warning("Please add at least one Lodging Conveyancer", "Fields missing")
    } else if (this.documentReferenceGroup.valid) {

      if (this.docRefId == 0) {
        this.registrationService.CreateRegistration(documentRef).subscribe((res) => {
          this.ShowResponse(res);
        }, () => {
          this.toastr.error("Restriction, hostile takeover has not successfully updated", "Changes failed");

        });
      } else {
        this.registrationService.UpdateRegistration(documentRef).subscribe((res) => {
          this.ShowResponse(res);
        }, () => {
          this.toastr.error("Restriction, hostile takeover has not successfully updated", "Changes failed");
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
    this.registrationService.GetPoolResponse(this.docRefId).subscribe((res: RequestLogs) => {
      // console.log()
      Swal.fire({
        title: 'Poll Response from Gateway',
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
          FileSaver.saveAs(res.File!, res.FileName + "." + res.FileExtension?.toLowerCase());
        }
      })
    });
  }

  DownloadAttachedPoll(item: RequestLogs) {
    this.attachmentServices.GetAttachment(item.RequestLogId!).subscribe(res => {
      FileSaver.saveAs(res!, item.FileName + "." + item.FileExtension?.toLowerCase());

    })
  }

  CollectAttachmentResult() {
    this.registrationService.CollectAttachmentResult(this.docRefId, "70").subscribe(res => {
      // console.log()
      // Swal.fire({
      //   title: 'Pool Response from Gateway',
      //   html: `
      //   ${res.Description}
      //   `,
      //   icon: 'success',
      //   showCancelButton: true,
      //   confirmButtonColor: '#3085d6',
      //   cancelButtonColor: '#d33',
      //   confirmButtonText: 'Download Zip'
      // }).then((result) => {
      //   if (result.isConfirmed) {
      //     console.log(res)
      //     FileSaver.saveAs(res.File);
      //   }
      // })
      if (res.Successful)
        this.toastr.success("Please refresh the page to view the results", "Attachment Results collected")
      else
        this.toastr.error("Something went wrong while collecting results", "Attachment Results Error")

    });
  }

  FindRequisitions() {
    this.registrationService.GetRequisition(this.docRefId, "70").subscribe(res => {

      if (res != false) {
        if (res.IsSuccess)
          this.toastr.success("Please refresh the page to view the results", "Requisition Results collected")
        else
          this.toastr.error("Something went wrong while collecting results", "Requisition Results Error")

      } else {
        this.toastr.error("Something went wrong while collecting results", "Requisition Results Error")

      }

    });
  }

  ReplyAttachments() {
    this.registrationService.ReplyAttachments(this.docRefId).subscribe(res => {

      if (res != false) {
        if (res.IsSuccess)
          this.toastr.success("Please refresh the page to view the results", "Replied to Attachments")
        else
          this.toastr.error("Something went wrong while replying to results", "Attachments Results Error")

      } else {
        this.toastr.error("Something went wrong while replying to results", "Attachments Results Error")

      }

    });
  }

  CollectFinalResults() {
    this.registrationService.CollectFinalResults(this.docRefId, "70").subscribe(res => {

      if (res != false) {
        if (res.IsSuccess)
          this.toastr.success("Please refresh the page to view the results", "Requisition Results collected")
        else
          this.toastr.error("Something went wrong while collecting results", "Requisition Results Error")

      } else {
        this.toastr.error("Something went wrong while collecting results", "Requisition Results Error")

      }

    });
  }

  onAttcmntTypeChange() {

    console.log("this.supDocType", this.supDocType);

    if (this.supDocType == "supDoc") {

      this.supportingDocGroup.get('DocumentName')?.setValidators([Validators.required]);

      this.supportingDocGroup.get('CertifiedCopy')?.setValidators([Validators.required]);

    } else {

      this.supportingDocGroup.get('DocumentName')?.clearValidators();
      this.supportingDocGroup.controls['DocumentName'].updateValueAndValidity();

      this.supportingDocGroup.get('CertifiedCopy')?.clearValidators();
      this.supportingDocGroup.controls['CertifiedCopy'].updateValueAndValidity();

    }
  }
}
