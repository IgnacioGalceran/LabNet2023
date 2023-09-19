import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DarkmodeService {
  private darkmodeSubject = new BehaviorSubject<boolean>(false);
  darkmode = this.darkmodeSubject.asObservable();

  constructor() {
    const isDarkMode = localStorage.getItem('isDarkMode');
    this.darkmodeSubject.next(isDarkMode === 'true');
  }

  toggleDarkmode() {
    const currentMode = this.darkmodeSubject.value;
    this.darkmodeSubject.next(!currentMode);
    localStorage.setItem('isDarkMode', this.darkmodeSubject.value.toString());
  }
}
