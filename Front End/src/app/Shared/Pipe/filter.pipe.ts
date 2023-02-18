import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  // transform(items: any, Name: string, Age: number) {
  //   if (items && items.length) {
  //     return items.filter(item => {
  //       if (Name && item.passengerName.toLowerCase().indexOf(Name.toLowerCase()) === -1) {
  //         return false;
  //       }
  //       if (Age && item.passengerAge.indexOf(Age === -1) {
  //         return false;
  //       }
  //       return true;
  //     });
  //   } else {
  //      return items;
  //       }
  // }

}
