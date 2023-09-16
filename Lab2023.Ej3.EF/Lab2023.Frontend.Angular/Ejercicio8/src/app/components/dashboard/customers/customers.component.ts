import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
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

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.dataSource.paginator = this.paginator;
    this.http.get<Customer[]>('https://localhost:44393/api/customer').subscribe(
      (data) => {
        this.dataSource.data = data;
        this.dataSource.paginator = this.paginator;
        this.dataSource.paginator.length = data.length;
      },
      (error) => {
        console.error('Error al obtener datos de clientes:', error);
      }
    );
  } 

  displayedColumns: string[] = ['Name', 'Company', 'City', 'Options'];
}
