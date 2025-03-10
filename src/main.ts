import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { provideRouter } from '@angular/router';
import { routes } from './app/app.routes';  // Importa las rutas definidas

bootstrapApplication(AppComponent, {
  providers: [provideRouter(routes)]  // Aquí se pasan las rutas a la app
}).catch(err => console.error(err));
