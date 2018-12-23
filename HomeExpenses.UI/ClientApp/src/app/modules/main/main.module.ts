import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { ToolbarComponent } from './toolbar/toolbar.component';
import {SideMenuComponent} from "./side-menu/side-menu.component";
import {MaterialModule} from "../../shared/modules/material/material.module";
import {RouterModule} from "@angular/router";

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    MaterialModule
  ],
  exports : [MainComponent],
  declarations: [
    MainComponent,
    ToolbarComponent,
    SideMenuComponent]
})
export class MainModule { }
