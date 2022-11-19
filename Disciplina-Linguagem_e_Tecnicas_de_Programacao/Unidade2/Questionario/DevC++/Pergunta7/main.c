#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 15;
	int b = 3;
	
	int c, d;
	
	b += a;		//	b=3+15=18
	c = b;		//	c=18
	b = 2;		//	b=2
	d = c / b;	//	d=18/2=9
	
	printf("A: %d, B: %d, C: %d, D: %d \n", a, b, c, d);	//	15, 2, 18, 9

	return 0;
}
