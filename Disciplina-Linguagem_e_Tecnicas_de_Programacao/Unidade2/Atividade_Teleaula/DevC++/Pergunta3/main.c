#include <stdio.h>
#include <stdlib.h>
#include <math.h>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int x, y;
	char z, w;
	int t, k;
	
	x = 3;	
//	x=3
	
	y = pow(x,2) + ((14 + 4) / 2) * 9 - 10;
//	y = pow(3,2) + ((14 + 4) / 2) * 9 - 10;
//	y = 9 + (18 / 2) * 9 - 10;
//	y = 9 + 9 * 9 - 10;	
//	y = 9 + 81 - 10;	
//	y = 90 - 10;	
//	y = 80	

	y++;
//	y=81
	
	z = "Logica";
//	z = "Logica";
	
	w = z + "Programacao";
//	w = "Logica" + Programacao;
	
	x--;
//	x=2;
	
	t = (x <= y) && (! (y != x)) == (y >= x);
//	t = (2 <= 81) && (! (81 != 2)) == (81 >= 2);
//	t = 0 && (! 0) == 0;
//	t = 0 && 1 == 0;
//	t = 0 == 1;
//	t = 0;
	
	k = !t || (x > y);
//	k = !0 || (2 > 81);
//	k = 1 || 1;
//	k = 1 ;
	
	printf("X: %d, T: %d, K: %d \n", x, t, k);	//	x=2		t=0		k=1
	
	return 0;
}
