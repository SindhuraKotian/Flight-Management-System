import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  { path: 'AddPassenger', loadChildren: './Modules/add-passenger/add-passenger.module#AddPassengerModule' },
  { path: 'displayPasseger', loadChildren: './Modules/display-passengers/display-passengers.module#DisplayPassengersModule' },
  { path: 'displayDetails', loadChildren: './Modules/display/display.module#DisplayModule' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
