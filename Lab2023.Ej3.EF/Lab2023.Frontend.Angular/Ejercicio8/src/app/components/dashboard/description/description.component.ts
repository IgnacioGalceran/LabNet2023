import { Component } from '@angular/core';
import { DarkmodeService } from 'src/app/services/darkmode.service';

@Component({
  selector: 'app-description',
  templateUrl: './description.component.html',
  styleUrls: ['./description.component.css']
})
export class DescriptionComponent {
  isDarkMode: boolean = false;

  constructor(private _darkmode: DarkmodeService) {
    this._darkmode.darkmode.subscribe((darkmode) => {
      this.isDarkMode = darkmode;
    });
  }
}
