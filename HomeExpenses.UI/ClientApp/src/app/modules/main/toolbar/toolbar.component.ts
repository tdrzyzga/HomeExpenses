import {Component, OnInit} from '@angular/core';
import {SideMenuService} from "../shared/side-menu.service";

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.scss']
})
export class ToolbarComponent implements OnInit {

  constructor(private sideMenuService: SideMenuService) { }

  ngOnInit() {
  }

  toggleSideMenu(){
    this.sideMenuService.toggle();
  }
}
