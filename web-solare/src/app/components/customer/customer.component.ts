import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  public title = 'Clientes';

  public customers = [
    { id: 1, nome: 'Thaís Macedo dos Anjos', data: '28/08/1986', horario: '19h30' },
    { id: 2, nome: 'Igor Macedo dos Anjos', data: '12/08/1992', horario: '23h45' },
    { id: 3, nome: 'Anthony dos Anjos Mardini', data: '17/10/2018', horario: '11h00' },
    { id: 4, nome: 'Terezinha de F. A. Macedo dos Anjos', data: '03/04/1960', horario: '05h30' },
    { id: 5, nome: 'Wilson Macedo dos Anjos', data: '03/09/1962', horario: '12h30' },
    { id: 6, nome: 'Erick Feitosa', data: '24/10/1999', horario: '08h25' },
    { id: 7, nome: 'Samuel Evangelista', data: '14/10/1996', horario: '21h20' },
    { id: 8, nome: 'Jonnatham Evangelista', data: '07/07/1990', horario: '04h04' },
    { id: 9, nome: 'Daniel Prado', data: '18/09/1981', horario: '17h48' },
    { id: 10, nome: 'Robson Binho', data: '15/05/1980', horario: '12h32' },
    { id: 11, nome: 'Ricardo Vasco', data: '28/08/1970', horario: '09h50' }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
