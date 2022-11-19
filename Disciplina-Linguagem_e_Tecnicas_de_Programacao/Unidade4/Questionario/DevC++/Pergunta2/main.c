#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int idade, contador21 = 0, contador50 = 0;
	
	printf("Digite a idade: ");
	scanf("%d", &idade);
	
	while( idade != -99 ) {
		
		if( idade < 21 ) {
			contador21++;	
		}
		else if( idade > 50 ) {
			contador50++;
		}
			
			printf("Digite a idade ou [-99 para encerrar]: ");
			scanf("%d", &idade);
	}
		
	printf("\nO total de pessoas com menos de 21 anos eh: %d", contador21);
	printf("\nO total de pessoas com menos de 50 anos eh: %d", contador50);
			
	return 0;
}
