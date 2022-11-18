algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   result1, result2, result3: inteiro
   num, resto1, resto2: inteiro

inicio
// Seção de Comandos
   escreva("Digite um numero de tres digitos: ") // 856
   leia(num)
   
   result1 <- num div 100
   resto1 <- num mod 100

   result2 <- resto1 div 10
   resto2 <- resto1 mod 10
   
   result3 <- resto2 div 1
   
   escreval("A inversao do numero digitado eh: ", result3, result2, result1)
   
 
fimalgoritmo
