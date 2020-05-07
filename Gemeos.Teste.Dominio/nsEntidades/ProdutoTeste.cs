using aula_wpf_14_04_2020.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemeos.Teste.Dominio.nsEntidades
{
    [TestClass]
    public class ProdutoTeste
    {
        private const string _dono = "Juliano Maciel";
        private const string _categoria = "Produto";


        [Owner(_dono)]
        [TestCategory(_categoria)]
        [TestMethod]
        public void Produto_Criar_ExceptionDescricaoInvalida()
        {
            Assert.ThrowsException<ArgumentException>(() => new Produto(string.Empty, 10.00m));
        }

        [Owner(_dono)]
        [TestCategory(_categoria)]
        [TestMethod]
        public void Produto_Criar_ExceptionValorInvalido()
        {
            Assert.ThrowsException<ArgumentException>(() => new Produto("TESTE 2", 0.00m));
        }

        [Owner(_dono)]
        [TestCategory(_categoria)]
        [TestMethod]
        public void Produto_Criar_Valido()
        {
            var produto = new Produto("TESTE 3", 10.00m);

            //Assert.IsTrue(!string.IsNullOrEmpty(produto.Id.ToString()));
            Assert.IsFalse(string.IsNullOrEmpty(produto.Id.ToString()));
        }
    }
}