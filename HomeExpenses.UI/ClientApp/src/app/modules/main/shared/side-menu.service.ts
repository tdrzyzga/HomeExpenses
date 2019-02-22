import { Injectable } from '@angular/core';
import {MatSidenav} from "@angular/material";

@Injectable({
  providedIn: 'root'
})

export class SideMenuService {
  private sidenav: MatSidenav;

  constructor() { }

  public setSidenav(sidenav: MatSidenav) {
    this.sidenav = sidenav;
  }

  public toggle(): void {
    this.sidenav.toggle();
  }
}
