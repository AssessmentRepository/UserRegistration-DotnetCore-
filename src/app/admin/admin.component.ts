import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-admin",
  templateUrl: "./admin.component.html",
  styleUrls: ["./admin.component.css"]
})
export class AdminComponent implements OnInit {
  editdata: boolean = false;
  rowID;
  public rows: {
    profile: any;
    username: string;
    password: string;
    email: string;
    makeadmin: string;
  }[];
  constructor() {
    this.rows = [
      {
        profile: "img 1",
        username: "John Doe 1",
        password: "900001111",
        email: "johndoe_one@email.com",
        makeadmin: "true"
      },
      {
        profile: "img 2",
        username: "John Doe 2",
        email: "johndoe_two@email.com",
        password: "900002222",
        makeadmin: "false"
      },
      {
        profile: "img 3",
        username: "John Doe 3",
        email: "johndoe_three@email.com",
        password: "900003333",
        makeadmin: "true"
      },
      {
        profile: "img 4",
        username: "John Doe 4",
        email: "johndoe_four@email.com",
        password: "900004444",
        makeadmin: "true"
      },
      {
        profile: "img 5",
        username: "John Doe 5",
        email: "johndoe_five@email.com",
        password: "900005555",
        makeadmin: "false"
      },
      {
        profile: "img 6",
        username: "John Doe 6",
        email: "johndoe_six@email.com",
        password: "900006666",
        makeadmin: "false"
      },
      {
        profile: "img 7",
        username: "John Doe 7",
        email: "johndoe_seven@email.com",
        password: "900007777",
        makeadmin: "true"
      },
      {
        profile: "img 8",
        username: "John Doe 8",
        email: "johndoe_eight@email.com",
        password: "900008888",
        makeadmin: "false"
      },
      {
        profile: "img 9",
        username: "John Doe 9",
        email: "johndoe_nine@email.com",
        password: "900009999",
        makeadmin: "true"
      },
      {
        profile: "img 10",
        username: "John Doe 10",
        email: "johndoe_ten@email.com",
        password: "900010000",
        makeadmin: "false"
      }
    ];
  }

  ngOnInit() {}

  updateadmin(a, i) {
    console.log("LOG: AdminComponent -> updateadmin -> a", a, i);
  }

  update(i) {
    this.editdata = true;
    this.rowID = i;
  }

  save(i) {
    this.editdata = false;
    this.rowID = "";
  }
}
