algoritmo "semnome"
// Fun��o :
// Autor :
// Data : 18/11/2022
// Se��o de Declara��es 

var
   x, y: real
   z, w: caracter
   t, k: logico

inicio
// Se��o de Comandos 
   x <- 3
   y <- (3 * 3) + ((14 + 4) / 2) * 9 - 10
   z <- "Logica"
   w <- z + "Programacao"
   t <- (x <= y) E (NAO (y <> x)) = (y > x)
   k <- NAO t OU (x > y)
   
   escreval("T: ", t)
   escreval("K: ", k)

fimalgoritmo
