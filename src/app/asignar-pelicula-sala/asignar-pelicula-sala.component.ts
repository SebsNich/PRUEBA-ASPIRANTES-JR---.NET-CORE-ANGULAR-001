// src/app/asignar-pelicula-sala/asignar-pelicula-sala.component.ts
import { Component, OnInit } from '@angular/core';
import { Pelicula } from '../models/pelicula.model';  // Asegúrate de que la ruta sea correcta
import { Sala } from '../models/sala.model';  // Asegúrate de que la ruta sea correcta
import { PeliculaService } from '../services/pelicula.service';
import { SalaService } from '../services/sala.service';  // Asegúrate de que la ruta sea correcta

@Component({
  selector: 'app-asignar-pelicula-sala',
  templateUrl: './asignar-pelicula-sala.component.html',
  styleUrls: ['./asignar-pelicula-sala.component.css']
})
export class AsignarPeliculaSalaComponent implements OnInit {
  peliculas: Pelicula[] = [];
  salas: Sala[] = [];
  seleccionPelicula: number | null = null;
  seleccionSala: number | null = null;

  constructor(
    private peliculaService: PeliculaService,
    private salaService: SalaService
  ) {}

  ngOnInit(): void {
    this.peliculaService.getPeliculas().subscribe((data) => {
      this.peliculas = data;
    });

    this.salaService.getSalas().subscribe((data) => {
      this.salas = data;
    });
  }

  asignarPeliculaASala() {
    if (this.seleccionPelicula && this.seleccionSala) {
      console.log(`Asignando película ID: ${this.seleccionPelicula} a sala ID: ${this.seleccionSala}`);
      // Aquí va la lógica para asignar la película a la sala
    }
  }
}