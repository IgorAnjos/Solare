import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public title = 'Acessar o Solare';
  public newAccount = 'Crie uma conta';
  public forgotPassword= 'Esqueceu a senha?';

  constructor() { }

  ngOnInit(): void {
  }

}
