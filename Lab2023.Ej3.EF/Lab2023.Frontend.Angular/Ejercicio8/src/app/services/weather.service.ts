import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { env } from 'src/environment/environment';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {
  urlNominatim: string = env.NOMINATIM_URL;
  urlWeather: string = env.WEATHER_URL;
  API_KEY: string = env.WEATHER_KEY;
  
  constructor(private _http: HttpClient) {}

  getCity(location: string): Observable<any> {
    return this._http.get(`${this.urlNominatim}?addressdetails=1&q=${location}&format=jsonv2&limit=1`)
  }

  getWeatherToday(latitud: string, longitud: string): Observable<any> {
    const urlDay = `${this.urlWeather}/current.json?key=${this.API_KEY}&q=${latitud},${longitud}`;
    return this._http.get(urlDay);
  }

  getWeatherWeek(latitud: string, longitud: string): Observable<any> {
    const urlWeek = `${this.urlWeather}/forecast.json?key=${this.API_KEY}&q=${latitud},${longitud}&days=8`;
    return this._http.get(urlWeek);
  }
}
