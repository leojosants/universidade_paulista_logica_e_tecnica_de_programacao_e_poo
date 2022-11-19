#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int num = 1;
	
	while( num != 0 ) {
		printf("Digite um numero diferente de zero: ");
		scanf("%d", &num);
		
		printf("Numero digitado: %d \n\n", num);
	}
	
	printf("Numero digitado: %d \n", num);
	printf("Programa Finalizado!");

	return 0;
}
