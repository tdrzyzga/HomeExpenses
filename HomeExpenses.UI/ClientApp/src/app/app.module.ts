import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {RouterModule} from "@angular/router";

import {RecipientsModule} from './modules/recipients/recipients.module';
import {AppComponent} from './app.component';
import {MainModule} from "./modules/main/main.module";
import {AppRoutesModule} from "./app.routing";

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MainModule,
    RecipientsModule,
    RouterModule,
    AppRoutesModule
  ],
  declarations: [
    AppComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
