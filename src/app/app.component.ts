import { Component } from '@angular/core';
import { Router } from "@angular/router";
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'spring-mvc';
  constructor(private router: Router) { }
  signinpage() {
    this.router.navigateByUrl("signin");
  }

  registerpage() {
    this.router.navigateByUrl("register");
  }

  adminpage() {
    this.router.navigateByUrl("admin");
  }
}
