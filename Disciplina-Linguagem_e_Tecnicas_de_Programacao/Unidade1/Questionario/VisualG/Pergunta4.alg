algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   precoUnit, precoTotal: real
   quant: inteiro

inicio
// Seção de Comandos
   escreva("Digite o preco unitario: R$ ")
   leia(precoUnit)
   
   escreva("Digite a quantidade: ")
   leia(quant)
   
   precoTotal <- precoUnit * quant * 1.25
   
   escreva("precoTotal = R$ ", precoTotal)


fimalgoritmo
