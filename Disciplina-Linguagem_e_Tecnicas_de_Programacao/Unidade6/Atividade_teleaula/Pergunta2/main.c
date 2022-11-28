#include <stdio.h>
#include <stdlib.h>

void troca(int a, int b) {

	int temp;
	temp = a;	//	temp=2
	a = b;		//	a=3
	b = temp;	//	b=2
	
}

int main(int argc, char *argv[]) {

	int a = 2, b = 3;
	
	printf("Antes de chamar a funcao: a=%d\n", a);	//	2
	printf("Antes de chamar a funcao: b=%d\n", b);	//	3
	
	troca(a, b);

	printf("Depois de chamar a funcao: a=%d\n", a);	//	2
	printf("Depois de chamar a funcao: b=%d\n", b);	//	3
	
	return 0;

}
