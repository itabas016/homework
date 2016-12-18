
//使用递归方法求解斐波那契数列的前30项
//			0					(n=0)
// Fib(n)=	1					(n=1)
//			Fib(n-2)+Fib(n-1)	(n>1)

#include <stdio.h>
int Fib(int n)
{
	if (n == 0)
	{
		return 0;
	}
	else if (n == 1)
	{
		return 1;
	}
	else
	{
		return Fib(n - 2) + Fib(n - 1);
	}
}
void question_4()
{
	int i = 0;
	for (i = 0; i <= 30; i++)
	{
		printf("\nFib(%d) = %d\n", i, Fib(i));
	}
}