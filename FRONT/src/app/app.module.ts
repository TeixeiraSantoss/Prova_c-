import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListarComponentComponent } from './pages/tarefa/listar-component/listar-component.component';
import { CadastrarTarefaComponent } from './pages/tarefa/cadastrar-tarefa/cadastrar-tarefa.component';
import { AlterarTarefaComponent } from './pages/tarefa/alterar-tarefa/alterar-tarefa.component';

@NgModule({
  declarations: [
    AppComponent,
    ListarComponentComponent,
    CadastrarTarefaComponent,
    AlterarTarefaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
