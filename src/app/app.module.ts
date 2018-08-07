import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { CategoriasComponent } from './template/categorias/categorias.component';
import { CategoriasService } from './services/categorias.service';
// routes
import { APP_ROUTING } from './app.routes';

@NgModule({
  declarations: [
    AppComponent,
    CategoriasComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    APP_ROUTING
  ],
  providers: [
    CategoriasService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
