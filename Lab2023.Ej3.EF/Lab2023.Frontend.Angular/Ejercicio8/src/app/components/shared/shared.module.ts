import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

//Angular Material
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatIconModule} from '@angular/material/icon';

@NgModule({
  declarations: [],
  imports: [
    MatTableModule,
    MatPaginatorModule,
    CommonModule,
    MatIconModule,
    HttpClientModule
  ],
  exports: [
    MatPaginatorModule,
    MatTableModule,
    MatIconModule,
    HttpClientModule
  ]
})
export class SharedModule { }
