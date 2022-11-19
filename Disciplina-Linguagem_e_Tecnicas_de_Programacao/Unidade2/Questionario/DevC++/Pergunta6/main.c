#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int num1 = 15;
	int num2 = 3;
	int num3;
	
	num2 += num1;	//	num2=3+15=18
	num3 = num2;	//	num3=18
	num2 = 2;		//	num2=2
	
	printf("num1: %d, num2: %d \n", num1, num2);	//	num1=15, num2=2
	
	num1 = num2++;	//	num1=2, num2=2+1=3

	printf("num1: %d, num2: %d \n", num1, num2);	//	num1=2, num2=3
	
	return 0;
}
