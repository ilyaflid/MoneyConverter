import { Component, Input } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  private _headers: HttpHeaders;
  private _httpClient: HttpClient;
  _baseUrl = "https://localhost:7117/MoneyConvert/";
  @Input() inputNumber: any;
  numberAsString: any;

  constructor(http: HttpClient) {
    this._httpClient = http;
    this._headers = new HttpHeaders({ 'Content-Type': 'application/json' });
  }

  public convertNumber() {
    if (this.inputNumber == null || this.inputNumber === '') {
      this.numberAsString = '';
      return;
    }

    this._httpClient.get(this._baseUrl + this.inputNumber, { headers: this._headers }).subscribe(result => {
      this.numberAsString = result;
    }, error => {
      this.numberAsString = error.error.Message;
    });
  }
}
