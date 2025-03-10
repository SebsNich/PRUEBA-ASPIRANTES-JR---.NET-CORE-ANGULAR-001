import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { AsignarPeliculaSalaComponent } from './asignar-pelicula-sala/asignar-pelicula-sala.component';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms'; // Importa FormsModule

@NgModule({
  declarations: [
    AppComponent,
    AsignarPeliculaSalaComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,  // Importa CommonModule
    FormsModule    // Importa FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
