#include <stdio.h>
#include <stdlib.h>

void incrVetor(int *v, int tam) {
	
	int i;
	
	for(i = 0; i < tam; i++) {
		v[i]++;
	}
	
}

int main(int argc, char *argv[]) {

	int a[] = { 1, 3, 5 };
	
	incrVetor(a, 3);
	
	printf("%d %d %d\n", a[0], a[1], a[2]);

	return 0;
}
