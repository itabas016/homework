/* *************************************************** */
// * (3)	编写一个C程序，实现对10个整数进行升序排序输出。
/* *************************************************** */

# include <stdio.h>

int bubble_sort(int arr[10])
{
	int i, j, temp;
	for (i = 0; i < 10; i++)
	{
		for (j = 0; j < i; j++)
		{
			if (arr[j] > arr[i])
			{
				temp = arr[j];
				arr[j] = arr[i];
				arr[i] = temp;
			}
		}
	}
}

void question_3() {
	int i;
	int a[10] = { 3,2,1,4,7,5,6,8,9,10 };
	for (i = 0; i < 10; i++)
	{
		printf("%d", a[i]);
	}
	bubble_sort(a);
	printf("\n");
	for (i = 0; i < 10; i++)
	{
		printf("%d", a[i]);
	}
}