#include <stdio.h>
#include <stdlib.h>

typedef struct {
	int		codigo;
	char	nome[100];
	float	preco;
} Produto;

#define QUANTIDADE_DE_PRODUTO 5

int main(int argc, char *argv[]) {

	int		i;
	int codigo_digitado;
	Produto produtos[ QUANTIDADE_DE_PRODUTO ];
	
	printf("Campos: codigo-do-produto | nome | preco \n");
	
	for( i = 0; i < QUANTIDADE_DE_PRODUTO; i++ ) {
		printf("\nInforme os dados do produto (%i): \n", i+1);
		
		printf("Codigo: ");
		scanf("%d", &produtos[i].codigo); 
		
		printf("Nome  : ");
		scanf("%s", &produtos[i].nome);
		
		printf("Preco : ");
		scanf("%f", &produtos[i].preco);
	}

	for( i = 0; i < QUANTIDADE_DE_PRODUTO; i++ ) {
		printf("\n%d \t %s R$ %.2f", produtos[i].codigo, produtos[i].nome, produtos[i].preco); 
	}
	
	printf("\n\nInforme o codigo do produto: ");
	scanf("%d", &codigo_digitado);
	
	for( i = 0; i < QUANTIDADE_DE_PRODUTO; i++ ) {
		if( produtos[i].codigo == codigo_digitado ) {
			printf("\nPreco: R$ %.2f \n", produtos[i].preco);
		}
	}

	return 0;
}
