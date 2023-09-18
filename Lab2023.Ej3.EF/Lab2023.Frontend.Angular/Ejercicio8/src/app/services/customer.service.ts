import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Customer } from '../components/dashboard/customers/customers.interface';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
  private _apiUrl = 'https://localhost:44393/api/customer';

  constructor(private _http: HttpClient) {}

  getCustomers(): Observable<Customer[]> {
    return this._http.get<Customer[]>(this._apiUrl);
  }

  getCustomerById(id: string): Observable<Customer> {
    return this._http.get<Customer>(`${this._apiUrl}/${id}`)
  }

  insertCustomer(customer: Customer): Observable<any> {
    return this._http.post<Customer>(this._apiUrl, customer);
  }

  updateCustomer(id: string, customer: Customer): Observable<any> {
    return this._http.put<any>(`${this._apiUrl}/${id}`, customer);
  }

  deleteCustomer(id: string): Observable<any> {
    return this._http.delete<any>(`${this._apiUrl}/${id}`);
  }

}
