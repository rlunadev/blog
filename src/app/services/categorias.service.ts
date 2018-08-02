import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoriasService {
  constructor(private httpClient: HttpClient) {
    console.log('Servicio Categoria');
  }
  getAllCategoria() {
  const headers = new HttpHeaders({
     'Access-Control-Allow-Origin': '*'
  });
  this.httpClient.get('http://localhost:2929/api/recipe', { headers })
      .subscribe(data => {
         return data;
      });
    }
}

export interface Categoria {
  id: string;
  titulo: string;
  texto: string;
  fecha: Date;
  estado: number;
}
