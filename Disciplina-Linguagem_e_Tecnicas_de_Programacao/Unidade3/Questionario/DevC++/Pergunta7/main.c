#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	char ch;
	
	printf("\n");
	printf("Opcoes de Estado Civil: \n\n");
	printf("[C] -> Casado \n");
	printf("[S] -> Solteiro \n");
	printf("[D] -> Divorciado \n");
	printf("[V] -> viuvo \n\n");
	
	printf("Escolha uma opcao: ");	//	C	s	V
	scanf("%c", &ch);
	
	switch(ch) {
		case 'C':
			printf("Casado \n");
			break;
			
		case 'S':
			printf("Solteiro \n");
			break;
			
		case 'D':
			printf("Divorciado \n");
			break;
			
		case 'V':
			printf("Viuvo \n");
			break;
			
		default:
			printf("Opcao invalida \n");
			break;
	}	

	return 0;
}
