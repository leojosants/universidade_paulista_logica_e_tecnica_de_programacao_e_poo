#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct {
	char 	nome[100];
	char 	sexo;
	float 	peso;
	float	altura;
} Pessoa;

#define QUANTIDADE_DE_PESSOAS 3

int main(int argc, char *argv[]) {

	int 	i;
	char	nomeLoc[100];
	float	imc;
	
	Pessoa pessoas[QUANTIDADE_DE_PESSOAS];
	
	printf("Campos: \t \t \tNome | Altura | Peso | Sexo \n");
	
	for( i = 0; (i < QUANTIDADE_DE_PESSOAS); i++ ) {
		printf("\nInforme os dados da pessoa (%i): ", i+1);
		scanf("%s %f %f %c", &pessoas[i].nome, &pessoas[i].altura, &pessoas[i].peso, &pessoas[i].sexo);		
//		printf("\n");
	}
	
	printf("\nInforme o NOME da pessoa: ");
	scanf("%s", &nomeLoc);
	
	printf("\nNome \t Sexo \t IMC");
	
	for( i = 0; (i < QUANTIDADE_DE_PESSOAS); i++ ) {
		if( strcmp(pessoas[i].nome, nomeLoc) == 0 ) {
			float imc = pessoas[i].peso / (pessoas[i].altura * pessoas[i].altura);
			printf("\n%s \t %c \t %.2f \n", pessoas[i].nome, pessoas[i].sexo, imc);
			break;
		}
	}
	
	system("pause");

	return 0;
}
