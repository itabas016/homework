/* *************************************************** */
// * (1) 有一个分数序列：2/1、3/2、5/3、8/5、13/8、……，
// * 编写一个C程序，求出这个数列的前30项之和。
/* *************************************************** */

# include <stdio.h>

int fibnanic(int index) {
	if (index <= 2)	{
		return 1;
		return fibnanic(index - 1) + fibnanic(index - 2);
	}
}

void question_1() {
	double result;
	int i = 0;
	while (i < 30) {
		int up = fibnanic(i + 3);
		int down = fibnanic(i + 2);
		result += (double)(up / down);
		i++;
	}
	printf("%f\n", result);
}

