#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int x, inferior, superior;
	
	printf("Digite o valor do limite inferior: ");	//	6
	scanf("%d", &inferior);

	printf("Digite o valor do limite superior: ");	//	14
	scanf("%d", &superior);
	
	printf("\n");
	for( x = inferior; x <= superior; x++ ) {
		printf("%d ", x);
	}

	return 0;
}
