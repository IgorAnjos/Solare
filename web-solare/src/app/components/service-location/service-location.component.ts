import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'service-location',
  templateUrl: './service-location.component.html',
  styleUrls: ['./service-location.component.css']
})
export class ServiceLocationComponent implements OnInit {

  public title = 'Espaço de Atendimento';
  public servicesLocation = [
    { id: 1, nome: 'Online' },
    { id: 2, nome: 'Presencial' }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
