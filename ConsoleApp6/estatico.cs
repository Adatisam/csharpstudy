using System;

class Mat {
    public static double pi=3.14;
    public static int Dobro(int n) {
        return n*2;
    }
}

class Aula49 {
    static void Main1() {
        double vpi=Mat.pi;
        int num=10;
        
        System.Console.WriteLine(vpi);
        System.Console.WriteLine(Mat.Dobro(num));
    }
}