import { Component } from '@angular/core';

import { UserService } from './user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'User';
  id: number;
  email: string;
  first_name: string;
  last_name: string;

  userData: Array<any>;

  constructor(private user: UserService) {
    this.userData = new Array<any>();
    this.id = 0;
    this.email = "";
    this.first_name = "";
    this.last_name = "";
  }

  getData() {
    this.user.getAlUser().subscribe((data) => {
      console.log(data.data);
      this.userData = data.data;
    })
  }

  postData() {
    this.user.post(this.id, this.email, this.first_name, this.last_name);

  }
}
