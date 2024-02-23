import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {

  transform(value: any[], FilterString : string, carModel:string): unknown {
    const resultArray = [];
    if(value.length === 0 || FilterString === '' || carModel === '' )
    {
      return value;
    }
    
    for(const item of value)
    {
      if(item[carModel] === FilterString )
      {
        resultArray.push(item);
      }
    }

    return resultArray;
  }

}
