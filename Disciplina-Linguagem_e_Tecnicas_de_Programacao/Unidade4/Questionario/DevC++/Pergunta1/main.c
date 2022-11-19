#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int i = 1;
	int num, result = 0;
	
	printf("Digite 10 numeros:  \n\n");
	
	while( i <= 10 ) {	//	esse bloco será executado ENQUANTO i <= 10
		printf("Digite o numero para a posicao %d: ", i);
		scanf("%d", &num);
		
		result += num;	//	result recebendo a cada interacao o acumulo do proprio valor + num
		i++;	//	i recebendo a cada interacao o o valor proprio + 1
	}
	
	printf("Resultado: %d", result);
	
	return 0;
}
