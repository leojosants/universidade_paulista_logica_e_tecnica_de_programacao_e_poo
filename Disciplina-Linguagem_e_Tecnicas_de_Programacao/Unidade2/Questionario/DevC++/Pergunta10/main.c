#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 15;
	int b = 2;
	
	b *= a;		//	b=b*a=2*15=30
	
	printf("A: %d, B: %d", a, b);	//	a=15, b=30
	
	b = a--;	//	b=15, a=15-1=14
	
	printf("A: %d, B: %d", a, b);	//	a=14, b=15

	return 0;
}
