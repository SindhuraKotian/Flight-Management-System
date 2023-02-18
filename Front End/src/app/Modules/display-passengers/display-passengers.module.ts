import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DisplayPassengersRoutingModule } from './display-passengers-routing.module';
import { DisplayPassengersComponent } from './display-passengers/display-passengers.component';
import { ReactiveFormsModule, FormsModule } from '../../../../node_modules/@angular/forms';


@NgModule({
  declarations: [DisplayPassengersComponent],
  imports: [
    CommonModule,
    DisplayPassengersRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class DisplayPassengersModule { }
