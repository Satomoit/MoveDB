using Microsoft.AspNetCore.Mvc;
using MoveDB.Aplicacao;
using MoveDB.Dominio;
using MoveDB.Infra.Repositorios;

namespace MoveDB.Apresentacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController: ControllerBase
    {
        private FilmeService service;
        public FilmeController() 
        {
            this.service = new FilmeService();
        }
        //verbos http
        /*
         - get = responsavel pela busca de informações
         - post = responsavel pela criação de informações
         - patch/put = responsaveis por atualizar infos
         - delete = responsavel por deletar informações
        */

        [HttpGet("{nome}")]
        public IActionResult get(string nome){
            var resultado = service.GetFilme(nome);
            if (resultado == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        public IActionResult post(Filme filme) {
            service.CriaFilme(filme);
            return Ok();
        }

        [HttpPut]

        public IActionResult put(Filme filme) {
            service.AtualizaFilme(filme);
            return Ok();
        }

        [HttpDelete]
        public IActionResult delete(Filme filme) {
            service.DeletaFilme(filme);
            return Ok();
        }
    }
}
