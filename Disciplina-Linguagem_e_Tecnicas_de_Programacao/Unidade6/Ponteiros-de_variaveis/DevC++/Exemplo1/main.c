#include <stdio.h>
#include <stdlib.h>


int main(int argc, char *argv[]) {
	
//	Declaracao:
//		<tipo> 	*nome;
//		int 	*p
	
//	Acesso aos enderecos na memoria:
//		& ("endereco de)
//		* (conteudo de)

	int a;
	printf("&a: %d \n", &a);
	
	int *p;
	
	a = 5;
	printf("a = 5: %d \n", a);

	p = &a;
	printf("p = &a: %d \n", p);
	
	*p = 6;
	printf("*p = 6: %d \n", *p);
	printf("&p: %d \n", &p);
	
	printf("a: %d \n", a);
	
		
	return 0;
}
