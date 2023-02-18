import { Flight } from './../../../Shared/Model/Flight';
import { FlightService } from './../../../Shared/Services/flight.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit {
  result: any;
  FlightName = localStorage.getItem('flightName');
  constructor(private flightService: FlightService) { }

  ngOnInit() {
    console.log(this.FlightName);
    console.log('hit display');
    this.flightService.DisplayPassengerDeatils(this.FlightName).subscribe(data => {
      this.result = data['passengerModelList'];
      console.log(this.result);
    });
  }
}
