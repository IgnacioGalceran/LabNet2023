import { Component } from '@angular/core';
import { WeatherService } from 'src/app/services/weather.service';
import { ToastService } from 'src/app/services/toast.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DarkmodeService } from 'src/app/services/darkmode.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent {
  API_KEY: string = 'b4f008b21480401b9dd124341231309';
  urlNominatim: string = 'https://nominatim.openstreetmap.org/search';
  loading: boolean = false;
  isDarkMode: boolean = false;
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

  constructor(
    private _fb: FormBuilder, 
    private _wheatherService: WeatherService, 
    private _toastService: ToastService,
    private _darkmode: DarkmodeService
    ) {

    this._darkmode.darkmode.subscribe((darkmode) => {
      this.isDarkMode = darkmode;
    }); 

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
    this._wheatherService.getCity(this.location.value.Location).subscribe(
      (data: any[]) => {
        if (data && data.length > 0) {
          const latitud = data[0].lat;
          const longitud = data[0].lon;
            this._wheatherService.getWeatherToday(latitud, longitud).subscribe(
              (data) => {     
                this.weatherDay = data;
                this.fetchedDay = true;
              },
              (error) => {
                this._toastService.notification(error.toString(), 2500);
              }
            );
            this._wheatherService.getWeatherWeek(latitud, longitud).subscribe(
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
                this._toastService.notification(error.toString(), 2500);
              }
            ).add(() => {
              this.loading = false;
            })
        }
      },
      (error) => {
        this._toastService.notification(error.toString(), 2500);
      }
    )
  }

  restart() {
    this.fetchedDay = false;
    this.fetchedWeek = false;
    this.location.reset();
  }

}
