import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {RecipientListComponent} from "./recipient-list/recipient-list.component";
import {RecipientRoutesModule} from "./recipient.routing";
import {SharedModule} from "../../shared/modules/shared.module";
import {MaterialModule} from "../../shared/modules/material/material.module";

@NgModule({
  imports: [
    CommonModule,
    RecipientRoutesModule,
    MaterialModule,
    SharedModule
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
