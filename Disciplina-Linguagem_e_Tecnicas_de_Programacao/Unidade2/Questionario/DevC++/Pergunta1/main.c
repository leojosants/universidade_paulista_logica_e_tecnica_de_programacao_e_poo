#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	
	int x = 3;
	int y = 15;
	
	y /= x;
//	printf("Y: %d \n", y);		//	5

	printf("X: %d, Y: %d \n", x, y);	//	3, 5
	
	x = y++;
//	printf("X: %d \n", x);		//	5
	
	printf("X: %d, Y: %d \n", x, y);	//	5, 6
	
	return 0;
}
