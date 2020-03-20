import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

export class SigninUser {
  constructor(public username: string, public password: string) {}
}
@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {
  @Output() signinIn = new EventEmitter<SigninUser>();
  signinForm: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.signinForm = this.fb.group({
      username: ["", [Validators.required, Validators.minLength(4)]],
      password: ["", [Validators.required, Validators.minLength(8)]]
    });
  }
  onSubmit() {
    this.signinForm.value;
    console.log(
      "LOG: signinComponent -> onSubmit -> this.signinForm.value",
      this.signinForm.value
    );
    if (this.signinForm.valid) {
      this.signinIn.emit(
        new SigninUser(
          this.signinForm.value.username,
          this.signinForm.value.password
        )
      );
    }
  }
}
