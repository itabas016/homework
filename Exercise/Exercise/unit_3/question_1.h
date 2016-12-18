
//找出100～n（不大于1000）之间的三位数字相等的所有整数，把这些整数放在s所指的数组中，整数的个数作为函数值返回

#include <stdio.h>
#define  N  100
int fun(int  *s, int  n)
{
	int i, j, k, a, b, c;
	j = 0;
	for (i = 100; i < n; i++) {
		k = i;
		a = k % 10; k /= 10;
		b = k % 10; k /= 10;
		c = k % 10; k /= 10;
		if (a == b&&a == c) s[j++] = i;
	}
	return  j;
}

void question_1()
{
	int  a[N], n, num = 0, i;
	do
	{
		printf("\nEnter n(<= 1000);  ");  scanf_s("%d", &n);
	} while (n > 1000);
	num = fun(a, n);
	printf("\n\nThe result : \n");
	for (i = 0; i < num; i++) printf(" % 5d", a[i]);
	printf("\n\n");
}