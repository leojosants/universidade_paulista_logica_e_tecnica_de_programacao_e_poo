#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int verificaVogal(char m) {
	if( m == 'a' || m =='A' || m == 'e' || m =='E' || m == 'i' || m =='I' || m == 'o' || m =='O' || m == 'u' || m =='U' ) {
		return(1);		
	}
	else {
		return(0);
	}
}

int main(int argc, char *argv[]) {

	char x;
	
	printf("Digite uma letra: ");
	scanf("%c", &x);
	
	if( verificaVogal(x) == 1 ) {
		printf("\nA letra [%c] eh uma vogal: ", x);
	}
	else {
		printf("\nA letra [%c] eh uma consoante: ", x);
	}
	
	printf("\n\n");
	
	system("pause");

	return 0;
}
