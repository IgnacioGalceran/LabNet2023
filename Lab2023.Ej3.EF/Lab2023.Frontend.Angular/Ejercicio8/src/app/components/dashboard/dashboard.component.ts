import { Component } from '@angular/core';
import { DarkmodeService } from 'src/app/services/darkmode.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  isDarkMode: boolean = false;

  constructor(private _darkmode: DarkmodeService) {
    this._darkmode.darkmode.subscribe((darkmode) => {
      this.isDarkMode = darkmode;
    });
  }

}
