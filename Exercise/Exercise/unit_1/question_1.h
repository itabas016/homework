
/* *************************************************** */
// * 1、编写程序输入三角形的3条边长，计算并输出三角形的面积。
// * 提示：三角形的面积S = sqrt((p(p - a)(p - b)(p - c))
// * 其中，p = (a + b + c) / 2
/* *************************************************** */

# include <stdio.h>
# include <math.h>

	float func_area(float a, float b, float c) {
	float p;
	float s;
	p = (a + b + c) / 2;
	s = sqrt((p*(p - a)*(p - b)*(p - c)));
	return s;
}

void question_1()
{
	float a, b, c, s;
	printf("pleace input the first line length: ");
	scanf("%f", &a);
	printf("pleace input the second line length: ");
	scanf("%f", &b);
	printf("pleace input the third line length: ");
	scanf("%f", &c);

	if ((a + b>c) && (a + c>b) && (b + c>a)) {
		s = func_area(a, b, c);
		printf("Area=%f\n", s);
	}
	else
		printf("你输入的三个数不满足构成三角形，请重新输入...");
}

