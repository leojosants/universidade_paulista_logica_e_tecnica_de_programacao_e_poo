#include <stdio.h>
#include <stdlib.h>

typedef struct no {

	int info;

	struct no *proximo
	
} No;

//
No* inicia() {
	return NULL;
}

//
No* insere(No* lista, int num) {
	
	No* novo_no = (No*)malloc(sizeof(No));
	
	novo_no->info = num;
	novo_no->proximo = lista;
	
	return novo_no;

}

// 
No* retira(No* lista, int num) {

	No* anterior = NULL;
	No* aux = lista;
	
	while(aux != NULL && aux->info != num) {
		
		anterior = aux;
		aux = aux->proximo;
		
	}
	
	if(aux == NULL) {
		return lista;
	}
	
	if(anterior == NULL) {
		lista = aux->proximo;
	}
	else {
		anterior->proximo = aux->proximo;
	}
	
	free(aux);
	
	return lista;

}

//
No* busca(No* lista, int num) {
	
	No* aux;
	
	for(aux = lista; aux != NULL; aux->proximo) {
		
		if(aux->info == num) {
			return aux;
		}
		
	}
	
	return NULL;
	
}

//
void imprime(No* lista) {
	
	No* aux;
	
	for(aux = lista; aux != NULL; aux = aux->proximo) {
		printf("Numero: %d \n", aux->info);
	}
	
}

//
void libera(No* lista) {

	No* aux = lista;
	
	while(aux != NULL) {
		
		No* proximo_no = aux->proximo;
		
		free(aux);
		
		aux = proximo_no;
		
	}

}


//
int main(int argc, char *argv[]) {

	No* lista;
	
	lista = inicia();
	printf("Lista iniciada \n\n");
	
	printf("Impressao da lista apos ser iniciada \n");
	imprime(lista);
	
	lista = insere(lista, 23);
	lista = insere(lista, 45);
	lista = insere(lista, 56);
	lista = insere(lista, 78);

	printf("\n");
	printf("Impressao da lista apos insersao: \n");	
	imprime(lista);
	
	lista = retira(lista, 78);
	lista = retira(lista, 45);
	
	printf("\n");
	printf("Impressao da lista apos retirada: \n");	
	imprime(lista);

	libera(lista);
	
	getch();
	
	return 0;

}
