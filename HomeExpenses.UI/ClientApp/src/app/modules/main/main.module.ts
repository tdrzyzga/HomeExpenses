import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { ToolbarComponent } from './toolbar/toolbar.component';
import {SideMenuComponent} from "./side-menu/side-menu.component";
import {RouterModule} from "@angular/router";
import {SharedModule} from "../../shared/modules/shared.module";
import {MaterialModule} from "../../shared/modules/material/material.module";

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    MaterialModule,
    SharedModule
  ],
  exports : [MainComponent],
  declarations: [
    MainComponent,
    ToolbarComponent,
    SideMenuComponent
  ]
})
export class MainModule { }
