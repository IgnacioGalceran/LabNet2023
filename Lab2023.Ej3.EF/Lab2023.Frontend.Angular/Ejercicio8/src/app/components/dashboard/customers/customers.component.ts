import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';
import { HttpClient } from '@angular/common/http';
import { Customer } from './customers.interface';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {
  dataSource: MatTableDataSource<Customer> = new MatTableDataSource<Customer>();
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  loading = true;

  constructor(private _http: HttpClient, private _snackBar: MatSnackBar) { }

  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this._http.get<Customer[]>('https://localhost:44393/api/customer').subscribe(
      (data) => {
        this.dataSource.data = data;
        this.dataSource.paginator = this.paginator;
        this.dataSource.paginator.length = data.length;
      },
      (error) => {
        this._snackBar.open(`Error al obtener los clientes: ${error.message.toString()}`, 'Cerrar', {
          duration: 3000
        });
      }
    ).add(() => {
      this.loading = false;
    });
  } 
  
  displayedColumns: string[] = ['Name', 'Company', 'City', 'Options'];
}