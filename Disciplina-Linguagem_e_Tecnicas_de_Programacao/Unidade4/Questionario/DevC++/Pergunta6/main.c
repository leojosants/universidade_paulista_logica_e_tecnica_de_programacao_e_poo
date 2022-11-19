#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int vi, vf, x;
	
	printf("Inicio: ");	//	6
	scanf("%d", &vi);
	
	printf("Fim: ");	//	14
	scanf("%d", &vf);
	
	printf("\n");
	for( x = vi; x <= vf; x+=2 ) {
		printf("%d ", x);
	}

	return 0;
}
