#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int i = 15;
	int j = 3;
	
	j %= i;
	printf("J: %d \n", j);	//	j=3
	
	printf("I: %d, J: %d \n", i, j);	//	i=15, j=3
	
	i = j++;
	printf("I: %d \n", i);	//	i=3
	
	printf("I: %d, J: %d \n", i , j);	//	i=3, j=4

	return 0;
}
