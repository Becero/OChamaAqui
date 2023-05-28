using Microsoft.EntityFrameworkCore;
using OChamaAqui.DATA.Interfaces;
using OChamaAqui.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OChamaAqui.DATA.Repositories
{
    //Serve para criar um repositorio generico que sera a base de tudo.

    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected OChamaAquiContext _Contexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool sabeChanges = true)
        {
            _SaveChanges = sabeChanges;
            _Contexto = new OChamaAquiContext();
        }

        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }

        public void Excluir(T objeto)
        {
            _Contexto.Set<T>().Remove(objeto);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);
        }

        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;

        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }
    }
    
}
