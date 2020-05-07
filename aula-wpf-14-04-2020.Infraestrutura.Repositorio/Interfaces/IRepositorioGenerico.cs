using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces
{
    public interface IRepositorioGenerico<T> where T : class
    {
        void AddOrUpdate(T entidade);
        void Remove(T entidade);
        IEnumerable<T> GetAll();
        void SaveChanges();
    }
}