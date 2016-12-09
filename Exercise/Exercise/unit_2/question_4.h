/* *************************************************** */
// * (4)	编写一个程序，读入9个裁判所打的分数，
// * 去掉一个最高分，去掉一个最低分，
// * 求剩余7个分数的平均值（要求用数组实现）。
/* *************************************************** */

# include <stdio.h>

float bubble_sort(float arr[]) {
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

float calculate_avg(float arr[]) {
	int i;
	float s = 0;
	for (i = 1; i < 8; i++)
	{
		s += arr[i];
	}
	return s / 7;
}


void main() {
	int i;
	float s, max, min, avg;
	float arr[9];
	for (i = 1; i < 10; i++) {
		printf("Read the %d referee score: ", i);
		scanf_s("%f", &s);
	}

	bubble_sort(arr);
	min = arr[0];
	max = arr[8];
	avg = calculate_avg(arr);

	printf("scores list(min->max):\n");
	for (i = 0; i < 9; i++)
	{
		printf("%.2f ", arr[i]);
	}
	printf("\n");
	printf("Remove the max score: %.2f\n", max);
	printf("Remove the min score: %.2f\n", min);
	printf("The avg score: %.2f\n", avg);
}