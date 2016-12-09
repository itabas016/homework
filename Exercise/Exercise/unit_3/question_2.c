
//将形参n中各位上为偶数的数取出，并按原来从高位到低位的顺序组成一个新的数，并作为函数值返回。

#include <stdio.h>
unsigned long fun(unsigned long  n)
{
	unsigned long x = 0, s, i;    int  t;
	s = n;
	i = 1;
	while (s > 0)
	{
		t = s % 10;
		if (t % 2 == 0) {
			x = x + t*i;   i = i * 10;
		}
		s = s / 10;
	}
	return x;
}

main()
{
	unsigned long n = -1;
	while (n > 99999999 || n < 0)
	{
		printf("Please input(0<n<100000000) :");
		scanf_s("%ld", &n);
	}
	printf("\nThe result is : %ld\n", fun(n));
}