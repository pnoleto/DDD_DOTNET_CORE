using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using System.Collections.Generic;

namespace Restaurante.Aplicacao.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO> where TEntidade : EntidadeBase where TEntidadeDTO : BaseDTO
    {
        int Incluir(TEntidadeDTO entidade);
        void Excluir(int id);
        void Excluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        TEntidadeDTO SelecionarPorId(int id);
        IEnumerable<TEntidadeDTO> SelecionarTodos();
    }
}
