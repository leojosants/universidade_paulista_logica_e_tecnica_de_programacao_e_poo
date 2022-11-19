#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int x, y;
	
	printf("Digite o primeiro numero: ");
	scanf("%d", &x);

	printf("Digite o segundo numero: ");
	scanf("%d", &y);
	
	if(x > y) {
		printf("O numero %d eh maior que o número %d! \n", x, y);
	}
	else {
		printf("O numero %d eh menor que o número %d! \n", x, y);
	}

	return 0;
}
