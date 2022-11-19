#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int num, resto;
	
	printf("Digite um numero: ");	//	57
	scanf("%d", &num);
	
	resto = num % 2; //	resto=57%2=1
	
	if(resto == 1) {
		printf("O numero %d eh impar! \n", num);
	}
	else {
		printf("O numero %d eh par! \n", num);
	}
	
	return 0;
}
