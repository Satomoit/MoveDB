using MoveDB.Dominio;

namespace MoveDB.Infra.Repositorios
{
    public class SerieRepositorio: IRepositorio<Serie>
    {
        public List<Serie> Series { get; set; }
        public SerieRepositorio() 
        { 
            Series = new List<Serie>();
        }
        public List<Serie> BuscarDadoPorNome(string nome)
        {
            return Series.Where(x => x.Nome == nome).ToList();
        }
        public void AdicionarDados(Serie serie)
        {
            Series.Add(serie);
        }
        public List<Serie> BuscarDados()
        {
            return Series;
        }

        public void AtualizarDado(Serie serie)
        {
            var SerieExistente = Series.FirstOrDefault(x => x.Nome == serie.Nome);
            if(SerieExistente != null) 
            {
                SerieExistente.Nome = serie.Nome;
                SerieExistente.DataDeLancamento = serie.DataDeLancamento;
                SerieExistente.Diretor = serie.Diretor;
                SerieExistente.Sinopse = serie.Sinopse;
                SerieExistente.Genero = serie.Genero;
                SerieExistente.Elenco = serie.Elenco;
                SerieExistente.NumeroDeEpisodios = serie.NumeroDeEpisodios;
                SerieExistente.NumeroDeTemporadas = serie.NumeroDeTemporadas;
            }
           } 
            public void DeletarDado(Serie serie)
        {
            var serieExistente = Series.FirstOrDefault(x => x.Nome == serie.Nome);
            if (serieExistente != null)
            {
                Series.Remove(serieExistente);
            }
        }
    }
}
 
