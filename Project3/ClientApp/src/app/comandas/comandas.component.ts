import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comanda } from './comandas.models';

@Component({
  selector: 'app-comanda',
  templateUrl: './comandas.component.html'
})
export class ComandasComponent {
  public comandas: Comanda[];

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    http.get<Comanda[]>(baseUrl + 'api/comandas').subscribe(result => {
      this.comandas = result;
    }, error => console.error(error));
  }

  public deleteComanda(comanda: Comanda) {
    console.log(comanda);
    this.http.delete(this.baseUrl + 'api/magazins' + comanda.ID).subscribe(result => {
      this.loadComanda();
    }, error => console.error(error))
  }

  loadComanda() {
    this.http.get<Comanda[]>(this.baseUrl + 'api/comandas').subscribe(result => {
      this.comandas = result;
    }, error => console.error(error));
  }
}
