#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[]) {

	char cadeia[256];
	int x, tam;
	
	printf("Digite um texto: ");
	gets(cadeia);
	
	tam = strlen(cadeia);
	
	for( x = 0; x <= tam; x++ ) {
		if( cadeia[x] != 'a' && cadeia[x] != 'e' && cadeia[x] != 'i' && cadeia[x] != 'o' && cadeia[x] != 'u' ) {
			printf("%c", cadeia[x]);			
		}
	}
	
	printf("\n");

	system("pause");

	return 0;
}
