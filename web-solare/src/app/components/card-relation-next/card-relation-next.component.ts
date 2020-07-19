import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'card-relation-next',
  templateUrl: './card-relation-next.component.html',
  styleUrls: ['./card-relation-next.component.css']
})
export class CardRelationNextComponent implements OnInit {

  public title = 'Próximos Atendimentos';
  public cardRelations = [
    { data: '08/08/2020 21h00', customer: 'Igor Macedo dos Anjos' },
    { data: '24/08/2020 10h00', customer: 'Wilson Macedo dos Anjos' },
    { data: '12/08/2020 19h00', customer: 'Bruna Alves' },
    { data: '15/08/2020 15h00', customer: 'Andressa Cavalcante' },
    { data: '05/09/2020 14h00', customer: 'Cecília Meireles' },
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
