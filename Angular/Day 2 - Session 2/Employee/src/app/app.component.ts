import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Employee';

  constructor(private router: Router) {}

  goTo(componentName : String) : void {
    this.router.navigate([`$componentName`]);
  }
}

