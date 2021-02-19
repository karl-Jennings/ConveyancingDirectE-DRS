import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { Router, ActivatedRoute, ActivationStart, RouterOutlet } from '@angular/router';
import { fader, slider } from '../app/route-animation';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  animations: [
    slider
  ]
})
export class AppComponent implements OnInit {

  tabName = "FrontEnd";
  pathString = "Registration";

  isLoggedIn = localStorage.getItem('userId') !== '' && localStorage.getItem('userId') != undefined;

  constructor(
    private titleService: Title,
    private router: Router,
    private route: ActivatedRoute
  ) {

  }

  ngOnInit(): void {
    this.tabName = this.route.snapshot.data['variableName'];

    this.router.events.subscribe((val) => {
      if (val instanceof ActivationStart) {

        this.tabName = val.snapshot.data.title;
        this.titleService.setTitle("eDRS - " + this.tabName);
        this.pathString = val.snapshot.data.path;
      }
    });
  }

  prepareRoute(outlet: RouterOutlet) {
    return outlet && outlet.activatedRouteData && outlet.activatedRouteData['animation']
  }

  changeLoggedState(event: any) {
    this.isLoggedIn = event;

  }

  logOut() {
    localStorage.setItem('userId', "");
    localStorage.setItem('jwtToken', "");
    localStorage.setItem('fullName', "");
    this.isLoggedIn = false;
  }

}
