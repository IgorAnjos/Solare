import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'service-product',
  templateUrl: './service-product.component.html',
  styleUrls: ['./service-product.component.css']
})
export class ServiceProductComponent implements OnInit {

  public title = 'Serviço';

  public services = [
    { id: 1, nome: 'Mapa Natal', valor: 'R$ 280,00' },
    { id: 2, nome: 'Sinastría', valor: 'R$ 380,00' },
    { id: 3, nome: 'Mapa Solar', valor: 'R$ 120,00' },
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
