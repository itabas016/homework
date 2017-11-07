package com.homework2;

/**
 * Created by Roger on 11/7/2017.
 */
public class Rect {

    protected int width, height;

    Rect(){
        width = 10;
        height = 10;
    }

    Rect(int w, int h){
        width = w;
        height = h;
    }

    public int areaRect(){
        return width * height;
    }

    public int peremeterRect(){
        return 2 * (width + height);
    }

    public String toString(){
        String s = "The Rectangle is: ";
        s += "[" + width + "," + height + "] ";
        s += "the area is " + areaRect() + ", ";
        s += "the perimeter is " + peremeterRect();
        return s;
    }
}
