using System.Collections.Generic;
using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Servicos;

namespace Restaurante.Aplicacao.Servicos
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase where TEntidadeDTO : BaseDTO
    {
        protected readonly IServicoBase<TEntidade> _servico;
        protected readonly IMapper _mapper;

        public ServicoAppBase(IMapper mapper, IServicoBase<TEntidade> servico)
        {
            _servico = servico;
            _mapper = mapper;
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            _servico.Alterar(_mapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id)
        {
            _servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            _servico.Excluir(_mapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            throw new System.NotImplementedException();
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
