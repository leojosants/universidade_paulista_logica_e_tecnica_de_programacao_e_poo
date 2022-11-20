#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 0, b = 0, n = 10;
	
	while( n > 0 ) {		//	(1x n=10 => n>0 => 10>0 => V) (2x n=5 => n>0 => 5>0 => V) (3x n=2 => n>0 => 2>0 => V) (4x n=1 => n>0 => 1>0 => V) (5x n=0 => n>0 => 0>0 => f) sai do while imprimi 
		
		if( n % 2 == 0 ) {	//	(1x n=10 => (n%2) => (10%2 => 0)==0 => V) (2x n=5 => (n%2) => (5%2 => 1)==0 => F) (3x n=2 => (n%2) => (2%2 => 0)==0 => V) (4x n=1 => (n%2) => (1%2 => 1)==0 => F)
			a++;			//	(1x a=0 => a+1 => a=1) (2x a=1 porem nao executa) (3x a=1 a++ a=2) (4x a=2 porem nao executa )
		}
		else {
			b++;			//	(1x b=0 porem nao executa) (2x b=0 => b++ => b=1) (3x b=1 porem nao executa) (4x b=1 => b++ => b=2)
		}
		
		n = n / 2; 			// 	(1x n=10 n=n/2 => n=10/2 => n=5) (2x n=5 n=n/2 => n=5/2 => n=2) (3x n=2 n=n/2 => n=2/2 => n=1) (4x n=1 n=n/2 => n=1/2 => n=0)

	}
		
	printf("A: %d, B: %d \n", a, b);	//	a=2	b=2

	return 0;
}
