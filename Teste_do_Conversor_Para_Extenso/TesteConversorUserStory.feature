Feature: Teste Conversor de Real Para Extenso
	Testar se a classe que converte os valores em real
	Para extenso está funcinando corretamente.

@mytag
Scenario: Teste Com Sucesso
	Given um livro que custa 29.90 reais
	When eu solicitar a conversão do valor para extenso
	Then o programa retornará a string VINTE E NOVE REAIS E NOVENTA CENTAVOS

Scenario: Teste Com Falha
	Given um livro que custa 39.90 reais
	When eu solicitar a conversão do valor para extenso
	Then o programa retornará a string TRINTA E NOVE REAIS E OITENTA CENTAVOS
