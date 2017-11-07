#include <stdio.h>
main() {
	int val = -1;
	while (val % 1000 != 0 || val <1000)
	{
		printf("Please input your money(>1000, and multiple):");
		scanf_s("%d", &val);

		if (val % 1000 != 0)
			printf("%d is not multiple of 1000.\n", val);
	}

	float quotient = val * (1 - 0.015);
	//float a[6];
	//a[0] = 1;
	float currValue[5];

	printf("Please input everyday net value in this week :\n");
	//scanf_s("%f %f %f %f %f", a + 1, a + 2, a + 3, a + 4, a + 5);
	float a[6] = { 1, 0.9872, 0.9935, 1.0102, 0.9905, 1.0235 };
	printf("Quotient\tNet Value\tIncrease Rate\tCurrent Value\tCurrent Payoff  \n");

	int i = 0;
	for (i = 0; i < 6; i++)
	{
		float curr_val = quotient;
		float increase_rate = 0;
		if (i >= 1) {
			curr_val = quotient*a[i];
			currValue[i - 1] = curr_val;
			if (i > 1) {
				increase_rate = (a[i] - a[i - 1]) / a[i - 1] * 100;
			}
			int payoff = (curr_val * (1 - 0.005)) - quotient;
			printf("%d\t\t%.4f\t\t%.2f %%\t\t%d\t\t%d\n", (int)quotient, a[i], increase_rate, (int)curr_val, payoff);
		}
		
	}

	float aver;
	aver = (currValue[0] + currValue[1] + currValue[2] + currValue[3] + currValue[4]) / (5*quotient);
	printf("Average Net Value in this week = %.5f\n", aver);
}