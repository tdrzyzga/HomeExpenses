import {RouterModule, Routes} from "@angular/router";
import {DashboardComponent} from "./dashboard.component";

const dashboardRoutes: Routes = [
  {
    path: '',
    component: DashboardComponent,
    pathMatch: 'full',
  }
];

export const DashboardRoutesModule = RouterModule.forChild(dashboardRoutes);
