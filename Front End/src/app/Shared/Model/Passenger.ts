export class Passenger {
  PassengerAge: number;
  PassengerName: string;
  FlightId: number;
  public constructor(PassengerName, PassengerAge, FlightId) {
    this.PassengerName = PassengerName;
    this.FlightId = FlightId;
    this.PassengerAge = PassengerAge;
  }
}
