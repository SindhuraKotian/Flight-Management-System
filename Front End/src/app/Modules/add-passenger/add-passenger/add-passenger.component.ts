import { Flight } from './../../../Shared/Model/Flight';
import { FlightService } from './../../../Shared/Services/flight.service';
import { Passenger } from './../../../Shared/Model/Passenger';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-add-passenger',
  templateUrl: './add-passenger.component.html',
  styleUrls: ['./add-passenger.component.css']
})
export class AddPassengerComponent implements OnInit {

  PassengerName: string;
  age: number;
  FlightId: number;
  result: any;
  pres: any;
  AddPassenger = new FormGroup({
    PassengerName: new FormControl(''),
    age: new FormControl(''),
    FlightName: new FormControl('')
  });
  passenger: Passenger;
  constructor(private flightService: FlightService) { }

  ngOnInit() {
    this.flightService.DisplayFlight().subscribe(data => {
      this.result = data['flightModelList'];
      console.log(this.result);
    });
  }

  AddPassengerMethod() {
    this.PassengerName = this.AddPassenger.get('PassengerName').value;
    this.age = this.AddPassenger.get('age').value;
    this.FlightId = this.AddPassenger.get('FlightName').value;
    this.passenger = new Passenger(this.PassengerName, this.age, this.FlightId);
    this.flightService.AddPassenger(this.passenger).subscribe(data => this.pres = data);
  }
}
