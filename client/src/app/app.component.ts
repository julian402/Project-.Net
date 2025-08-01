import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./layout/header/header.component";
import { HttpClient } from '@angular/common/http';
import { Product } from './shared/models/product';
import { Pagination } from './shared/models/pagination';

@Component({
    selector: 'app-root',
    standalone: true,
    imports: [HeaderComponent],
    templateUrl: './app.component.html',
    styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit{

  baseUrl = 'https://localhost:5500/api/';
  private http = inject(HttpClient);
  title = 'client';

  products: Product[] = [];

  ngOnInit(): void {
      this.http.get<Pagination<Product>>(this.baseUrl + 'products').subscribe(({
        next: response => this.products = response.data,
        error: error => console.error(error),
        complete: () => console.log('complete')
      }))
  }

}
