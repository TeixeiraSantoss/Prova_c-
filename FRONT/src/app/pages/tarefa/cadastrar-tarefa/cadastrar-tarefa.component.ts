import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Categoria } from 'src/app/models/categoria';
import { Tarefa } from 'src/app/models/tarefa';

@Component({
  selector: 'app-cadastrar-tarefa',
  templateUrl: './cadastrar-tarefa.component.html',
  styleUrls: ['./cadastrar-tarefa.component.css']
})
export class CadastrarTarefaComponent {
  //crio as variaveis que vão ser enviadas para a API
    Titulo : string = "";
    Descricao : string = "";
    Status : string = "";
    CategoriaId : number = 0;
    categorias : Categoria[] = [];

  constructor(private client: HttpClient,
    private router: Router){}

  //Requisição que recebe uma lista de "Genero" da "API", e recebe essa lista em memoria no front
  ngOnInit(): void{
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
      })
  }

  //Função "Cadastrar"
  //Para fazer o cadastrar, eu passo um objeto do tipo "Filme", com os dados necessarios
  cadastrar(): void{
    let tarefa: Tarefa ={
      Titulo: this.Titulo,
      Descricao: this.Descricao,
      Status: this.Status,
      CategoriaId: this.CategoriaId
    }; 

    //Fazendo a requisição de cadastro para a "API"
    this.client.post<Tarefa>
      //para fazer uma requisição "POST", são necessarias 2 coisas
      //1 - A rota da requisição que está na "API"
      //2 - Passar um objeto para ir junto com a requisição
      ("https://localhost:7015/api/tarefa/cadastrar", tarefa)
      .subscribe({
        //Requisição deu certo
        next: (tarefa) => {
          console.log("cadastrado com sucesso")
          this.router.navigate(['pages/tarefa/listar'])
        },
        error: (erro) =>{
          console.log(erro);
        }
      })
  };
}
