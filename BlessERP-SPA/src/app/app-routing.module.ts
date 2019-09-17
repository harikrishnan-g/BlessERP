import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { Employee } from './Model/Employee';

const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

