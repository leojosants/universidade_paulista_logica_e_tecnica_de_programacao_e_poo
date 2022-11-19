#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int num;
	
	printf("\n\nDigite um numero entre 1 e 4: ");
	scanf("%d", &num);
	
	while( num < 1 || num > 4 ) {
		printf("\nNumero invalido!");
		
		printf("\nDigite novamente: ");
		scanf("%d", &num);
	}

	printf("\n\nO numero digitado eh: %d", num);

	return 0;
}
