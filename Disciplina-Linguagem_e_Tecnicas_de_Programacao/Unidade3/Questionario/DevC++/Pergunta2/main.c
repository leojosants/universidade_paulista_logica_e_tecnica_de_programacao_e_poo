#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a, b, c;
	int aux;
	
//	printf("Digite tres numeros inteiros: ");
//	scanf("%d %d %d", &a, &b, &c);

	printf("Digite tres numeros inteiros: \n");
	
	printf("Primeiro numero inteiro: ");	//	1
	scanf("%d", &a);

	printf("Segundo numero inteiro: ");		//	2
	scanf("%d", &b);
	
	printf("Terceiro numero inteiro: ");	//	3
	scanf("%d", &c);
	
	if(a > b) {		//	a=1	b=2		(a>b)=f
		aux = a;
		a = b;
		b = aux;
	}

	if(a > c) {		//	a=1 c=3		(a>c)=f
		aux = a;
		a = c;
		c = aux;
	}
	
	if(b > c) {		//	b=2 c=3		(b>c)=f
		aux = b;
		b = c;
		c = aux;
	}
	
	printf("A: %d, B: %d, C: %d \n", a, b, c);	//	a=1	b=2	c=3

	return 0;
}
