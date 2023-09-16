import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

//Angular Material
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';

@NgModule({
  declarations: [],
  imports: [
    MatTableModule,
    MatPaginatorModule,
    CommonModule
  ],
  exports: [
    MatPaginatorModule,
    MatTableModule
  ]
})
export class SharedModule { }
