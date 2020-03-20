import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { SigninComponent } from "./signin/signin.component";
import { RegisterComponent } from "./register/register.component";
import { AdminComponent } from "./admin/admin.component";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
@NgModule({
  declarations: [
    AppComponent,
    SigninComponent,
    RegisterComponent,
    AdminComponent
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule],
  exports: [FormsModule, ReactiveFormsModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
