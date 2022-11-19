#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int idade10, idade36;
	
	printf("Digite a idade [36]: ");	//	36
	scanf("%d", &idade36);
	
	printf("Digite a idade [10]: ");	//	10
	scanf("%d", &idade10);
	
	printf("\n");
	if( idade36 == 36 ) {
		if( idade36 < 10 ) {
			printf("A idade %d eh classificada como CRIANCA \n\n", idade36);
		}
		else if( (idade36 >= 10) && (idade36 <= 14) ) {
			printf("A idade %d eh classificada como INFANTIL \n\n", idade36);
		} 
		else if( (idade36 >= 15) && (idade36 <= 17) ) {
			printf("A idade %d eh classificada como JUVENIL \n\n", idade36);
		} 
		else if( idade36 > 18 ) {
			printf("A idade %d eh classificada como ADULTO \n\n", idade36);
		} 
		else {
			printf("Classificacao invalida\n");
		}
	}
	

	if( idade10 == 10 ) {
		if( idade10 < 10 ) {
			printf("A idade %d eh classificada como CRIANCA \n\n", idade10);
		}
		else if( (idade10 >= 10) && (idade10 <= 14) ) {
			printf("A idade %d eh classificada como INFANTIL \n\n", idade10);
		} 
		else if( (idade10 >= 15) && (idade10 <= 17) ) {
			printf("A idade %d eh classificada como JUVENIL \n\n", idade10);
		} 
		else if( idade10 > 18 ) {
			printf("A idade %d eh classificada como ADULTO \n\n", idade10);
		} 
		else {
			printf("Classificacao invalida");
		}
	}
	
	return 0;
}
