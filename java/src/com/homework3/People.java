package com.homework3;

/**
 * Created by Roger on 11/7/2017.
 */

enum Sex{
    MAIL,
    FEMAIL;
}

public class People {
    String name;
    Birth birth;
    Sex sex;
    float height;
    float weight;

    People(String name, Birth birth, Sex s, float h, float w){
        this.name = name;
        this.birth = birth;
        this.sex = s;
        this.height = h;
        this.weight = w;
    }

    public String toString(){
        return this.name + '\t' +
                this.birth + '\t' +
                this.sex + '\t' +
                this.height + "m" + '\t' +
                this.weight + "kg" + '\t';
    }
}


