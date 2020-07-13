import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  public title = 'Solare';
  public menuOne = 'Página Inicial';
  public menuTwo = 'Cadastro';
  public menuThree = 'Atendimento';
  public userLogado = 'Usuário Logado';

  constructor() { }

  ngOnInit(): void {
  }

}
