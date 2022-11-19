#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int idade;
	
	printf("Digite sua idade: ");
	scanf("%d", &idade);
	
	if( (idade >= 18) && (idade <= 67) ) {
		printf("Permitido doar sangue \n");
	}
	else {
		printf("Nao e permitido doar sangue \n");
	}

	return 0;
}
