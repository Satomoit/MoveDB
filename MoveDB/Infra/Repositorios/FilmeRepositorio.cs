using System.Security.Cryptography.X509Certificates;
using MoveDB.Dominio;

namespace MoveDB.Infra.Repositorios
{
    public class FilmeRepositorio: IRepositorio<Filme>
    {
        List<Filme> filmes;

        public FilmeRepositorio()
        {
            filmes = new List<Filme>();
        }
        public void AdicionarDados(Filme filme) { 

            filmes.Add(filme);
        }
     
        public List<Filme> BuscarDados()
        {
            return filmes;
        }
        public List<Filme> BuscarDadoPorNome(string nome)
        {
            var resultado = filmes.Where(x => x.Nome == nome).ToList();
            if (resultado.Any())
            {
                return resultado;
            }
            return null;
        }
        public void AtualizarDado(Filme filme) 
        {
            var resultado = filmes.Where(x => x.Nome == filme.Nome).ToList();
            if (resultado.Any())
            {
                var filmeAntigo = resultado.FirstOrDefault();
                filmeAntigo.Nome = filme.Nome;
                filmeAntigo.DataDeLancamento = filme.DataDeLancamento;
                filmeAntigo.Diretor = filme.Diretor;
                filmeAntigo.Sinopse = filme.Sinopse;
                filmeAntigo.Genero = filme.Genero;
                filmeAntigo.Elenco = filme.Elenco;

                filmes.Add(filmeAntigo);
            }
        }
        public void DeletarDado(Filme filme)
        {
            var filmeExistente = filmes.FirstOrDefault(x => x.Nome == filme.Nome);
            if(filmeExistente != null)
            {
                filmes.Remove(filmeExistente);
            }
        }
    }
}
