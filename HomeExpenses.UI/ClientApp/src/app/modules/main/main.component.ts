import {Component, OnInit, ViewChild} from '@angular/core';
import {SideMenuService} from "./shared/side-menu.service";
import {MatSidenav} from "@angular/material";

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  @ViewChild('sidenav') public sidenav: MatSidenav;

  constructor(private sideMenuService: SideMenuService) { }

  ngOnInit() {
    this.sideMenuService.setSidenav(this.sidenav);
  }
}
