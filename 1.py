package com.company;
import java.util.ArrayList;
import java.util.Collections;

public class Main {

    public static void main(String[] args) {
        class arraysEquaility {
            public static void equalityList(ArrayList<Integer> arrayList1, ArrayList<Integer> arrayList2) {
                if (arrayList1.size() != arrayList2.size()) {
                    System.out.println("Массивы не равны");
                    return;
                }
                for (int i = 0; i < arrayList1.size(); i++) {
                    if (arrayList1.get(i) != arrayList2.get(i)) {
                        System.out.println("Массивы не равны");
                        return;
                    }
                }
                System.out.println("Массивы равны");
            }
        }
    }

    class arraysNumCheck {
        public static void checkArray(ArrayList<Integer> arrayList1, ArrayList<Integer> arrayList2, int num) {
            int count = 0;
            for (Integer integer : arrayList1) {
                if (integer == num) {
                    count++;
                }
            }
            for (int i = 0; i < arrayList2.size(); i++) {
                if (arrayList2.get(i) == num) {
                    count--;
                }
            }
            if (count == 0) {
                System.out.println("Число " + num + " встречается в массивах одинаковое количество раз");
            } else {
                System.out.println("Число " + num + " встречается в массивах разное количество раз");
            }
        }
    }

    class arraysSort {
        public static void sortEven(ArrayList<Integer> arrayList1) {
            ArrayList<Integer> arrayList2 = new ArrayList<>();
            for (int elem : arrayList1) {
                if (elem % 2 == 0) {
                    arrayList2.add(elem);
                }
            }
            Collections.sort(arrayList2);
            int j = 0;
            for (int i = 0; i < arrayList1.size(); i++) {
                if (arrayList1.get(i) % 2 == 0) {
                    arrayList1.set(i, arrayList2.get(j++));
                }
            }
            System.out.println(arrayList1);
        }
    }
    class arraysDelete {
        public static void delEven(ArrayList<Integer> arrayList1) {
            arrayList1.removeIf(num -> (int) num % 2 == 0);
            System.out.println(arrayList1);
        }
    }
}
