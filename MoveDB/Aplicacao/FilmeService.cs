using MoveDB.Dominio;
using MoveDB.Infra.Repositorios;

namespace MoveDB.Aplicacao
{
    public class FilmeService
    {
        private FilmeRepositorio FilmeRepositorio { get; set; }
        public FilmeService() 
        {
            FilmeRepositorio = new FilmeRepositorio();
        }
        public List<Filme> GetFilme(string nome)
        {
            var filmeExistente = FilmeRepositorio.BuscarDadoPorNome(nome);
            if (filmeExistente != null)
            {
                return filmeExistente;
            }
            return null;
        }
        public List<Filme> GetTodosFilmes()
        {
            return FilmeRepositorio.BuscarDados();
        }
        public void CriaFilme(Filme filme)
        {
            FilmeRepositorio.AdicionarDados(filme);
        }
        
        public void AtualizaFilme(Filme filme)
        {
            FilmeRepositorio.AtualizarDado(filme);
        }

        public void DeletaFilme(Filme filme)
        {
            FilmeRepositorio.DeletarDado(filme);
        }
    }
}
