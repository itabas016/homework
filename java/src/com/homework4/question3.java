package com.homework4;

import java.util.Arrays;
import java.util.Scanner;

/**
 * Created by Roger on 11/8/2017.
 */
public class question3 {
    /**
     *
     * 编写程序实现能：四位的整数进行加密，
     * 加密规则：每位数字都乘以 2,然后用乘积除以 10 的余数代替该数字，再将第一位和第三位交换，第二位和第四位交换。
     * @param args
     */
    public static void main(String[] args){
        // TODO Auto‐generated method stub

        Scanner scanner = new Scanner(System.in);
        int num =0, temp;

        do {
            System.out.println("Please input a number (length = 4): ");
            num = scanner.nextInt();
        } while (num < 1000 || num > 9999);

        int array[] = new int[4];
        array[0] = num / 1000;
        array[1] = (num / 100) % 10;
        array[2] = (num / 10) % 10;
        array[3] = num % 10;

        for (int i = 0; i < array.length; i++) {
            array[i] *= 2;
            array[i] %= 10;
        }

        for (int i = 0; i <= 1; i++) {
            temp = array[i];
            array[i] = array[2 + i];
            array[2 + i] = temp;
        }

        String encrypt = Arrays.toString(array);

        System.out.println("After encrypt array is: " + encrypt);

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < array.length; i++) {
            sb.append(array[i]);
        }

        System.out.println("After encrypt number is: " + sb.toString());
    }
}
