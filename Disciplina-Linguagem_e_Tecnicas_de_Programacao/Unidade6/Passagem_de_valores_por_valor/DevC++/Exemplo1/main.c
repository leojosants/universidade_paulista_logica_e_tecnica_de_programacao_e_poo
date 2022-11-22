#include <stdio.h>
#include <stdlib.h>

void troca(int a, int b) {
	int temp;
	temp = a;
	a = b;
	b = temp;
}

int main(int argc, char *argv[]) {
	
	int a = 7, b = 5;
	troca(a, b);
	printf("\na: %d \nb: %d \n", a, b);	

	return 0;
}
