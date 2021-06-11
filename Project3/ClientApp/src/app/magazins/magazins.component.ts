import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Magazin } from './magazins.models';

@Component({
  selector: 'app-magazin',
  templateUrl: './magazins.component.html'
})
export class MagazinsComponent {
  public magazins: Magazin[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<Magazin[]>(baseUrl + 'api/magazins').subscribe(result => {
      this.magazins= result;
    }, error => console.error(error));
  }

  public deleteMagazin(magazin: Magazin) {
    console.log(magazin);
    this.http.delete(this.baseUrl + 'api/magazins' + magazin.ID ).subscribe(result => {
      this.loadMagazins();
    }, error => console.error(error))
  }

  loadMagazins() {
    this.http.get<Magazin[]>(this.baseUrl + 'api/magazins').subscribe(result => {
      this.magazins = result;
    }, error => console.error(error));
  }
}

