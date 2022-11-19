#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int i, result, ant = 0, prox = 1;
	
	for( i = 0; i < 10; i++ ) {
		result = ant + prox;
		ant = prox;
		prox = result;
		printf("Iteracao %d: %d \n", i, result);
	}

	return 0;
}
