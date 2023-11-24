using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;

namespace API.Controllers;

[Route("api/tarefa")]
[ApiController]
public class TarefaController : ControllerBase
{
    private readonly AppDataContext _context;

    public TarefaController(AppDataContext context) =>
        _context = context;

    // GET: api/tarefa/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try
        {
            List<Tarefa> tarefas = _context.Tarefas.Include(x => x.Categoria).ToList();
            return Ok(tarefas);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    // POST: api/tarefa/cadastrar
    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Tarefa tarefa)
    {
        try
        {
            Categoria? categoria = _context.Categorias.Find(tarefa.CategoriaId);
            if (categoria == null)
            {
                return NotFound();
            }
            tarefa.Status = "Nao iniciada";
            tarefa.Categoria = categoria;
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return Created("", tarefa);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut]
    [Route("alterar/{TarefaId}")]
    public IActionResult Alterar([FromRoute] int TarefaId){
        try
        {
            //Recebo a tarefa do banco
            Tarefa? tarefaCadastrada = _context.Tarefas.FirstOrDefault(x => x.TarefaId == TarefaId);
            
            //Dou a condição para ela
            if (tarefaCadastrada.Status.Equals("Nao iniciada"))
            {
                
                tarefaCadastrada.Status = "Em andamento";

                _context.Tarefas.Update(tarefaCadastrada);
                _context.SaveChanges();

                return Ok(tarefaCadastrada);
            }  else if (tarefaCadastrada.Status.Equals("Em andamento"))
            {
                        
                tarefaCadastrada.Status = "Concluido";

                _context.Tarefas.Update(tarefaCadastrada);
                _context.SaveChanges();

                return Ok(tarefaCadastrada);
            }

            

            return NotFound("Tarefa não encontrada");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("naoconcluida")]

    public IActionResult NaoConcluidas()
    {
         try
        {
            var tarefasFiltro = new List<Tarefa>();
            List<Tarefa> tarefas = _context.Tarefas.Include(x => x.Categoria).ToList();
            foreach (var tarefa in tarefas)
            {
                if(tarefa.Status.Equals("Em Andamente") || tarefa.Status.Equals("Nao iniciada"))
                {
                    tarefasFiltro.Add(tarefa);
                    
                }
            }
            return Ok(tarefasFiltro);
            
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("concluida")]

    public IActionResult Concluidas()
    {
         try
        {
            var tarefasFiltro = new List<Tarefa>();
            List<Tarefa> tarefas = _context.Tarefas.Include(x => x.Categoria).ToList();
            foreach (var tarefa in tarefas)
            {
                if(tarefa.Status.Equals("Concluido"))
                {
                    tarefasFiltro.Add(tarefa);
                    
                }
            }
            return Ok(tarefasFiltro);
            
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
