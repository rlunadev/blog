import { Component, OnInit } from '@angular/core';
import {HttpClient } from '@angular/common/http';
import { CategoriasService, Categoria } from '../../services/categorias.service';

@Component({
  selector: 'app-categorias',
  templateUrl: './categorias.component.html',
  styleUrls: ['./categorias.component.css']
})
export class CategoriasComponent implements OnInit {

  public categorias: any;
  constructor(private httpClient: HttpClient) {

    this.httpClient.get('http://localhost:63357/api/categoria')
      .subscribe(data => {
         console.log(data);
         this.categorias = data;
      });
  }
  ngOnInit() {
  }

}
