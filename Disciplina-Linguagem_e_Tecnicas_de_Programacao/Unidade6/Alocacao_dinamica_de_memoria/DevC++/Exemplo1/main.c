#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

//	int * v;
//	v = ( int* ) malloc( 10*sizeof(int) );
//	
//	EQUIVALE A int v[10];

	int *v;
	
	v = (int *) malloc(10 * sizeof(int));

	return 0;
}
