using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wpf_14_04_2020.Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public Produto() { }

        public Produto(string descricao, decimal valor)
        {
            Id = Guid.NewGuid();
            SetDescricao(descricao);
            SetValor(valor);
        }

        public void SetDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("Descrição inválida para o produto.");

            Descricao = descricao;
        }

        public void SetValor(decimal valor)
        {
            if (valor <= 0.0m)
                throw new ArgumentException("Valor inválido parao produto.");

            Valor = valor;
        }
    }
}