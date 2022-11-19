#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 15;
	int b = 3;
	
	int c, d;
	
	c = a / b;		//	c=15/3=5
	d = a % b;		//	d=15%3=0
	
	printf("A: %d, \nB: %d, \nC: %d, \nD: %d \n", a, b, c, d);	//	a=15, b=3, c=5, d=0

	return 0;
}
