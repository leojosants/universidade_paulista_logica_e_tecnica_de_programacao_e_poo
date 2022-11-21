algoritmo "semnome"

funcao fatorial(n: inteiro): inteiro
       var
       i, fat: inteiro

       inicio
             fat <- 1
             
             para i de 1 ate n faca
                  fat <- fat * i
             fimpara
             
             retorne fat
       fimfuncao
       
var
   n: inteiro

inicio
      n <- 5
      escreva(fatorial(n))



fimalgoritmo
