using System.Data;

namespace MoveDB.Dominio
{
    public class Filme
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Sinopse { get; set; }
        public DataSetDateTime DataDeLancamento{ get; set; }
        public Ator Diretor { get; set; }
        public List<Ator> Elenco { get; set; }
    }
}
