import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'customer-add',
  templateUrl: './customer-add.component.html',
  styleUrls: ['./customer-add.component.css']
})
export class CustomerAddComponent implements OnInit {

  public title ='Novo';
  
  constructor() { }

  ngOnInit(): void {
  }

}
