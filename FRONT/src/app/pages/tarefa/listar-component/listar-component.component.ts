import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Categoria } from 'src/app/models/categoria';
import { Tarefa } from 'src/app/models/tarefa';

@Component({
  selector: 'app-listar-component',
  templateUrl: './listar-component.component.html',
  styleUrls: ['./listar-component.component.css']
})
export class ListarComponentComponent {

  tarefas: Tarefa[] = [];
  Titulo : string = "";
  Descricao : string = "";
  Status : string = "";
  CategoriaId : number = 0;
  categorias : Categoria[] = [];
  constructor(private client: HttpClient,
    private router: Router){
  }

  //"ngOnInit" é execultado na abertura do componente
  ngOnInit(): void{
    this.client.get<Tarefa[]>
      ("https://localhost:7015/api/tarefa/listar")
      .subscribe({
        next: (tarefas) => {
          this.tarefas = tarefas;
        },
        error: (erro) =>{
          console.log(erro);
        }
      });
      this.client.get<Categoria[]>
      ("https://localhost:7015/api/categoria/listar")
      .subscribe({
        //caso a requisição funcione, vai execultar esse código
        
        //basicamente, esse trecho está recebendo uma lista de "generos" da "API", e está recebendo para o array "generos" declrado junto aos atributos
        next: (categorias) => {
          console.table(categorias);
          this.categorias = categorias;
        },

        //caso a requisição falhe
        error : (erro) => {
          console.log(erro)
        }
      });
  }

  alterar(TarefaId? : number): void{

      let tarefa: Tarefa ={
        Titulo: this.Titulo,
        Descricao: this.Descricao,
        Status: this.Status,
        CategoriaId: this.CategoriaId
      }; 
    this.client.put
      (`https://localhost:7015/api/tarefa/alterar/${TarefaId}`, tarefa)
      .subscribe({
        next: (tarefas) => {
          console.log("Status Alterado")
          this.router.navigate(["pages/listar/tarefa"])
        },
        error: (erro) =>{
          console.log(erro);
        }
      })
  }
}
