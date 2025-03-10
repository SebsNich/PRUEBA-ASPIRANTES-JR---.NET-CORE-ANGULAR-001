import { Component } from '@angular/core';
import { PeliculaService } from '../services/pelicula.service';
import { Pelicula } from '../models/pelicula.model';  // Asegúrate de que la ruta sea correcta

@Component({
  selector: 'app-peliculas',
  templateUrl: './peliculas.component.html',
  styleUrls: ['./peliculas.component.css']
})
export class PeliculasComponent {
  nombre: string = '';
  duracion: number = 0;

  constructor(private peliculaService: PeliculaService) {}

  agregarPelicula() {
    const nuevaPelicula: Pelicula = {
      nombre: this.nombre,
      duracion: this.duracion
    };

    this.peliculaService.addPelicula(nuevaPelicula).subscribe(response => {
      console.log('Película agregada con éxito:', response);
      // Aquí puedes agregar lógica adicional si lo necesitas, como mostrar un mensaje o limpiar el formulario.
    }, error => {
      console.error('Error al agregar la película:', error);
    });
  }
}