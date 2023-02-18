import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AddPassengerRoutingModule } from './add-passenger-routing.module';
import { AddPassengerComponent } from './add-passenger/add-passenger.component';
import { ReactiveFormsModule, FormsModule } from '../../../../node_modules/@angular/forms';


@NgModule({
  declarations: [AddPassengerComponent],
  imports: [
    CommonModule,
    AddPassengerRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class AddPassengerModule { }
