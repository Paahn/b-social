import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from './user.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent implements OnInit {
  public title: string = 'b-social';
  public users: User;

  public constructor(private http: HttpClient) {}

  public ngOnInit(): void {
      this.http.get('https://localhost:5001/api/users').subscribe();
  }
}
