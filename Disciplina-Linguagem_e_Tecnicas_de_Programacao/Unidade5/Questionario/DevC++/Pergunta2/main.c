#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char *argv[]) {

	int x, tam, ca, ce, ci, co, cu;
	char nome[30];
	ca = ce = ci = co = cu = 0;
	
	printf("Digite a frase [Universidade Paulista]: ");
	gets(nome);
	
	tam = strlen(nome);
	
	for( x = 1; x <= (tam-1); x++ ) {
		if( nome[x] == 'a' || nome[x] == 'A' ) 
			ca++;
		else
			if( nome[x] == 'e' || nome[x] == 'E' )
				ce++;
			else 
				if( nome[x] == 'i' || nome[x] == 'I' ) 
					ci++;
				else  
					if( nome[x] == 'o' || nome[x] == 'O' ) 
						co++;
					else 
						if( nome[x] == 'u' || nome[x] == 'U' ) 	
							cu++;				
	}
	
	printf("%d: a \n", ca);
	printf("%d: e \n", ce);
	printf("%d: i \n", ci);
	printf("%d: o \n", co);
	printf("%d: u \n", cu);
	printf("\n\n");
	
	system("pause");

	return 0;
}
