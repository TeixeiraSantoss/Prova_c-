import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListarComponentComponent } from './pages/tarefa/listar-component/listar-component.component';
import { CadastrarTarefaComponent } from './pages/tarefa/cadastrar-tarefa/cadastrar-tarefa.component';
import { AlterarTarefaComponent } from './pages/tarefa/alterar-tarefa/alterar-tarefa.component';

const routes: Routes = [

  {
    path: "",
    component: ListarComponentComponent
  },
  {
    path: "pages/tarefa/listar",
    component: ListarComponentComponent
  },
  {
    path: "pages/tarefa/cadastrar",
    component: CadastrarTarefaComponent
  },
  {
    path: "pages/tarefa/alterar",
    component: AlterarTarefaComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
