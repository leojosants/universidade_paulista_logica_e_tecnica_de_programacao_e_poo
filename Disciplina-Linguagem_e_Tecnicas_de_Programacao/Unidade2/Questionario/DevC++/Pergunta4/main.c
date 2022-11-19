#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 15;
	int b = 3;
	
	b /= a;
//	printf("B: %d \n", b);	//	0
	
	printf("A: %d, B: %d \n", a, b);	//	15, 0
	
	a = b++;
//	printf("A: %d \n", a);	//	0
	
	printf("A: %d, B: %d \n", a, b);	//	5, 1

	return 0;
}
