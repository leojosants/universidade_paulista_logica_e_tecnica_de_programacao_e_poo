#include <stdio.h>
#include <stdlib.h>

int fatorial(int n) {
	
	int i, fat;
	fat = 1;
	
	for( i = 1; i <= n; i++ ) {
		fat = fat * i;
	}
	
	return fat;
}

int main(int argc, char *argv[]) {

	int n = 5;
	
	printf("O fatorial de %d eh: %d", n, fatorial(n));

	return 0;
}
