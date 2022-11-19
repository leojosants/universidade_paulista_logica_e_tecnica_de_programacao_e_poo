algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   x, y: real
   z, w: caracter
   t, k: logico

inicio
// Seção de Comandos 
   x <- 3
   y <- (3 * 3) + ((14 + 4) / 2) * 9 - 10
   z <- "Logica"
   w <- z + "Programacao"
   t <- (x <= y) E (NAO (y <> x)) = (y > x)
   k <- NAO t OU (x > y)
   
   escreval("T: ", t)
   escreval("K: ", k)

fimalgoritmo
