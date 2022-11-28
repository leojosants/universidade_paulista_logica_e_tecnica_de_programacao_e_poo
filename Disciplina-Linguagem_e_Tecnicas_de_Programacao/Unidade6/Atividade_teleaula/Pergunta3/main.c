#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

	int *ptr;
	int valor = 10;
	
	ptr = &valor;
	
	printf("Endereco = %x \n", &valor);
	printf("Endereco = %x \n", ptr);
	printf("Valor = %d \n", *ptr);

	return EXIT_SUCCESS;

}
