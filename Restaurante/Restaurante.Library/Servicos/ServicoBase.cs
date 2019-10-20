﻿using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace Restaurante.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> _repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            _repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            _repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            _repositorio.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return _repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return _repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return _repositorio.SelecionarTodos();
        }
    }
}
