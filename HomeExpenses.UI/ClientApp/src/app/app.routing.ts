import {MainComponent} from "./modules/main/main.component";
import {RouterModule, Routes} from "@angular/router";
import {RecipientsComponent} from "./modules/recipients/recipients.component";

const appRoutes: Routes = [
  {
    path: '',
    component: MainComponent,
    children: [
      {
        path: 'recipients',
        component: RecipientsComponent
      }]
  }];

export const AppRoutesModule = RouterModule.forRoot(appRoutes);
