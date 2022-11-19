algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   a, b, c, d: inteiro
   resultado: logico

inicio
// Seção de Comandos
   a <- 1
   escreval("a = ", a)

   b <- 2
   escreval("b = ", b)
   
   c <- 3
   escreval("c = ", c)
   
   d <- 4
   escreval("d = ", d)
   
   resultado <- (a > b) E (b > c) OU ((c + d * a) < (d - c * 2))
   
   escreval("(a > b) = ", (a > b))
   escreval("(b > c) = ", (b > c))
   escreval("(a > b) E (b > c) = ", (a > b) E (b > c))
   escreval("(c + d * a) = ", (c + d * a))
   escreval("(d - c * 2) = ", (d - c * 2))
   escreval("((c + d * a) < (d - c * 2)) = ", ((c + d * a) < (d - c * 2)))
   escreval("(a > b) E (b > c) OU ((c + d * a) < (d - c * 2)) = ", resultado)
   
   escreva("O resultado eh: ", resultado)

fimalgoritmo
