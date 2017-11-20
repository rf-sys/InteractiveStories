import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    // Make the HTTP request:
    /*
    this.http.get('http://192.168.99.100:30220/api/values').subscribe(data => {
      console.log(data);
    });
    */
  }
}
