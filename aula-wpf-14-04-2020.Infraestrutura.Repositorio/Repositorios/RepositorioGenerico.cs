using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Contexto;
using aula_wpf_14_04_2020.Infraestrutura.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Infraestrutura.Repositorio.Repositorios
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        private GemeosContext Context { get; set; }
        protected DbSet<T> Entidade => Context.Set<T>();

        public RepositorioGenerico(GemeosContext gemeosContext)
            => Context = gemeosContext ?? throw new ArgumentNullException(nameof(gemeosContext));

        public void AddOrUpdate(T entidade) => Entidade.AddOrUpdate(entidade);
        public IEnumerable<T> GetAll() => Entidade.AsEnumerable();
        public void Remove(T entidade) => Entidade.Remove(entidade);
        public void SaveChanges() => Context.SaveChanges();
    }
}