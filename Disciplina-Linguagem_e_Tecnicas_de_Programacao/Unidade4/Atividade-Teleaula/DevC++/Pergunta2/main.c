#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int n, n1, x;
	float media = 0;
	
	printf("Digite N: ");
	scanf("%d", &n);
	
	n1 = 0;
	
	while( n1 < n ) {
		printf("Digite X: ");
		scanf("%d", &x);
		
		media = media + x;
		n1 = n1 + 1;
	}
	
	printf("%f", media / n);

	return 0;
}
