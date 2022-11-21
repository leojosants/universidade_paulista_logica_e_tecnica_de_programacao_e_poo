#include <stdio.h>
#include <stdlib.h>
#include <math.h>

float calcular( float x, float y, float z ) {
	return( pow(x, 2) + (y + z) );
/*
	return( pow(2, 2) + (3 + 4) );
	return( 4 + 7 );
	return( 11,00 );			
*/
}

int main(int argc, char *argv[]) {

	float x = 2;
	float y = 3;
	float z = 4;
	
	printf("Resultado: %.2f \n", calcular( x, y, z ));	//	11.00

	return 0;
}
