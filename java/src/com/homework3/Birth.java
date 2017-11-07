package com.homework3;

/**
 * Created by Roger on 11/7/2017.
 */
public class Birth {
    int year, month, day;
    Birth(int y, int m, int d){
        year = y;
        month = m;
        day = d;
    }

    public String toString(){
        return "(" + year + ", " + month + ", " + day + ")";
    }
}
