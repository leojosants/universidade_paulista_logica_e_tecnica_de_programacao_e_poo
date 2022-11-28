#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
//
struct arv {
	
	int info;
	
	struct arv* sae;
	
	struct arv* sad;
	
};
typedef struct arv Arv;

//
int vazia(Arv* a) {
	return a==NULL;
}

//
Arv* inicializa(void) {
	return NULL;
}

//
Arv* cria(int c, Arv* sae, Arv* sad) {
	
	Arv* p = (Arv*) malloc(sizeof(Arv));
	
	p->info = c;
	p->sae = sae;
	p->sad = sad;
	
	return p;
	
}

//
void imprime(Arv* a) {
	
	if(!vazia(a)) {
		
		printf("%d ", a->info);
		
		imprime(a->sae);
		imprime(a->sad);
		
	}
	
}

//
void imprimeC(Arv* a) {
	
	printf("<");
	
	if(!vazia(a)) {
		
		printf("%d ", a->info);
		
		imprimeC(a->sae);
		
		printf(",");
		
		imprimeC(a->sad);
		
	}
	
	printf(">");
	
}

//
void imprimePO(Arv* a) {
	
	if(!vazia(a)) {
		
		imprimePO(a->sae);
		imprimePO(a->sad);
		
		printf("%d ", a->info);
		
	}
	
}

//
void imprimeOS(Arv* a) {
	
	imprimeOS(a->sae);
	
	printf("%d ", a->info);
	
	imprimeOS(a->sad);
	
}

//
Arv* libera(Arv* a) {
	
	if(!vazia(a)) {
		
		libera(a->sae);
		libera(a->sad);
		
		free(a);
		
	}
	
	return NULL;
	
}

//
int busca(Arv* a, int c) {
	
	if(vazia(a)) {
		return 0;
	}
	else {
		return a->info==c || busca(a->sae, c) || busca(a->sad, c);
	}
	
}


//
int main(int argc, char *argv[]) {

	Arv* a1 = cria(8, inicializa(), inicializa());
	
	imprimePO(a1);
	
	printf("\n");
	
	getch();
	
	Arv* a2 = cria(4, inicializa(), a1);
	Arv* a3 = cria(2 ,inicializa(), inicializa());
	Arv* a4 = cria(1 ,inicializa(), inicializa());
	Arv* a5 = cria(3 , a3, a4);
	
	a2->sae = a5;
	imprime(a2);

	getch();

	printf("\n");

	imprimePO(a2);

	getch();
	
	printf("\n");

	imprimeOS(a2);

	printf("\n");
	
	 getch();

	if (busca(a2, 233))
		printf("z encontrado");
	else
		printf("z nao encontrado");
	
	getch();
	
	return 0;

}
