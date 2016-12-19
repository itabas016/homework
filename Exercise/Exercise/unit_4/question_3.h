/*
//给定程序中函数fun的功能是：从低位开始取出长整型变量S中偶数位上的数，依次构成一个新数放在t中。
高位仍在高位，低值仍在低位。
例如，当S中的数为7654321时，t中的数为642。

*/

#include <stdio.h>
void fun(long s, long *t)
{
	long s1 = 10;
	s /= 10;
	*t = s % 10;
	while (s>0)
	{
		s = s / 100;
		*t = s % 10 * s1 + *t;
		s1 = s1 * 10;
	}
}

void question_3()
{
	long  s, t;
	printf("\nPlease enter s : ");  scanf_s("%ld", &s);
	fun(s, &t);
	printf("The result is : %ld\n", t);
}
