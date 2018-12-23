import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {RouterModule} from "@angular/router";

import {AppComponent} from './app.component';
import {MainModule} from "./modules/main/main.module";
import {AppRoutesModule} from "./app.routing";
import {MaterialModule} from "./shared/modules/material/material.module";
import {RecipientsModule} from "./modules/recipients/recipients.module";

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MainModule,
    RecipientsModule,
    MaterialModule,
    RouterModule,
    AppRoutesModule
  ],
  exports: [
    BrowserModule
  ],
  declarations: [
    AppComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
