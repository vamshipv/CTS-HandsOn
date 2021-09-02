import { Component } from '@angular/core';
import { employeeTest } from './employee-test';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Day2 Session1 // Hello World';
  movie = 'Lord of the Rings';
  emp = new employeeTest();
}
