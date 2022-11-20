#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int x, i, soma = 0;
	int y = 10;
	
	for( i = 0; i < y; i++ ) {
		printf("Digite o item %d: ", i);	//	i=0	i=1	i=2
		scanf("%d", &x);
		
		soma = soma + x;
		
		printf("Y: %d \n", y);
		y = y - 1;	//	y=10  y=9	y=8
		printf("Y: %d \n", y);
	}
	
	printf("Total: %d", soma);

	return 0;
}
