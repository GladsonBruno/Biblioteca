using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Biblioteca.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteBiblioteca
{
    [Binding]
    public sealed class Teste_Real_Para_Extenso_StepDefinition
    {
        decimal _preco;
        string _resultado;

        [Given("um livro que custa (.*) reias")]
        public void CarregaPreco(decimal preco)
        {
            this._preco = preco;
        }

        [When("eu solicitar a conversão do valor para extenso")]
        public void ConverterParaExtenso()
        {
            this._resultado = ConversorViewModel.EscreverExtenso(this._preco);
        }

        [Then("o programa retornará a string ''(.*)''")]
        public void VerificarResultado(string resultado)
        {
            Assert.AreEqual(this._resultado, resultado);
        }
    }
}
