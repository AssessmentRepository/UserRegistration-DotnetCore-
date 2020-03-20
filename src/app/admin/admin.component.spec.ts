import {
  ComponentFixture,
  TestBed,
  async
} from "@angular/core/testing";

import { AdminComponent } from "./admin.component";
import { By } from "@angular/platform-browser";
import { DebugElement } from "@angular/core";
describe("AdminComponent", () => {
  let component: AdminComponent;
  let fixture: ComponentFixture<AdminComponent>;
  let element: HTMLElement;
  let debugEl: DebugElement;
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [AdminComponent]
    })
      .compileComponents()
      .then(() => {
        fixture = TestBed.createComponent(AdminComponent);
        component = fixture.componentInstance;
        debugEl = fixture.debugElement;
        element = fixture.nativeElement;
      });
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });
  const rows = [
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
  it("should create", () => {
    expect(component).toBeTruthy();
  });

  it(" should have a h2 (All user)", async(() => {
    let fixture = TestBed.createComponent(AdminComponent);
    let element = fixture.nativeElement;

    fixture.detectChanges();
    expect(element.querySelector("h2").innerHTML).toBe("All user");
  }));

  it("should show user header length", async(() => {
    fixture.detectChanges();
    fixture.whenStable().then(() => {
      fixture.detectChanges();
      var rowHeaderLength = element.querySelectorAll("th").length;
      expect(rowHeaderLength).toBe(7);
    });
  }));

  it("should have table header Sl NO ", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h1"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("Sl NO");
  });

  it("should have table header Check box", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h2"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("Check box");
  });
  it("should have table header Profile", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h3"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("Profile");
  });
  it("should have table header User Name", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h4"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("User Name");
  });
  it("should have table header Password", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h5"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("Password");
  });
  it("should have table header Email", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h6"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("Email");
  });
  it("should have table header Action", () => {
    fixture.detectChanges();
    const de = fixture.debugElement.query(By.css(".h7"));
    const el = de.nativeElement;
    expect(el.textContent).toEqual("Action");
  });
  it("should have a data", async(() => {
    let admindata = rows;
    expect(admindata).toBeTruthy;
  }));
  it("should have a equal data", async(() => {
    let admindata = rows;
    expect(admindata).toEqual(rows);
  }));
});
