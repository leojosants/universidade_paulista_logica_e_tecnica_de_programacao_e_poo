#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

	int lin, col, cont = 0;
	int mat[4][4];
	
	for( lin = 0; lin <= 3; lin++ ) {
		for( col = 0; col <= 3; col++ ) {
			mat[lin][col] = cont++;
		}
	}
	
	for( lin = 0; lin <= 3; lin++ ) {	
		for( col = 0; col <= 3; col++ ) {
				
			if( lin != col ) {
				printf("%d", mat[lin][col]);
			}
			
			printf("\t");
		}
		printf("\n");	
	}
	
	printf("\n\n");
	system("pause");

	return 0;
}
