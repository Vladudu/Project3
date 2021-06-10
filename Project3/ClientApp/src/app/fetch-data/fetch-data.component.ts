import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public magazin: Magazin[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Magazin[]>(baseUrl + 'magazin').subscribe(result => {
      this.magazin = result;
    }, error => console.error(error));
  }
}

interface Magazin {
  Denumire: string;
  Specificatii: string;
  Status: string;
  Pret: BigInteger;
}
