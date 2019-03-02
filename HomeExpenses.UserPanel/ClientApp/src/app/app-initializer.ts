import { LOCATION_INITIALIZED } from '@angular/common';
import { TranslateService } from '@ngx-translate/core';
import { Injector } from '@angular/core';

export function appInitializerFactory(translate: TranslateService, injector: Injector) {
  return () => new Promise<void>((resolve: any) => {
    const locationInitialized = injector.get(LOCATION_INITIALIZED, Promise.resolve());
    locationInitialized.then(() => {
      translate.setDefaultLang('pl');
      translate.use('pl')
        .subscribe(null, null, () => resolve());
    });
  });
}

