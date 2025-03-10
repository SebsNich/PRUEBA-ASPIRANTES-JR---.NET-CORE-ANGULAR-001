import { Component } from '@angular/core';
import { RouterModule } from '@angular/router'; // ✅ Importar RouterModule

@Component({
  selector: 'app-root',
  standalone: true, // ✅ Si usas standalone, debes importar manualmente los módulos
  imports: [RouterModule], // ✅ Agregar RouterModule para que router-outlet funcione
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'cine-frontend';
}