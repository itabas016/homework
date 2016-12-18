
// *****************************************************************************//
// * 开放式基金是一种委托投资理财产品。用户可以向基金管理机构购买 / 
// * 赎回基金，基金管理机构负责将基金投资于股票等金融产品获取收益，并收取一定的管理费用。
// * 假设某基金在成立时每份面值为1元，申购费率为1.5%，赎回费率为0.5%。则有如下规则：
// * 1)	每个用户购买时的金额必须大于等于1000，并且是1000的整数倍；
// * 2)	基金份额 ＝ 购买金额×（1－申购费率） / 份额面值；
// * 3)	基金运作后每天公布当日每份基金净值，如0.9871或者1.0121，则：
// * 用户当前净值＝基金份额×当日每份基金净值；
// * 4)	每日净值增长率＝（当日每份基金净值－昨日每份基金净值） / 昨日每份基金净值×100％；
// * 5)	浮动盈亏＝用户当前净值×（1－赎回费率）－购买金额；
// * 6)	周平均净值 ＝ 一周每日净值的和 / 工作日；
// * 编写一个程序，要求用户输入在基金成立时的购买金额和基金运作第一周的每日每份基金净值，
// * 统计一周来用户的收益情况（提示：可用数组存放一周中每日的数据）
// * 
// * Example:
// * Please input your money(>1000, and multiple) : 1500
// * 1500 is not multiple of 1000.
// * Please input your money(>＝1000, and multiple) : 10000
// * Please input everyday net value in this week :
// * 	0.9872  0.9935  1.0102  0.9905  1.0235
// * 	Quotient	Net Value		Increase Rate	Current Value	 Current Payoff
// * 	9850		0.9872           0.00 %			9724			-325
// * 	9850		0.9935           0.64 %			9786			-263
// * 	9850		1.0102           1.68 %			9950			-99
// * 	9850		0.9905			-1.95 %			9756			-292
// * 	9850		1.0235           3.33 %			10081			 31
// * 	Average Net Value in this week = 1.00098
// *****************************************************************************//

#include <stdio.h>


void question_5() {
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
	aver = (currValue[0] + currValue[1] + currValue[2] + currValue[3] + currValue[4]) / (5 * quotient);
	printf("Average Net Value in this week = %.5f\n", aver);
}