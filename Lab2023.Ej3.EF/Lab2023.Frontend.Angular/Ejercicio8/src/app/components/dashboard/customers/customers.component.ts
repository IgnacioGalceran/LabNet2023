import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
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
  error = { error: false, message: ''};

  constructor(private _http: HttpClient, private _snackBar: MatSnackBar) { }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this._http.get<Customer[]>(`${this.url}`).subscribe(
      (data) => {
        this.dataSource.data = data;
        this.dataSource.paginator = this.paginator;
        this.dataSource.paginator.length = data.length;
      },
      (error) => {
        this.error = { error: true, message: `Error al obtener los clientes: ${error.message.toString()}`};
        this.toast(`Error al obtener los clientes: ${error.message.toString()}`);
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
      title: 'Estás seguro que desea borrar?',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: `Si, borrar!`
    }).then((result) => {
      if (result.isConfirmed) {
        this._http.delete<any>(`${this.url}/${id}`).subscribe(
        (data) => {
          this.dataSource.data = this.dataSource.data.filter((deleted) => deleted.CustomerID !== id);
          this.toast(data.message);
        },
        (error) => {
          this.toast(`Error al borrar el cliente: ${error.message.toString()}`);
        }
        )
      }
    })
  }
  
  displayedColumns: string[] = ['Name', 'Company', 'City', 'Options'];
}