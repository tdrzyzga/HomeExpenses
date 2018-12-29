import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MaterialModule} from "../../shared/modules/material/material.module";

import {RecipientListComponent} from "./recipient-list/recipient-list.component";
import {RecipientRoutesModule} from "./recipient.routing";

@NgModule({
  imports: [
    CommonModule,
    RecipientRoutesModule,
    MaterialModule
  ],
  declarations: [
    RecipientListComponent
  ],
  exports: [
    RecipientListComponent
  ]
})
export class RecipientModule {
}
