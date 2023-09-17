import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../customers.interface';
import { MatSnackBar } from '@angular/material/snack-bar';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  title: string = 'Agregar cliente';
  url: string = 'https://localhost:44393/api/customer/';
  hasId: boolean = false;
  customerId: string | null = null;
  loading: boolean = true;
  customerForm: FormGroup;
  errorMessages = {
    required: 'Este campo es obligatorio',
    minLength: 'Mínimo 1 caracter',
    maxLength: 'Máximo 30 caracteres',
    pattern: 'El formato es inválido',
  };

  constructor(private _route: ActivatedRoute, private _http: HttpClient, private _fb: FormBuilder, private _snackBar: MatSnackBar) {
    this.customerForm = this._fb.group({
      ContactName: ['', [
        Validators.required,
        Validators.maxLength(30),
        Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ.\s-_]+$/)
      ]],
      CompanyName: ['', [
        Validators.required,
        Validators.maxLength(30),
        Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ.\s-_]+$/)
      ]],
      City: ['', [
        Validators.required,
        Validators.maxLength(15),
        Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ.\s-_]+$/)
      ]]
    });
  }

  ngOnInit(): void {
    this._route.params.subscribe(params => {
      this.customerId = params['id'];

      this.hasId = !!this.customerId;

      if (this.hasId && this.customerId !== null) {
        this.getCustomerData(this.customerId);
        this.title = 'Actualizar cliente';
      }
    });
  }

  getCustomerData(id: string) {
    this._http.get<Customer>(`${this.url}/${id}`).subscribe(
      (data) => {
        this.customerForm.setValue({
          ContactName: data.ContactName,
          CompanyName: data.CompanyName, 
          City: data.City,   
        });
      },
      (error) => {
        this.toast(`Error al obtener los datos: ${error.message.toString()}`);
      }
    ).add(() => {
      this.loading = false;
    });
  }

  toast(msg: string) {
    this._snackBar.open(msg, 'Cerrar', {
      duration: 2500
    });
  }

  handleClick(id: string) {
    Swal.fire({
      title: 'Estás seguro?',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: `Si, ${id ? 'actualizar' : 'agregar'}!`
    }).then((result) => {
      if (result.isConfirmed) {
        if (id) {
          this.confirmRequest(id);
        } else {
          this.confirmRequest();
        }
      }
    })
  }
  
  confirmRequest(id?: string) {
    this.loading = true;
    let httpObservable;

    if (id) {
      httpObservable = this._http.put<any>(`${this.url}/${id}`, this.customerForm.value);
    } else {
      httpObservable = this._http.post<any>(this.url, this.customerForm.value);
    }

    httpObservable.subscribe(
      (data) => {
          this.toast(data.message);
      },
      (error) => {
        this.toast(`Error al actualizar: ${error.message.toString()}`);
      }
    ).add(() => {
      this.loading = false;
    });
  }

}

