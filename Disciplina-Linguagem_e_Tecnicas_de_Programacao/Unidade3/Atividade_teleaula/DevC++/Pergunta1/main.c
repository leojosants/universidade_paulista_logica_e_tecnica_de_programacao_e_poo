#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int n1, n2, n3;
	
	n1 = 1;
	n2 = 2;
	n3 = 0;
	
	//	condicao para que seja impresso 'O maior eh n2'
	
	if( n1 > n2 ) {		//	(n1>n2) = (1>2) => falso, nao executa esse IF e vai para o ELSE linha 25
		
		if( n1 > n3 ) {
			printf("O maior eh %d \n", n1);
		}
		else {
			printf("O maior eh %d \n", n3);
		}
	}
	else {		//	entre nesse ELSE
		
		if( n1 > n3 ) {		//	(n1>n3) => (1>0) => verdadeiro
			printf("O maior eh %d \n", n2);		// vai imprimir essa linha
		}
		else {
			printf("O maior eh %d \n", n3);
		}		
	}
	
	return 0;
}
