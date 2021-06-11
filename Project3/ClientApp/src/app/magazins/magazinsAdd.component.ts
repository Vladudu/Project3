import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Magazin } from './magazins.models';
import { Router } from '@angular/router';

@Component({
  selector: 'app-magazin-add',
  templateUrl: './magazinsAdd.component.html'
})
export class MagazinAddComponent {

  public magazin: Magazin = <Magazin>{};

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { }

  public saveMagazin() {
    this.http.post(this.baseUrl + 'api/magazins', this.magazin).subscribe(result => {
      this.router.navigateByUrl("/magazins");
    }, error => console.error(error))
  }
}
