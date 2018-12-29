import {RouterModule, Routes} from "@angular/router";
import {RecipientListComponent} from "./recipient-list/recipient-list.component";

const recipientRoutes: Routes = [
  {
    path: '',
    component: RecipientListComponent,
    pathMatch: 'full',
  }
];

export const RecipientRoutesModule = RouterModule.forChild(recipientRoutes);

