package com.homework4;

import java.util.Scanner;

/**
 * Created by Roger on 11/8/2017.
 */
public class question1 {

    /**
     * Simple Reverse
     * 编写一个 Java 源程序，在程序中建立一个含 10 个整型（int）元素的一维数组，对数组 中的每个元素赋值，然后按下标的逆序输出。
     * @param args
     */
    public static void main(String[] args){
        // TODO Auto‐generated method stub

        int[] input = new int[10];
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i < input.length; i++) {
            input[i] = scanner.nextInt();
        }

        for (int i = input.length - 1; i >= 0; i--) {
            System.out.println(input[i]);
        }

        System.out.println("Other reverse way, cut array in the middle and then reverse.");

        Reverse(input);

        for (int i = 0; i < input.length; i++) {
            System.out.println(input[i]);
        }
    }

    private static void Reverse(int[] array){
        for(int i = 0; i < array.length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.length - i - 1];
            array[array.length - i - 1] = temp;
        }
    }
}
