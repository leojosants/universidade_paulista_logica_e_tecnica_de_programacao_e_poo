algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 
var
   saldo, total: real

inicio
// Seção de Comandos 
   escreva("Digite o saldo: R$ ")
   leia(saldo)
   
   total <- saldo + (saldo * 5) / 100
   
   escreval("O saldo atual com rendimento de 5% eh: R$ ", total)


fimalgoritmo
