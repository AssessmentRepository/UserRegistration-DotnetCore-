import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

export class RegisterUser {
  constructor(
    public username: string,
    public password: string,
    public repeatpassword: string,
    public email: string,
    public photo:any,
    public yes:any,
    public no:any,
  ) {}
}
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() registerIn = new EventEmitter<RegisterUser>();
  registerForm: FormGroup;
  public obj: any = {};
  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.registerForm = this.fb.group({
      username: ["", [Validators.required, Validators.minLength(4)]],
      password: ["", [Validators.required, Validators.minLength(8)]],
      repeatpassword: ["", [Validators.required, Validators.minLength(8)]],
      email: ["", [Validators.required, Validators.pattern("[^ @]*@[^ @]*")]],
      photo:[""],
      yes:[""],
      no:[""],
    });
  }


  onSubmit() {
    this.obj = { ...this.registerForm.value, ...this.obj };
    this.registerForm.value;
    console.log(
      "LOG: LoginComponent -> onSubmit -> this.registerForm.value",
      this.registerForm.value
    );
    if (
      this.registerForm.value.password == this.registerForm.value.repeatpassword
    ) {
      if (this.registerForm.valid) {
        this.registerIn.emit(
          new RegisterUser(
            this.registerForm.value.username,
            this.registerForm.value.password,
            this.registerForm.value.repeatpassword,
            this.registerForm.value.email,
            this.registerForm.value.photo,
            this.registerForm.value.yes,
            this.registerForm.value.no
          )
        );
      }
    }
  }
}
