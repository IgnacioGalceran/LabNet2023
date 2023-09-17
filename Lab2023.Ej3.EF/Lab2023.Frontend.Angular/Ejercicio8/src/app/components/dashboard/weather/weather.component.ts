import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatSnackBar } from '@angular/material/snack-bar';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent {
  API_KEY: string = 'b4f008b21480401b9dd124341231309';
  urlNominatim: string = 'https://nominatim.openstreetmap.org/search';
  loading: boolean = false;
  fetchedDay: boolean = false;
  fetchedWeek: boolean = false;
  dayNames: Array<any> = [];
  weatherDay: any = {};
  weatherWeek: Array<any> = [];
  location: FormGroup;
  errorMessages = {
    required: 'Este campo es obligatorio',
    minLength: 'Mínimo 2 caracteres',
    maxLength: 'Máximo 30 caracteres',
    pattern: 'El formato es inválido',
  };

  constructor(private _http: HttpClient,  private _fb: FormBuilder, private _snackBar: MatSnackBar) {
    this.location = this._fb.group({
      Location: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(30),
        Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ.\s-_]+$/)
      ]]
    });
  }

  handleClick() {
    this.loading = true;
    this._http.get<[]>(`${this.urlNominatim}?addressdetails=1&q=${this.location.value.Location}&format=jsonv2&limit=1`).subscribe(
      (data: any[]) => {
        if (data && data.length > 0) {
          const latitud = data[0].lat;
          const longitud = data[0].lon;
          const urlToday = `https://api.weatherapi.com/v1/current.json?key=${this.API_KEY}&q=${latitud},${longitud}`
          const urlWeek = `https://api.weatherapi.com/v1/forecast.json?key=${this.API_KEY}&q=${latitud},${longitud}&days=8`;
            this._http.get<any>(`${urlToday}`).subscribe(
              (data) => {     
                this.weatherDay = data;
                this.fetchedDay = true;
              },
              (error) => {
                this.toast(error.toString());
              }
            );

            this._http.get<any>(urlWeek).subscribe(
              (data) => {
                this.weatherWeek = data.forecast.forecastday.slice(1);
                this.weatherWeek.forEach((d, index) => {
                  const date = new Date(d.date);
                  const dayName = date.toLocaleDateString("es-ES", { weekday: 'long', timeZone: 'America/Argentina/Buenos_Aires' });
                  const dayNumber = date.getDate();
                  this.dayNames[index] = `${dayName} ${dayNumber}`;
                });
                this.fetchedWeek = true;
              },
              (error) => {
                this.toast(error.toString());
              }
            ).add(() => {
              this.loading = false;
            })
        }
      },
      (error) => {
        this.toast(error.toString());
      }
    )
  }

  restart() {
    this.fetchedDay = false;
    this.fetchedWeek = false;
  }

  toast(msg: string) {
    this._snackBar.open(msg, 'Cerrar', {
      duration: 2500
    });
  }

}
