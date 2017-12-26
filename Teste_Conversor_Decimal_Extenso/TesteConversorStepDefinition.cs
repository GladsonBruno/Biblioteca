using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using Biblioteca.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_Conversor_Decimal_Extenso
{
    [Binding]
    public sealed class TesteConversorStepDefinition
    {
        decimal _preco;
        string _resultado;

        [Given("um livro que custa (.*) reais")]
        public void PegarPreco(decimal preco)
        {
            this._preco = preco;
        }

        [When("eu solicitar a conversão do valor para extenso")]
        public void ConverterParaExtenso()
        {
            _resultado = ConversorViewModel.EscreverExtenso(_preco);
        }

        [Then("o programa retornará a string ''(.*)''")]
        public void ThenTheResultShouldBe(string resultado)
        {
            Assert.AreEqual(_resultado, resultado);
        }
    }
}
