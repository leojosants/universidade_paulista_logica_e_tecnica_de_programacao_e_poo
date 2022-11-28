#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

//
typedef struct no {
	
	int info;
	
	struct no * proximo;
	
} No;

//
typedef struct fila {
	
	No* ini;
	
	No* fim;
	
} Fila;

//
No* insere(No* lista, int num) {
	
	No* novo_no = (No*)malloc(sizeof(No));
	
	novo_no->info = num;
	novo_no->proximo = lista;
	
	return novo_no;
	
}

//
No* retira(No* lista) {
	
	No* aux = lista;
	
	lista = aux->proximo;
	
	free(aux);
	
	return lista;
	
}

//
Fila* cria(void) {
	
	Fila* f = (Fila*) malloc(sizeof(Fila));
	
	f->ini = f->fim = NULL;
	
	return f;
	
}

//
void entra(Fila* f, int v) {
	
	No* novo_no = insere(f->fim, v);
	
	novo_no->proximo = NULL;
	
	if(f->fim != NULL) {
		f->fim->proximo = novo_no;
	}
	
	f->fim = novo_no;
	
	if(f->ini == NULL) {
		f->ini = f->fim;
	}
	
}

//
int vazia(Fila* f) {
	return(f->ini == NULL);
}

//
int sai(Fila* f) {
	
	int v;
	
	if(vazia(f)) {
		printf("Fila vazia. \n");
		exit(1);
	}
	
	return v;
	
}

//
void libera(Fila* f) {
	
	No* q = f->ini;
	
	while(q != NULL) {
		
		No* t = q->proximo;
		
		free(q);
		
		q = t;
	}
	
	free(f);
	
}

//
void imprime(Fila* f) {
	
	No* q;
	
	for(q = f->ini; q != NULL; q = q->proximo) {
		printf("%d \n", q->info);
	}
	
}


//
int main(int argc, char *argv[]) {

	Fila* f = cria();
	
	entra(f, 1);
	entra(f, 2);
	entra(f, 3);
	entra(f, 4);
	
	printf("Primeiro elemento: %d\n", sai(f));
	printf("Segundo elemento: %d\n", sai(f));
	printf("Configuracao da fila:\n");

	imprime(f);

	entra(f, 5);
	entra(f, 6);

	printf("Configuracao da fila:\n");	
	imprime(f);
	
	printf("terceiro elemento: %d\n", sai(f));
	printf("Configuracao da fila:\n");
	imprime(f);
	
	libera(f);
	
	getch();

	return 0;

}
