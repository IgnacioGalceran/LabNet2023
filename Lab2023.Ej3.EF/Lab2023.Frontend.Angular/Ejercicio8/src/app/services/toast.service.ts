import { Injectable } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';

@Injectable({
  providedIn: 'root'
})
export class ToastService {

  constructor(private _snackBar: MatSnackBar) { }

  notification(msg: string, duration: number) {
    this._snackBar.open(msg, 'Cerrar', {
      duration
    });
  }
}
