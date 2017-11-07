package com.homework3;

import java.util.Random;

/**
 * Created by Roger on 11/7/2017.
 */
public class TestPeople {
    
    public static void main(String[] args){
        // TODO Auto‐generated method stub

        People[] parray = new People[10];

        System.out.println("Prepare 10 people by randomize: ");

        for (int i = 0; i < parray.length; i++) {
            parray[i] = new People(RandomFullName(), RandomBirth(), RandomSex(), RandomHeight(), RandomWeight());
            System.out.println(parray[i].toString());
        }

        System.out.println("Start sort people list by height quota ascending: ");

        long startTime = System.currentTimeMillis();

        bubbleSort(parray);

        long endTime = System.currentTimeMillis();
        long totalTime = endTime - startTime;

        System.out.println("Sort array elapsed: " + totalTime);

        for (People r: parray) {
            System.out.println(r.toString());
        }

    }

    private static void bubbleSort(People[] array) {
        People temp = array[0];
        for (int i = 0; i < array.length - 1; i++) {
            for (int j = 0; j < array.length - 1 - i; j++) {
                if (array[j].height > array[j + 1].height) {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    private static int RandomBoundInt(int minvalue, int maxValue){

        final Random random = new Random();

        return random.nextInt(maxValue) % (maxValue - minvalue + 1) + minvalue;
    }

    private static String RandomFullName(){

        String firstName = RandomName(4, 6);
        String lastName = RandomName(4, 7);

        return firstName + " " + lastName;
    }

    private static String RandomName(int minLength, int maxLength){

        final Random rand = new Random();
        final String lexicon = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        StringBuilder sb = new StringBuilder();
        int length = RandomBoundInt(minLength, maxLength);

        while (sb.length() <= length){
            for (int i = 0; i < length; i++) {
                sb.append(lexicon.charAt(rand.nextInt(lexicon.length())));
            }
        }

        String head = sb.toString().substring(0, 1).toUpperCase();

        return head + sb.toString().substring(1, length - 1).toLowerCase();
    }

    private static Birth RandomBirth(){

        int year = RandomBoundInt(1965, 2000);
        int month = RandomBoundInt(1, 12);
        int day = RandomBoundInt(1, 28);

        return new Birth(year, month, day);
    }

    private static Sex RandomSex(){
        return Sex.values()[new Random().nextInt(Sex.values().length)];
    }

    private static float RandomBoundFloat(float minValue, float maxValue){

        final Random random = new Random();

        float result = minValue + (maxValue - minValue) * random.nextFloat();

        return (float)(Math.round(result*100))/100;
    }

    private static float RandomHeight(){
        return RandomBoundFloat(1.5f, 2.0f);
    }

    private static float RandomWeight(){
        return RandomBoundFloat(45f, 95f);
    }
}
