import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MatListModule} from '@angular/material/list';

import {RecipientsComponent} from './recipients.component';

@NgModule({
  imports: [
    CommonModule,
    MatListModule
  ],
  declarations: [
    RecipientsComponent
  ],
  exports: [
    RecipientsComponent
  ]
})
export class RecipientsModule {
}
