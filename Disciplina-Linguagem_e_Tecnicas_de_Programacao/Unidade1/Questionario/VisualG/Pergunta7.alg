algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 18/11/2022
// Se��o de Declara��es 
var
   saldo, total: real

inicio
// Se��o de Comandos 
   escreva("Digite o saldo: R$ ")
   leia(saldo)
   
   total <- saldo + (saldo * 5) / 100
   
   escreval("O saldo atual com rendimento de 5% eh: R$ ", total)


fimalgoritmo
