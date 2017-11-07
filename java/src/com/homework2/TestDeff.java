package com.homework2;

import java.util.Scanner;

/**
 * Created by Roger on 11/7/2017.
 */
public class TestDeff {
    public static void main(String[] args) {
        // TODO Auto‐generated method stub
        int i, j, m, n;

        Scanner s = new Scanner(System.in);

        System.out.print("Please input the first data: \r\n");

        i = s.nextInt();

        System.out.print("Please input the second data: \r\n");

        j = s.nextInt();

        Deff cd = new Deff();
        m = cd.deff(i, j);
        n = (i * j) /m;

        System.out.println("The max deff number is: " + m);
        System.out.println("The min deff number is: " + n);

    }
}
