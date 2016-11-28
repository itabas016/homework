/* *************************************************** */
// * (2)	±àÐ´³ÌÐò£¬Çó1£¡ + 2£¡ + 3£¡ + ¡­ + 10£¡¡£
/* *************************************************** */

# include <stdio.h>

// µÝ¹é¼ÆËã½×³Ë
long factorial_recursion(int n) {
	if (n <= 0) {
		return 1;
	}
	else {
		return n * factorial_recursion(n - 1);
	}
}

// µü´ú¼ÆËã½×³Ë
long factorial_iteration(int n) {
	int result = 1;
	while (n > 1) {
		result *= n;
		n--;
	}
	return result;
}


void question_2() {
	int result = 0;
	for (int i = 1; i <= 10; i++) {
		result += factorial_recursion(i);
	}
	printf("1! + 2! + 3! + ¡­ + 10! = %d", result);
}