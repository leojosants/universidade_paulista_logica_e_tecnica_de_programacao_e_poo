#include <stdio.h>
#include <stdlib.h>

int func(int n) { 														
											
	if(n == 0) {										 
		return(1);																															//	e pula pra onde a FUNC foi chamada, no caso na lINHA 24
	}
	else {
		return( func(n - 1) * (n - 1) );		
	}									
	
}

int main(int argc, char *argv[]) {

	int a, b;								
	
	printf("Digite um valor inteiro: "); 	
	scanf("%d", &a);						
	
	b = func(a);								

	printf("b: %d \n", b);				

	return 0;

}
