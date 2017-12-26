using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.ViewModel;
using Biblioteca.Controllers;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Collections.ObjectModel;
using Biblioteca.Models;

namespace Teste_Biblioteca
{
    [TestClass]
    public class UnitTest1
    {
        string resultadoTeste = "";
        string resultadoEsperado = "";
        double valorTeste;

        //Testes bem Sucedidos conversor de real para valor em extenso
        [TestMethod]
        public void Teste_Conversor_Real_para_String()
        {
            
            this.valorTeste = 39.90;
            this.resultadoEsperado = "TRINTA E NOVE REAIS E NOVENTA CENTAVOS";

            resultadoTeste = ConversorViewModel.EscreverExtenso(this.valorTeste);

            Assert.AreEqual(this.resultadoTeste, resultadoEsperado);
        }

        [TestMethod]
        public void Segundo_Teste_Conversor_Real_para_String()
        {

            this.valorTeste = 24.49;
            this.resultadoEsperado = "VINTE E QUATRO REAIS E QUARENTA E NOVE CENTAVOS";

            resultadoTeste = ConversorViewModel.EscreverExtenso(this.valorTeste);

            Assert.AreEqual(this.resultadoTeste, resultadoEsperado);
        }

        //Teste com falha conversor de real para valor em extenso
        [TestMethod]
        public void Teste_Com_Falha_Conversor_Real_para_String()
        {
            //Valor esperado digitado errado, o valor correto seria TRINTA E NOVE REAIS E CINQUENTA CENTAVOS
            this.valorTeste = 39.50;
            this.resultadoEsperado = "TRINTA E NOVE REAIS E CINQUENTA E CINCO CENTAVOS";

            resultadoTeste = ConversorViewModel.EscreverExtenso(this.valorTeste);

            Assert.AreEqual(this.resultadoTeste, resultadoEsperado);
        }


    }
}
