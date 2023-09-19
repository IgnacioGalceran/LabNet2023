import { Component } from '@angular/core';
import { DarkmodeService } from 'src/app/services/darkmode.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent {
  isDarkMode: boolean = false;

  constructor(private _darkmode: DarkmodeService) {
    this._darkmode.darkmode.subscribe((darkmode) => {
      this.isDarkMode = darkmode;
    });
  }

}
