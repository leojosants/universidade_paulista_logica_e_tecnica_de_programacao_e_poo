#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int x, y, z;
	
	y = 5;
	x = 7;
	z = 3;
	
	if( (y - 1) > 2 ) {		//	((y-1)>2) => ((5-1)>2) => (4>2) => (4>2)=v=1
		y = y + 2;			//	y=y+2 => y=5+2 => y=7
	}
	else {					//	NAO EXECUTA ESTE BLOCO
		y = y - 2;
	}
	
	z = z + x + y;			//	z=z+x+y => z=3+7+7 => z=17	
	
	printf("Z: %d \n", z);

	return 0;
}
