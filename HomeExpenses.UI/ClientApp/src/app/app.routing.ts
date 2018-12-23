import {MainComponent} from "./modules/main/main.component";
import {RouterModule, Routes} from "@angular/router";

const appRoutes: Routes = [
  {
    path: '',
    component: MainComponent
  }];

export const AppRoutesModule = RouterModule.forRoot(appRoutes);
