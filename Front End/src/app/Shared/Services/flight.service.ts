import { Flight } from './../Model/Flight';
import { Passenger } from './../Model/Passenger';
import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient, HttpHeaders, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class FlightService {

  private readonly AddPassengerAPI = environment.AddPassengerAPI;
  private readonly DisplayFlightAPI = environment.DisplayFlightAPI;
  private readonly DisplayPassengerAPI  = environment.DisplayPassengerAPI;
  constructor(private http: HttpClient) { }

  DisplayPassengerDeatils(flightname): Observable<Passenger> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.get<Passenger>(this.DisplayPassengerAPI + flightname, httpOptions);
  }

  AddPassenger(passenger): Observable<Passenger> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<Passenger>(this.AddPassengerAPI, JSON.stringify(passenger), httpOptions);
  }

  DisplayFlight(): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.get<any>(this.DisplayFlightAPI, httpOptions);
  }
}
