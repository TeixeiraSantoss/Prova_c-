import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
    <a routerLink="pages/tarefa/listar"> Listar Tarefas </a>
    <br>
    <a routerLink="pages/tarefa/cadastrar"> Cadastrar Tarefa </a>
    <br>
    <router-outlet></router-outlet>
  `,
  styles: []
})
export class AppComponent {
  title = 'FRONT';
}
