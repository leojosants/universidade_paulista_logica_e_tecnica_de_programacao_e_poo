#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {

	int lin = 1;
	int col;
	
//	while externo
	while( lin < 5 ) { 	// Esse laco acontecera 4 x				
	/*	
		( repeticao 1 de 4)

			lin=1 => condicao (lin<5) => substituindo lin por 1 a condicao fica (1<5?), ou seja, 1 eh menor que 5? VERDADEIRO, lin contina valendo 1 pula o comando (col = 1)

		( repeticao 2 de 4 )

			lin=2 => condicao (lin<5) => substituindo lin por 2 a condicao fica (2<5?), ou seja, 2 eh menor que 5? VERDADEIRO, pula o comando (col = 1)

		( repeticao 3 de 4 )

			lin=3 => condicao (lin<5) => substituindo lin por 3 a condicao fica (3<5?), ou seja, 3 eh menor que 5? VERDADEIRO, pula o comando (col = 1)

		( repeticao 4 de 4 )

			lin=4 => condicao (lin<5) => substituindo lin por 4 a condicao fica (4<5?), ou seja, 4 eh menor que 5? VERDADEIRO, pula o comando (col = 1)
	*/	
		
		col = 1;						
		/*
			( repeticao 1 de 4 )

				col comeca valendo 0 porem ao chegar aqui passa a valer 1 e pula pro while interno que sera repetido 4x (1 de 4)
			
			( repeticao 2 de 4 )

				col estava valendo 5 porem ao chegar aqui agora passa a valer 1 e pula pro while interno que sera repetido 4x (2 de 4)

			( repeticao 3 de 4 )

				col estava valendo 5 porem ao chegar aqui agora passa a valer 1 e pula pro while interno que sera repetido 4x (3 de 4)

			( repeticao 4 de 4 )
				col estava valendo 5 porem ao chegar aqui agora passa a valer 1 e pula pro while interno que sera repetido 4x (4 de 4)
		*/
			
//		while interno
		while( col < 5 ) {	// esse laco acontecera 16x, sendo um conjunto de 4x para cada laco
		/*
			( repeticao 1 de 4 para a primeira repeticao do while externo)
				
				1x condicao (col<5), onde col=1 => substituindo col por 1 a condicao fica (1<5?), ou seja, 1 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
			
				2x agora col=2 => condicao (col<5), onde col=2 => substituindo col por 2 a condicao fica (2<5?), ou seja, 2 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
			
				3x agora col=3 => condicao (col<5), onde col=3 => substituindo col por 3 a condicao fica (3<5?), ou seja, 3 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				4x agora col=4 => condicao (col<5), onde col=4 => substituindo col por 4 a condicao fica (4<5?), ou seja, 4 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				5x agora col=5 => condicao (col<5), onde col=5 => substituindo col por 5 a condicao fica (5<5?), ou seja, 5 eh menor que 5? FALSO, finalizando a primeira verificacao e pula para a linha de comando (lin = lin + 1;)
		*/

		/*			
			( repeticao 2 de 4 para a segunda repeticao do while externo )
			
				1x col=1 => condicao (col<5) => substituindo col por 1 a condicao fica (1<5?), ou seja, 1 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)

				2x agora col=2 => condicao (col<5) => substituindo col por 2 a condicao fica (2<5?), ou seja, 2 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				3x agora col=3 => condicao (col<5) => substituindo col por 3 a condicao fica (3<5?), ou seja, 3 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
			
				4x agora col=4 => condicao (col<5) => substituindo col por 4 a condicao fica (4<5?), ou seja, 4 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
			
				5x agora col=5 => condicao (col<5) => substituindo col por 5 a condicao fica (5<5?), ou seja, 5 eh menor que 5? FALSO, finalizando a segunda verificacao e pula para a linha de comando (lin = lin + 1;)
		*/

		/*		
			( repeticao 3 de 4 para a terceira repeticao do while externo )
			
				1x col=1 => condicao (col<5) => substituindo col por 1 a condicao fica (1<5?), ou seja, 1 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)

				2x col=2 => condicao (col<5) => substituindo col por 2 a condicao fica (2<5?), ou seja, 2 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				3x col=3 => condicao (col<5) => substituindo col por 3 a condicao fica (3<5?), ou seja, 3 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				4x col=4 => condicao (col<5) => substituindo col por 4 a condicao fica (4<5?), ou seja, 4 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
		
				5x agora col=5 => condicao (col<5) => substituindo col por 5 a condicao fica (5<5?), ou seja, 5 eh menor que 5? FALSO, finalizando a terceira verificacao e pula para a linha de comando (lin = lin + 1;)
		*/

		/*		
			( repeticao 4 de 4 para a quarta repeticao do while externo )

				1x col=1 => condicao (col<5) => substituindo col por 1 a condicao fica (1<5?), ou seja, 1 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				2x col=2 => condicao (col<5) => substituindo col por 2 a condicao fica (2<5?), ou seja, 2 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				3x col=3 => condicao (col<5) => substituindo col por 3 a condicao fica (3<5?), ou seja, 3 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				4x col=4 => condicao (col<5) => substituindo col por 4 a condicao fica (4<5?), ou seja, 4 eh menor que 5? VERDADEIRO, pula para a linha de comando (printf("%d", lin * col);)
				
				5x agora col=5 => condicao (col<5) => substituindo col por 5 a condicao fica (5<5?), ou seja, 5 eh menor que 5? FALSO, finalizando a quarta verificacao e pula para a linha de comando (lin = lin + 1;)
		*/
			
			printf("%d ->", lin * col);	
			/*		
				( repeticao 1 de 4 para a primeira repeticao do while externo )
					
					1x lin=1 col=1 => substituindo lin * col => 1 * 1 => 1, entao ira imprimir 1 e pula pra linha de comando (col += 1;)
				
					2x lin=1 col=2 => substituindo lin * col => 1 * 2 => 2, entao ira imprimir 2 e pula pra linha de comando (col += 1;)
				
					3x lin=1 col=3 => substituindo lin * col => 1 * 3 => 3, entao ira imprimir 3 e pula pra linha de comando (col += 1;)
					
					4x lin=1 col=4 => substituindo lin*col => 1*4 => 4, entao ira imprimir 4 e pula pra linha de comando (col += 1;)
			*/
			
			/*	
				( repeticao 2 de 4 para a segunda repeticao do while externo )
		
					1x lin=2 col 1 => substituindo lin*col => 2*1 => 2, entao ira imprimir 2 e pula pra linha de comando (col += 1;)
				
					2x lin=2 col=2 => substituindo lin * col => 2 * 2 => 4, entao ira imprimir 4 e pula pra linha de comando (col += 1;)
				
					3x lin=2 col=3 => substituindo lin*col => 2*3 => 6, entao ira imprimir 6 e pula pra linha de comando (col += 1;)

					4x lin=2 col=4 => substituindo lin*col => 2*4 => 8, entao ira imprimir 8 e pula pra linha de comando (col += 1;)
			*/
			
			/*	
				( repeticao 3 de 4 para a terceira repeticao do while externo )
					
					1x lin=3 col=1 => substituindo lin*col => 3*1 => 3, entao ira imprimir 3 e pula pra linha de comando (col += 1;)
				
					2x lin=3 col=2 => substituindo lin*col => 3*2 => 6, entao ira imprimir 6 e pula pra linha de comando (col += 1;)
				
					3x lin=3 col=3 => substituindo lin*col => 3*3 => 9, entao ira imprimir 9 e pula pra linha de comando (col += 1;)
				
					4x lin=3 col=4 => substituindo lin*col => 3*4 => 12, entao ira imprimir 12 e pula pra linha de comando (col += 1;)
			*/
			
			/*	
				( repeticao 4 de 4 para a quarta repeticao do while externo )
					
					1x lin=4 col=1 => substituindo lin*col => 4*1 => 4, entao ira imprimir 4 e pula pra linha de comando (col += 1;)
					
					2x lin=4 col=2 => substituindo lin*col => 4*2 => 8, entao ira imprimir 4 e pula pra linha de comando (col += 1;)
					
					3x lin=4 col=3 => substituindo lin*col => 4*3 => 12, entao ira imprimir 12 e pula pra linha de comando (col += 1;)
					
					4x lin=4 col=4 => substituindo lin*col => 4*4 => 16, entao ira imprimir 16 e pula pra linha de comando (col += 1;)
			*/	

			col += 1;					
			/*	
				( repeticao 1 de 4 para a primeira repeticao do while externo )

					1x col=1 => condicao (col += 1), ou seja, (col = col + 1), sendo col=1+1, ficando col=2, retorna para o while interno para fazer a segunda repeticao
				
					2x col=2 => condicao (col += 1), ou seja, (col = col + 1), sendo col=2+1, ficando col=3, retorna para o while interno para fazer a terceira repeticao
		
					3x col=3 => condicao (col += 1), ou seja, (col = col + 1), sendo col=3+1, ficando col=4, retorna para o while interno para fazer a quarta repeticao

					4x col=4 => condicao (col += 1), ou seja, (col=col+1), sendo col=4+1, ficando col=5, retorna para o while interno para fazer a quinta repeticao
			*/
			
			/*	
				( repeticao 2 de 4 para a segunda repeticao do while externo )
					
					1x col=1 => condicao (col+=1), ou seja, (col=col+1), sendo col=1+1, ficando col=2, retorna para o while interno para fazer a segunda repeticao
				
					2x col=2 => condicao (col+=1), ou seja, (col=col+1), sendo col=2+1, ficando col=3, retorna para o while interno para fazer a terceira repeticao
					
					3x col=3 => condicao (col+=1), ou seja, (col=col+1), sendo col=3+1, ficando col=4, retorna para o while interno para fazer a quarta repeticao
				
					4x col=4 => condicao (col+=1), ou seja, (col=col+1), sendo col=4+1, ficando col=5, retorna para o while interno para fazer a quinta repeticao
			*/
			
			/*	
				( repeticao 3 de 4 para a terceira repeticao do while externo )  

					1x	col=1 => condicao (col+=1), ou seja, (col=col+1), sendo col=1+1, ficando col=2, retorna para o while interno para fazer a segunda repeticao
					
					2x col=2 => condicao (col+=1), ou seja, (col=col+1), sendo col=2+1, ficando col=3, retorna para o while interno para fazer a terceira repeticao
					
					3x col=3 => condicao (col+=1), ou seja, (col=col+1), sendo col=3+1, ficando col=4, retorna para o while interno para fazer a quarta repeticao
					
					4x col=4 => condicao (col+=1), ou seja, (col=col+1), sendo col=4+1, ficando col=5, retorna para o while interno para fazer a quinta repeticao
			*/
			
			/*	
				( repeticao 4 de para a quarta repeticao do while externo )

					1x col=1 => condicao (col+=1), ou seja, (col=col+1), sendo col=1+1, ficando col=2, retorna para o while interno para fazer a segunda repeticao

					2x col=2 => condicao (col+=1), ou seja, (col=col+1), sendo col=2+1, ficando col=3, retorna para o while interno para fazer a terceira repeticao

					3x col=3 => condicao (col+=1), ou seja, (col=col+1), sendo col=3+1, ficando col=4, retorna para o while interno para fazer a quarta repeticao

					4x col=4 => condicao (col+=1), ou seja, (col=col+1), sendo col=4+1, ficando col=5, retorna para o while interno para fazer a quinta repeticao
			*/
		}
		
		lin = lin + 1; //	essa linha de comando pertence ao primeiro while externo, ou seja, acontecera somente 4x
			/*	
				( repeticao 1 de 4)
				
					lin=1 => condicao (lin=lin+1) lin=1, substituindo (lin=lin+1) fica (lin=1+1) => lin=2, pula para o while externo para realizar a segunda verificacao
					obs: nessa primeira repeticao do while interno sera impresso os valores 1, 2, 3, 4
			
				( repeticao 2 de 4 )
					
					lin=2 => condicao (lin=lin+1) substituindo (lin=lin+1) fica (lin=2+1) => lin=3, pula para o while externo para realizar a terceira verificacao
					obs: nessa segunda repeticao do while interno sera impresso os valores 2, 4, 6, 8
				
				( repeticao 3 de 4 )
				
					lin=3 => condicao (lin=lin+1) substituindo (lin=lin+1) fica (lin=3+1) => lin=4, pula para o while externo para realizar a quarta verificacao
					obs: nessa terceira repeticao do while interno sera impresso os valores 3, 6, 9, 12
			
				( repeticao 4 de 4 )
				
					lin=4 => condicao (lin=lin+1) substituindo (lin=lin+1) fica (lin=4+1) => lin=5, pula para o while externo para realizar a quinta verificacao
					obs: nessa quarta repeticao do while interno sera impresso os valores 4, 8, 12, 16
			*/		
	
	}
	
	printf("\n");

	return 0;
}
