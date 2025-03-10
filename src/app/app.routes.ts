import { Routes } from '@angular/router';
import { AsignarPeliculaSalaComponent } from './asignar-pelicula-sala/asignar-pelicula-sala.component';

export const routes: Routes = [
  { path: 'asignar-pelicula-sala', component: AsignarPeliculaSalaComponent },
  { path: '', redirectTo: '/asignar-pelicula-sala', pathMatch: 'full' } // Redirección por defecto
];
