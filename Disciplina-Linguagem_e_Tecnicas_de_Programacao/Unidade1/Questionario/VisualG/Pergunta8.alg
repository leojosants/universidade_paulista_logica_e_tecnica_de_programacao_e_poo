algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   a, b: inteiro
   aux: inteiro

inicio
// Seção de Comandos 
   escreva("Entre com o valor A: ") // 5
   leia(a)
   
   escreva("Entre com o valor B: ") // 15
   leia(b)
   
   aux <- a       // aux=5
   a <- b         // a=15
   b <- aux       // b=5
   
   escreval("O valor de A eh: ", a, " e o valor de B eh: ", b)

fimalgoritmo
