using System;

class foreachAula {
    static void Main() {
        int[] num={11,22,33,44,55};

        for (int i=0;i<num.Length;i++) {
            System.Console.WriteLine(num[i]);
        }
        System.Console.WriteLine("==============================");
        foreach(int n in num) {
            System.Console.WriteLine(n);
        }
    }
}