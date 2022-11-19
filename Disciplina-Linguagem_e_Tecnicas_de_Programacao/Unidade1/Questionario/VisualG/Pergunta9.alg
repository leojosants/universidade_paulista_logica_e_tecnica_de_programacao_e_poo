algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   x, y: inteiro
   result1, result2: inteiro
   result3, result4: real

inicio
// Seção de Comandos 
   escreva("Digite o primeiro numero: ") // 23
   leia(x)

   escreva("Digite o segundo numero: ") // 42
   leia(y)
   
   result1 <- x + y  // 65
   result2 <- x - y  // -19
   result3 <- y / 2  // 21
   result4 <- (x + 2) * y // (25) * 42 = 1.050
   
   escreval("Os resultados das operacoes sao:")
   escreval("result4: ", result4)
   escreval("result3: ", result3)
   escreval("result2: ", result2)
   escreval("result1: ", result1)

fimalgoritmo
