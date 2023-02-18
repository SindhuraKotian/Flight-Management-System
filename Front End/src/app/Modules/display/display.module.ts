import { FilterPipe } from './../../Shared/Pipe/filter.pipe';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DisplayRoutingModule } from './display-routing.module';
import { DisplayComponent } from './display/display.component';


@NgModule({
  declarations: [
    DisplayComponent,
    FilterPipe
  ],
  imports: [
    CommonModule,
    DisplayRoutingModule
  ]
})
export class DisplayModule { }
