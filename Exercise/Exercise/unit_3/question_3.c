
//输出M行M列的整数方阵，然后求两条对角线上的元素之和，要求返回此和数。同时，在函数中需完整输出整数方阵和对角线上元素之和。

#include <conio.h>
#include <stdio.h>
#define M  5
int fun(int n, int xx[M][M])
{
	int i = 0; int s = 0;
	for (i = 0; i < M; i++)
	{
		int line = xx[i][i] + xx[i][M - i - 1];
		s += line;
	}
	return s;

}
main()
{
	int aa[M][M] = { { 1,2,3,4,5 },{ 4,3,2,1,0 },{ 6,7,8,9,0 },{ 9,8,7,6,5 },{ 3,4,5,6,7 } };
	printf("\nThe sum of all elements on 2 diagnals is %d.", fun(M, aa));
}