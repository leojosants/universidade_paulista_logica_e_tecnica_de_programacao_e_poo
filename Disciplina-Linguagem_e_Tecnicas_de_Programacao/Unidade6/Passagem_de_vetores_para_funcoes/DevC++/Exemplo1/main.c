#include <stdio.h>
#include <stdlib.h>

void incrVetor( int n, int *v ) {
	
	int i;
	
	for( i = 0; i < n; i++ ) {
		v[i]++;
	}
}

int main(int argc, char *argv[]) {

	int i;
	
	int a[] = { 1, 3, 5 };

	incrVetor(3, a);
	
	printf("Impressao convencional: \n");
	
	printf("a[0] = %d, a[1] = %d, a[2] = %d \n\n", a[0], a[1], a[2]);

	printf("Impressao por FOR: \n");
	
	for( i = 0; i < 3; i++ ) {
		printf("a[%d] = %d", i, a[i]);
	}

	return 0;
}
