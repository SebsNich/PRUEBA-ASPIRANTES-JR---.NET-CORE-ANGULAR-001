import { Component } from '@angular/core';

@Component({
  selector: 'app-salas',
  templateUrl: './salas.component.html',
  styleUrls: ['./salas.component.css']
})
export class SalasComponent {
  salas = [
    { nombre: 'Sala 1', capacidad: 100 },
    { nombre: 'Sala 2', capacidad: 150 },
    { nombre: 'Sala 3', capacidad: 120 },
  ];
}
