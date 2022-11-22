#include <stdio.h>
#include <stdlib.h>

int func (int n) {
	
	if (n == 0)
		return(0);
	
	return(3*n + func(n-1));
}

int main(int argc, char *argv[]) {

	int a, b;

	printf("Digite um valor inteiro:");
	scanf("%d", &a);

	b= func(a);

	printf ("%d \n", b);

	return 0;
}
