import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  public title = 'Clientes';
  
  constructor() { }

  ngOnInit(): void {
  }

}
