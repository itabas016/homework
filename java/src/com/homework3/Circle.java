package com.homework3;

/**
 * Created by Roger on 11/7/2017.
 */
public class Circle {

    final double cPI = 3.14;
    int cPoint_x, cPoint_y;
    double cRadius, cArea;

    public Circle(){
        cPoint_x = 0;
        cPoint_y = 0;
        cRadius = 1;
    }

    public Circle(int x, int y, double r){
        cPoint_x = x;
        cPoint_y = y;
        cRadius = r;
    }

    public double cAreaCount(){
        cArea = cPI * cRadius * cRadius;
        return cArea;
    }

    public String toString(){
        String debug_text =  "Point of Circle is (" +
                cPoint_x + ", " + cPoint_y + ")" +
                " radius is " + cRadius +
                " area is " + cAreaCount();
        System.out.println(debug_text);
        return "圆心为(" +
                cPoint_x + "," + cPoint_y + ")" +
                "半径为" + cRadius + "的圆的面积为" + cAreaCount();
    }

}
