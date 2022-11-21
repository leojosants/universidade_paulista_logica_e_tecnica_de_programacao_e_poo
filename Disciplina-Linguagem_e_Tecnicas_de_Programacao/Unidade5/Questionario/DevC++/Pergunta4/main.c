#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

	int vet[10], x, y = 0;
	
	for( x = 0; x <= 9; x++ ) {	// (1x-x=0 y=0)					(2x-x=1 y=2) 				(3x-x=2 y=4) 				(4x-x=3 y=6)				(5x-x=4 y=8)				 	(6x-x=5 y=10)					(7x-x=6 y=12)					(8x-x=7 y=14)					(9x-x=8 y=16)					(10x-x=9 y=18)					(7x-x=0 y=12)	
		vet[x] = y + 2;			// (1x-vet[x]=0+2 => vet[0]=2) 	(2x-vet[x]=2+2 => vet[1]=4) (3x-vet[x]=4+2 => vet[2]=6) (4x-vet[x]=6+2 => vet[3]=8)	(5x-vet[x]=8+2 => vet[4]=10)	(6x-vet[x]=10+2 => vet[5]=12)	(7x-vet[x]=12+2 => vet[6]=14)	(8x-vet[x]=14+2 => vet[7]=16)	(9x-vet[x]=16+2 => vet[8]=18)	(10x-vet[x]=18+2 => vet[9]=20)
		y = y + 2;				// (1x-y=0+2 => y=2) 			(2x-y=2+2 => y=4) 			(3x-y=4+2 => y=6)			(4x-y=6+2 => y=8) 			(5x-y=8+2 => y=10)				(6x-y=10+2 => y=12)				(7x-y=12+2 => y=14)				(8x-y=14+2 => y=16)				(9x-y=16+2 => y=18)				(10x-y=18+2 => y=20)
	}
							    // (vet[0]=2)					(vet[1]=4)					(vet[2]=6)					(vet[3]=8)					(vet[4]=10)						(vet[5]=12)						(vet[6]=14)						(vet[7]=16)						(vet[8]=18)						(vet[9]=20)
								
	printf("Vetor prenchido: \n");		
							    
	for( x = 0; x <= 9; x++ ) {			//	(1x-x=0)		(2x-x=1)	(3x-x=2)	(4x-x=3)	(5x-x=4)	(6x-x=5)	(7x-x=6)	(8x-x=7)	(9x-x=8)	(10x-x=9)
		printf("vet[%d]=%d ", x, vet[x]);// (1x-(vet[0]=2)	(vet[1]=4)	(vet[2]=6)	(vet[3]=8)	(vet[4]=10)	(vet[5]=12)	(vet[6]=14)	(vet[7]=16)	(vet[8]=18)	(vet[9]=20)	
	}
	
	printf("\n\n");

	return 0;
}
