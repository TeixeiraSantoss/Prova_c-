import { Categoria } from "./categoria";

export interface Tarefa{
    TarefaId? : number;
    Titulo : string;
    Descricao : string;
    Status : string;
    Categoria? : Categoria;
    CategoriaId : number;
}