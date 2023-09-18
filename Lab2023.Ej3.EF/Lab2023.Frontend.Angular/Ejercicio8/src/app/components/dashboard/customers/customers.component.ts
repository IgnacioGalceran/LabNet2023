import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { CustomerService } from 'src/app/services/customer.service';
import { ToastService } from 'src/app/services/toast.service';
import { HttpClient } from '@angular/common/http';
import { Customer } from './customers.interface';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  dataSource: MatTableDataSource<Customer> = new MatTableDataSource<Customer>();
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  url: string = `https://localhost:44393/api/customer`;
  loading: boolean = true;
  error: boolean = false;
  errMessage: string = '';

  constructor(private _customerService: CustomerService, private _http: HttpClient, 
    private _snackBar: MatSnackBar, private _toastService: ToastService) { }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this._customerService.getCustomers().subscribe(
      (data) => {
        this.dataSource.data = data;
        this.dataSource.paginator = this.paginator;
        this.dataSource.paginator.length = data.length;
      },
      (error) => {
        this.error = true;
        this.errMessage = `Error al obtener los clientes: ${error.message.toString()}`;
        this._toastService.notification(`Error al obtener los clientes: ${error.message.toString()}`, 2500);
      }
    ).add(() => {
      this.loading = false;
    });
  }

  handleClick(id: string) {
    Swal.fire({
      title: 'Estás seguro que desea borrar?',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: `Si, borrar!`
    }).then((result) => {
      if (result.isConfirmed) {
        this._customerService.deleteCustomer(id).subscribe(
        (data) => {
          this.dataSource.data = this.dataSource.data.filter((deleted) => deleted.CustomerID !== id);
          this._toastService.notification(data.message, 2500);
        },
        (error) => {
          this._toastService.notification(`Error al borrar el cliente: ${error.message.toString()}`, 2500);
        }
        )
      }
    })
  }
  
  displayedColumns: string[] = ['Name', 'Company', 'City', 'Options'];
}