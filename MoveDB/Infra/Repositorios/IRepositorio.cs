namespace MoveDB.Infra.Repositorios
{
    public interface IRepositorio<T>
    {
        void AdicionarDados(T entidade);
        List<T> BuscarDadoPorNome(string nome);
        List<T> BuscarDados();
        void AtualizarDado(T entidade);
        void DeletarDado(T entidade);
    }
}
