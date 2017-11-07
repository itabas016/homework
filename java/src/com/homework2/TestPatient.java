package com.homework2;

/**
 * Created by Roger on 11/7/2017.
 */
public class TestPatient {

    public static void main(String[] args) {
        // TODO Auto‐generated method stub

        Patient p = new Patient();
        p.setName("Zhangsan");
        p.setSex('M');
        p.setWeight(80);
        p.setAllergies(true);

        System.out.println(p.toString());

        Patient p2 = new Patient();
        p2.setName("Wangwu");
        p2.setSex('F');
        p2.setWeight(60);
        p2.setAllergies(false);

        System.out.println(p2.toString());


    }
}
