algoritmo "semnome"
// Função :
// Autor :
// Data : 18/11/2022
// Seção de Declarações 

var
   salarioAtualDePedro, reajusteDePedro, novoSalarioDePedro: real
   salarioAtualDeMaria, reajusteDeMaria, novoSalarioDeMaria: real

inicio
// Seção de Comandos
   escreva("Digite o salario atual de Pedro: R$ ") // R$ 2500,00
   leia(salarioAtualDePedro)

   escreva("Digite o valor (percentual) do reajuste (%) de Pedro: ") // 2.0
   leia(reajusteDePedro)

   novoSalarioDePedro <- salarioAtualDePedro + (salarioAtualDePedro / 100) * reajusteDePedro
   
   escreva("Digite o salario atual de Maria: R$ ") //  Maria R$ 1640,00;
   leia(salarioAtualDeMaria)

   escreva("Digite o valor (percentual) do reajuste (%) de Maria: ") // 1.5
   leia(reajusteDeMaria)

   novoSalarioDeMaria <- salarioAtualDeMaria + (salarioAtualDeMaria / 100) * reajusteDeMaria

   escreval("O novo salario de Pedro eh: R$ ", novoSalarioDePedro)
   escreval("O novo salario de Maria eh: R$ ", novoSalarioDeMaria)

fimalgoritmo
