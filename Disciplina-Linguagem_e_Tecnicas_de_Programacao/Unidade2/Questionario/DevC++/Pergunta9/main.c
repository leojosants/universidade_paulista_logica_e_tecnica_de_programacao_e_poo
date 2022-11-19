#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 8;
	int b;
	
	b = ++a;	//	b=0+9=9
	
	printf("A: %d, B: %d \n", a, b);	//	a=9, b=9
	
	b = a++;	//	b=9
	
	printf("A: %d, B: %d \n", a, b);	//	a=10, b=9

	return 0;
}
