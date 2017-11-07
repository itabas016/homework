package com.homework1;

/**
 * Created by Roger on 11/7/2017.
 */
public class HelloWorld {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		System.out.println("Question 1: 编写打印: The Java World");
		System.out.println("The Java World!");
		
		System.out.println("Question 2: 设 n 为自然数：n！=1×2×3×…×n，称为 n 的阶乘，并且规定 0！=1, " +
                "编程计算 2！, 4！, 6！和 10!");

		System.out.println("2! = "+ Helper.Factorial(2));
        System.out.println("4! = "+ Helper.Factorial(4));
        System.out.println("6! = "+ Helper.Factorial(6));
        System.out.println("10! = "+ Helper.Factorial(10));

        System.out.println("Question 3: 使用 java.lang.Math 类，生成 100 个 0-99 之间的随机整数，" +
                "找出它们之中的最大者和 最小者，并统计大于 50 的整数个数。");

        System.out.println("Try to generate 100 numbers... ");
        int data[] = Helper.RandomArray(100);

        System.out.println("Random array is ready, \r\n" + Helper.ArrayToString(data));

        System.out.println("The max number in array: " + Helper.FindMax(data));
        System.out.println("The min number in array: " + Helper.FindMin(data));
        System.out.println("The sum of greater than 50 numbers: " + Helper.SumOfGreatThan50(data) );

    }

}
