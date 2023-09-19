import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CustomerService } from 'src/app/services/customer.service';
import { ToastService } from 'src/app/services/toast.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { DarkmodeService } from 'src/app/services/darkmode.service';
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
  isDarkMode: boolean = false;
  customerForm: FormGroup;
  errorMessages = {
    ContactName: {
      required: 'Este campo es obligatorio',
      minLength: 'Mínimo 2 caracteres',
      maxLength: 'Se superó el máximo de 40 caracteres',
      pattern: 'El nombre debe contener al menos un espacio en el medio. Sólo letras y espacios',
    },
    CompanyName: {
      required: 'Este campo es obligatorio',
      minLength: 'Mínimo 2 caracteres',
      maxLength: 'Se superó el máximo de 30 caracteres',
      pattern: 'El formato es inválido. Sólo letras y espacios',
    },
    City: {
      required: 'Este campo es obligatorio',
      minLength: 'Mínimo 2 caracteres',
      maxLength: 'Se superó el máximo de 30 caracteres',
      pattern: 'El formato es inválido. Sólo letras y espacios',
    },
  };

  constructor(
    private _customerService: CustomerService,
    private _route: ActivatedRoute,
    private _fb: FormBuilder,
    private router: Router,
    private _toastService: ToastService,
    private _darkmode: DarkmodeService
  ) {
    this._darkmode.darkmode.subscribe((darkmode) => {
      this.isDarkMode = darkmode;
    });
    
    this.customerForm = this._fb.group({
      ContactName: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(40),
        Validators.pattern(/^[\wáéíóúÁÉÍÓÚñÑ]+(?:\s+[\wáéíóúÁÉÍÓÚñÑ]+)+$/)
      ]],
      CompanyName: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(30),
        Validators.pattern(/^[a-zA-ZáéíóúÁÉÍÓÚñÑ.\s-_]+$/)
      ]],
      City: ['', [
        Validators.required,
        Validators.minLength(2),
        Validators.maxLength(30),
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
    this._customerService.getCustomerById(id).subscribe(
      (data) => {
        this.customerForm.setValue({
          ContactName: data.ContactName,
          CompanyName: data.CompanyName, 
          City: data.City,   
        });
      },
      (error) => {
        this._toastService.notification(`Error al obtener los datos: ${error.message.toString()}`, 2500);
      }
    ).add(() => {
      this.loading = false;
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
      httpObservable = this._customerService.updateCustomer(id, this.customerForm.value);
    } else {
      httpObservable = this._customerService.insertCustomer(this.customerForm.value);
    }

    httpObservable.subscribe(
      (data) => {
          if (data.result) {
          this._toastService.notification(`${data.message} Redirigiendo...`, 2500);
          setTimeout(() => {
            this.router.navigate(['/customers']);
          }, 2500);
        } else {
          this._toastService.notification(data.message, 2500);
        }
      },
      (error) => {
        this._toastService.notification(`Error al actualizar: ${error.message.toString()}`, 2500);
      }
    ).add(() => {
      this.loading = false;
    });
  }
}
