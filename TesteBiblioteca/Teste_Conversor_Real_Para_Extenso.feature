Funcionalidade: Teste Conversor de Real Para Extenso
	Testar se a classe que converte os valores em real
	Para extenso está funcinando corretamente.


Cenario: TesteComSucesso1
	Dados um livro que custa 29.90 reais
	Quando eu solicitar a conversão do valor para extenso
	Entao o programa retornará a string VINTE E NOVE REAIS E NOVENTA CENTAVOS

Cenario: TesteSemSucesso1
	Dados um livro que custa 39.90 reais
	Quando eu solicitar a conversão do valor para extenso
	Entao o programa retornará a string TRINTA E NOVE REAIS E OITENTA CENTAVOS
