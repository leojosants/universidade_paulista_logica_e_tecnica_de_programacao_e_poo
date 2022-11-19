#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int 	totalFaltas;
	float 	n1, n2, media;
	
	printf("Digite a primeira nota: ");		//	5
	scanf("%f", &n1);

	printf("Digite a segunda nota: ");		//	6
	scanf("%f", &n2);
	
	printf("Digite o total de faltas: ");	//	12
	scanf("%f", &totalFaltas);
	
	media = (n1 + n2) / 2;	//	media=(n1+n2)/2 => (5+6)/2 => 11/2 => media=5.5
	
	if( media >= 5 ) {		//	media=5.5 => verdadeiro
		printf("Aprovado por nota");	//	vai imprimir
		
		if( totalFaltas <= 10 ) {		//(totalFaltas<=10) => (12<=10) => falso pula pro else linha 29
			printf(" e esta aprovado! \n");
		}
		else {
			printf(", mas reprovou por falta! \n");		// vai imprimir
		}
	}
	else {
		printf("Nota abaixo da media!");
	}

	return 0;
}
