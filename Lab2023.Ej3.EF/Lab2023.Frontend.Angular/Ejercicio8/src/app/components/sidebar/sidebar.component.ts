import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DarkmodeService } from 'src/app/services/darkmode.service';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {
  sidebarOpen: boolean = true;
  isDarkMode: boolean = false;

  constructor(private _router: Router, private _darkmode: DarkmodeService) {
    this._darkmode.darkmode.subscribe((darkmode) => {
      this.isDarkMode = darkmode;
    });
  }

  toggleDiv() {
    const toggleContainer = document.getElementById('toggle-container');
    toggleContainer?.classList.toggle('visible');
  }

  toggleSidebar() {
    this.sidebarOpen = !this.sidebarOpen;
  }

  toggleDarkmode() {
    this._darkmode.toggleDarkmode();
  }


  homeRoute(): boolean {
    return this._router.url === '/home' || this._router.url === '/';
  }
}
