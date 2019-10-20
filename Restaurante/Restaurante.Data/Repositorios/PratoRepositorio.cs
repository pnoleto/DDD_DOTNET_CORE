using Restaurante.Data.Contextos;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;

namespace Restaurante.Data.Repositorios
{
    public class PratoRepositorio : RepositorioBase<Prato>, IRepositorioPrato
    {
        public PratoRepositorio(Contexto contexto)
            : base(contexto)
        {
        }
    }
}
