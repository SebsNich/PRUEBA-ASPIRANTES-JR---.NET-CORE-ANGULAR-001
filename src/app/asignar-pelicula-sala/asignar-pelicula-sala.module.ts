// src/app/asignar-pelicula-sala/asignar-pelicula-sala.module.ts
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common'; // Importar CommonModule
import { FormsModule } from '@angular/forms'; // Importar FormsModule
import { AsignarPeliculaSalaComponent } from './asignar-pelicula-sala.component';

@NgModule({
  declarations: [AsignarPeliculaSalaComponent],
  imports: [
    CommonModule,  // Asegúrate de que CommonModule esté importado
    FormsModule    // Asegúrate de que FormsModule esté importado
  ],
  exports: [AsignarPeliculaSalaComponent]
})
export class AsignarPeliculaSalaModule { }
