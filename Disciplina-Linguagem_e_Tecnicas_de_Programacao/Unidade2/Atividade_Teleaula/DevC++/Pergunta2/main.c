#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {

	int a = 7;
	
	int b, c, d, e;
	
	float f;
	
	a--;	//	a=6
	printf("A: %d \n", a);
	
	b = a + 5;	//	b=a+5=6+5=11	a=6
	printf("A: %d, B: %d \n", a, b);
	
	c = (b - 5) * 3;	//	c=(11-5)*3=6*3=18	b=11
	printf("B: %d, C: %d \n", b, c);
	
	c++;	//	c=18, 19
	printf("C: %d \n", c);
	
	d = (c / 5) + a;	//	d=(19/5)+6=3+6=9	c=19	a=6
	printf("A: %d, C: %d, D: %d \n", a, c, d);
	
	e = d % a;	//	e=9%6=3		d=9		a=6
	printf("A: %d, D: %d, E: %d \n", a, d, e);
	
	f = pow(e,2);	//	f=3*3=9		e=3
	printf("E: %d, F: %d \n", e, f);
	
	printf("A: %d, F: %f \n", a, f);	//	a=6		f=9

	return 0;
}
