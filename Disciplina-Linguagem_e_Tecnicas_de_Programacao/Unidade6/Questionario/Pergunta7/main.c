#include <stdio.h>
#include <stdlib.h>

int f2(int n) {

	if(n == 0) {
		printf("zero");
	}
	else {
		printf("%d", n);
		f2(n - 1);
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
