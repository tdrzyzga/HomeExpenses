import {MainComponent} from "./modules/main/main.component";
import {RouterModule, Routes} from "@angular/router";

const appRoutes: Routes = [
  {
    path: '',
    component: MainComponent,
    children: [
      {
        path: '',
        redirectTo: '/dashboard',
        pathMatch: 'full'
      },
      {
        path: 'dashboard',
        loadChildren: './modules/dashboard/dashboard.module#DashboardModule'
      },
      {
        path: 'recipients',
        loadChildren: './modules/recipient/recipient.module#RecipientModule'
      }]
  }];

export const AppRoutesModule = RouterModule.forRoot(appRoutes);
