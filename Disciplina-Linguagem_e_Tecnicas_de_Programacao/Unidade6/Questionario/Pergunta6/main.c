#include <stdio.h>
#include <stdlib.h>

int f1(int n) {

	if(n == 0) {
		return(1);
	}
	else {
		return(n * f1(n - 1));
	}

}


int main(int argc, char *argv[]) {

	int a, b;
	
	printf("Digite um valor inteiro: ");
	scanf("%d", &a);
	
	b = f1(a);
	
	printf("%d", b);

	return 0;
}
