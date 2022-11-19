#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int ano1995, ano1996, ano1997;
	
	printf("Digite um ano como entrara [1995]: ");	//	1995
	scanf("%d", &ano1995);

	printf("Digite um ano como entrara [1996]: ");	//	1996
	scanf("%d", &ano1996);
	
		printf("Digite um ano como entrara [1997]: ");	//	1997
	scanf("%d", &ano1997);	
	
	if(ano1995 % 100 == 0) {
		
		if(ano1995 % 400 == 0) {
			printf("O ano %d eh bissexto \n\n", ano1995);
		}
		else {
			printf("O ano %d nao eh bissexto \n\n", ano1995);
		}		
	}
	else {
		
		if(ano1995 % 4 == 0) {
			printf("O ano %d eh bissexto \n\n", ano1995);
		}
		else {
			printf("O ano %d nao eh bissexto \n\n", ano1995);
		}
		
	}

	if(ano1996 % 100 == 0) {
		
		if(ano1996 % 400 == 0) {
			printf("O ano %d eh bissexto \n\n", ano1996);
		}
		else {
			printf("O ano %d nao eh bissexto \n\n", ano1996);
		}		
	}
	else {
		
		if(ano1996 % 4 == 0) {
			printf("O ano %d eh bissexto \n\n", ano1996);
		}
		else {
			printf("O ano %d nao eh bissexto \n\n", ano1996);
		}
		
	}
	
	if(ano1997 % 100 == 0) {
		
		if(ano1997 % 400 == 0) {
			printf("O ano %d eh bissexto \n\n", ano1997);
		}
		else {
			printf("O ano %d nao eh bissexto \n\n", ano1997);
		}		
	}
	else {
		
		if(ano1997 % 4 == 0) {
			printf("O ano %d eh bissexto \n\n", ano1997);
		}
		else {
			printf("O ano %d nao eh bissexto \n\n", ano1997);
		}
		
	}
	
	return 0;
}
