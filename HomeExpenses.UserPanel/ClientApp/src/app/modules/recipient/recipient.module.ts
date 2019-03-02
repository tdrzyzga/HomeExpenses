import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {RecipientListComponent} from "./recipient-list/recipient-list.component";
import {RecipientRoutesModule} from "./recipient.routing";
import {SharedModule} from "../../shared/modules/shared.module";
import {MaterialModule} from "../../shared/modules/material/material.module";
import { RecipientCreateDialogComponent } from './recipient-create-dialog/recipient-create-dialog.component';

@NgModule({
  imports: [
    CommonModule,
    RecipientRoutesModule,
    MaterialModule,
    SharedModule
  ],
  declarations: [
    RecipientListComponent,
    RecipientCreateDialogComponent
  ],
  entryComponents: [
    RecipientCreateDialogComponent
  ]
})
export class RecipientModule {
}
