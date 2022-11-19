#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int i = 0;
	int ii;
	
	printf("Laco WHILE -> ");
	while( i < 10 ) {
		printf("%d ", i);
		i++;
	}
	
	printf("\nLaco FOR   -> ");
	for( ii = 0; ii < 10; ii++ ) {
		printf("%d ", ii);
	}
	
	return 0;
}
