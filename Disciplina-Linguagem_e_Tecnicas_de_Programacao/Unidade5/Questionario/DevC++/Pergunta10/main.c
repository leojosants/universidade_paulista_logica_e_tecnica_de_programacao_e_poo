#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

	int x, vet[8], num, achei=0;
	
	for( x = 0; x < 8; x++ ) {
		printf("[%d] Digite um numero: ", x);
		scanf("%d", &vet[x]);
	}
	
	printf("\n\n");
	
	printf("Digite o valor a ser pesquisado: ");
	scanf("%d", &num);
	
	for( x = 0; x < 8; x++ ) {
		if( vet[x] == num ) {
			printf("O numero %d se encontra na posicao %d \n", num, x);
			achei=1;
		}
	}
	
	if(achei != 1) {
		printf("\nEste numero nao existe");
	}
	
	printf("\n\n");
	system("pause");

	return 0;
}
