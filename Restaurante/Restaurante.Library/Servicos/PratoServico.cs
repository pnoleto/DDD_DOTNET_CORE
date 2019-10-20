using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;

namespace Restaurante.Dominio.Servicos
{
    public class PratoServico : ServicoBase<Prato>, IPratoServico
    {
        public PratoServico(IRepositorioBase<Prato> repositorio) : base(repositorio)
        {
        }
    }
}
