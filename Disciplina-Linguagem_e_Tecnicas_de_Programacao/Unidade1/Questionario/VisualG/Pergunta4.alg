algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 18/11/2022
// Se��o de Declara��es 

var
   precoUnit, precoTotal: real
   quant: inteiro

inicio
// Se��o de Comandos
   escreva("Digite o preco unitario: R$ ")
   leia(precoUnit)
   
   escreva("Digite a quantidade: ")
   leia(quant)
   
   precoTotal <- precoUnit * quant * 1.25
   
   escreva("precoTotal = R$ ", precoTotal)


fimalgoritmo
