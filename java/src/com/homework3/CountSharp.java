package com.homework3;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by Roger on 11/7/2017.
 */
public class CountSharp {

    public final static char SHARP = '#';

    public static void main(String[] args) throws IOException{
        // TODO Auto‐generated method stub

        int i=0, s=0;

        System.out.println("Please input data: ");
        BufferedReader buff = new BufferedReader(new InputStreamReader(System.in));
        char c = (char)(buff.read());

        while (c != SHARP){
            s ++;
            c = (char)(buff.read());
        }
        System.out.println("Input characters count is: " + s);
    }
}
