using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected List<T> Entidade = new List<T>();

        public void Add(T entidade) => Entidade.Add(entidade);
        public ICollection<T> GetAll() => Entidade;
        public void Remove(T entidade) => Entidade.Remove(entidade);
        public virtual void Update(T entidade) { }
    }
}