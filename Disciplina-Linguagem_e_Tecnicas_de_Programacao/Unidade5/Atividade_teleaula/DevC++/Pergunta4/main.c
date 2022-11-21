#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

	float 	t[3];
	int 	i;
	float 	soma, media;
	
	soma = 0;
	
	for( i = 0; i <= 2; i++ ) {										//	(1x i=0 => 0<=2? => V)								(2x i=1 => 1<=2? => V)								(3x i=2 => 2<=2? => V)								(4x i=3 => 3<=2? => F => sai do laco e pula para a linha de comando => media = soma / 3;)
		printf("Digite a temperatura %d: ", i);						//	(1x i=0)											(2x i=1)											(3x i=2)
		scanf("%f", &t[i]);											//	(1x i=0 => valor dig '1' vai para t[i] => t[0]=1)	(2x i=1 => valor dig '2' vai para t[i] => t[1]=2)	(3x i=2 => valor dig '3' vai para t[i] => t[2]=3)
		
		soma = soma + t[i];											//	(1x soma=0 => soma=soma+t[i] => soma=0+1 => soma=1 => i++ => i=1)	(2x soma=1 => soma=soma+t[i] => soma=1+2 => soma=3 => i++ => i=2)	(3x soma=3 => soma=soma+t[i] => soma=3+3 => soma=6)
	}
	
	media = soma / 3;												//	media=soma/3 => soma=6 => media=soma/3 => media=6/3 => media=2 => pula para a linha de comando => printf("\nMedia das temperaturas %10.2f \n", media);
	
	printf("\nMedia das temperaturas %10.2f: \n", media);			//	media => media=2
	
	for( i = 0; i <= 2; i++ ) {										//	(1x i=0 => 0<=2? => V)																	(2x i=1 => 1<=2? => V)								(3x i=2 => 2<=2? => V)								(4x i=3 => 3<=2? => F
		printf("Diferenca %d eh %10.2f \n", i, media - t[i]);	//	(1x i=0 => media=2 => t[i] => t[0] => (i, media-t[i] => 0 => 2-1 => 0, 1,00) i++ => i=1)	(2x )	(3x)
	}

	return 0;
}
