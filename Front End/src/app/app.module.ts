import { HttpClientModule } from '@angular/common/http';
import { AddPassengerModule } from './Modules/add-passenger/add-passenger.module';
import { DisplayPassengersModule } from './Modules/display-passengers/display-passengers.module';
import { DisplayModule } from './Modules/display/display.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './Core/home-page/home-page.component';
import { FilterPipe } from './Shared/Pipe/filter.pipe';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    FilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    DisplayModule,
    DisplayPassengersModule,
    AddPassengerModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
