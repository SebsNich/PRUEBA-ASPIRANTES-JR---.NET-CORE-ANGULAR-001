import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PeliculasComponent } from './peliculas/peliculas.component';
import { AsignarPeliculaSalaComponent } from './asignar-pelicula-sala/asignar-pelicula-sala.component';
import { SalasComponent } from './salas/salas.component';

const routes: Routes = [
  { path: 'peliculas', component: PeliculasComponent },
  { path: 'salas', component: SalasComponent },
  { path: 'asignar-pelicula-sala', component: AsignarPeliculaSalaComponent },
  { path: '', redirectTo: '/peliculas', pathMatch: 'full' },  // Redirige a la vista de películas por defecto
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }