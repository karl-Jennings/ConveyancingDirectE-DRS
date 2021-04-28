import { Component, OnInit } from '@angular/core';
import { HubConnection, HubConnectionBuilder } from '@microsoft/signalr';
import { environment } from 'src/environments/environment';
import { UserAccountService } from '../services/user-account.service';
import { User } from '../models/user';


@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html',
  styleUrls: ['./settings.component.css']
})
export class SettingsComponent implements OnInit {

  sliderTime = 1;

  private hubConnection!: HubConnection;
  private connectionUrl = environment.apiURL + 'settings/';

  allUsers:User[]=[];
  displayedColumns: string[] = ['Username','Firstname','Lastname' ,'Role','Action'];

  constructor(private userAccountService: UserAccountService) { }

  TriggerSlider() {
    this.hubConnection.invoke("CreatePollRequest", this.sliderTime).then(res => {

    })
  }

  async ngOnInit(): Promise<void> {

    this.hubConnection = new HubConnectionBuilder()
      .withUrl(this.connectionUrl)
      .withAutomaticReconnect()
      .build();

    await this.hubConnection.start()
      .then(async () => {
        await this.hubConnection.invoke("GetPollRequestMinute").then(data => {
          this.sliderTime = data
        })
      })
      .catch((err) => console.error(err))

    await this.hubConnection.on("GetPollRequestMinute", (data) => {
      this.sliderTime = data
    })

    this.GetAllUsers();
  }

  formatLabel(value: number) {
    if (value >= 1000) {
      return Math.round(value / 1000) + 'm';
    }

    return value;
  }

  //Get All Users

  GetAllUsers(){
  this.userAccountService.getAllUsers().subscribe(res => {
    this.allUsers = res;

    console.log('this.allUsers',this.allUsers);
  })
  }
}
