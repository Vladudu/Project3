import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-magazin',
  templateUrl: './magazin.component.html'
})
export class MagazinsComponent {
  public magazins: Magazin[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Magazin[]>(baseUrl + 'api/Magazins').subscribe(result => {
      this.magazins= result;
    }, error => console.error(error));
  }
}

interface Magazin {
  ID: string;
  Denumire: string;
  Specificatii: string;
  Status: string;
  Pret: string;
}
