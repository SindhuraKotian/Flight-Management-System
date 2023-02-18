import { FormGroup, FormControl } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { Router } from '../../../../../node_modules/@angular/router';

@Component({
  selector: 'app-display-passengers',
  templateUrl: './display-passengers.component.html',
  styleUrls: ['./display-passengers.component.css']
})
export class DisplayPassengersComponent implements OnInit {
  PassengerName: string;
  DisplayPassenger = new FormGroup({
    PassengerName: new FormControl('')
  });
  constructor(private route: Router) { }

  ngOnInit() {
  }

  DisplayPassengerMethod() {
    this.PassengerName = this.DisplayPassenger.get('PassengerName').value;
    console.log(this.PassengerName);
    localStorage.setItem('flightName', this.PassengerName);
    this.route.navigate(['displayDetails']);
  }
}
