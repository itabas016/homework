package com.homework2;

/**
 * Created by Roger on 11/7/2017.
 */
public class Patient {

    String name;
    char sex;
    int age;
    float weight;
    boolean allergies;

    void setName(String str){
        name=str;
    }
    void setSex(char s) {
        sex=s;
    }
    void setWeight(float w){
        weight=w;
    }
    void setAllergies(boolean t){
        allergies=t;    }

    public String toString(){
        return String.format("Name: %1$s\r\nSex: %2$s\r\nWeight: %3$f\r\nAllergies: %4$s",
                name, sex, weight, allergies);
    }
}
