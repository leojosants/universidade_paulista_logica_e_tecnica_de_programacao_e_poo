#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int x;
	
	for( x = 1; x <= 19; x++ ) {
		printf("%c", '*');
	}
	
	printf("\n");

	for( x = 0; x <= 14; x = x + 2 ) {
		printf("%d ", x);
	}
	
	printf("\n");

	for( x = 1; x <= 19; x++ ) {
		printf("%c", '*');
	}

	return 0;
}
