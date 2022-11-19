#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int s = 0;
	int x;
	
	for( x = 1; x <= 100; x++ ) {
		s = s + x;
	}
	
	printf("\nResultado: %d", s);
	

	return 0;
}
