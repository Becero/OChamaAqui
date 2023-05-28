using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OChamaAqui.DATA.Interfaces
{
    internal interface IRepositoryModel<T> where T: class
    {
        List<T> SelecionarTodos();
        T SelecionarPk(params object[] variavel );

        T Incluir(T objetc);
        T Alterar(T objetc);
        void Excluir(T objetc);
        void Excluir(params object[] variavel);
        void SaveChanges();

    }
}
