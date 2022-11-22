#include <stdio.h>
#include <stdlib.h>

int mult(int x, int y) {
	
	if(y == 1) {
		return(x);
	}
	else {
		return(x + mult(x, y - 1));
	}
	
}

int main(int argc, char *argv[]) {

	printf("\n%d x %d = %d", 2, 3, mult(2, 3));

	return 0;
}
