package com.homework1;

/**
 * Created by Roger on 11/7/2017.
 */
public final class Helper {

    static int Factorial(int n) {
        int t = 1, i;
        for(i = 1; i <= n; i++) {
            t = t * i;
        }
        return t;
    }

    static int[] RandomArray(int length){

        int data[] = new int[length];
        int i;
        for (i = 1; i <= length; i++){
            data[i-1] = (int)(Math.random() * 100);
        }

        return data;
    }

    static String ArrayToString(int[] data){

        StringBuilder sb = new StringBuilder();
        int i;
        for (i = 0; i < data.length; i++){
            sb.append(data[i]);
            sb.append(", ");
        }
        return sb.toString();
    }

    static int FindMax(int[] data){

        if (data.length > 0) {
            int max = data[0];
            int i;
            for (i = 0; i < data.length; i++){
                if (data[i] > max)
                    max = data[i];
            }
            return max;
        }
        return 0;
    }

    static int FindMin(int[] data){

        if (data.length > 0) {
            int min = data[0];
            int i;
            for (i = 0; i < data.length; i++){
                if (data[i] < min)
                    min = data[i];
            }
            return min;
        }
        return 0;
    }

    static int SumOfGreatThan50(int[] data){

        if (data.length > 0) {
            int sum = 0;
            int i;
            for (i = 0; i < data.length; i++){
                if (data[i] > 50)
                    sum += data[i];
            }
            return sum;
        }

        return 0;
    }
}

