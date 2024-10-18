using System;

class ex2{
    static void Main(string[] args) {

        
        int[] n = new int[5]; // = int n1, n2, n3, n4, n5;
        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[4] = 444;

        int[] num = {666, 777, 999};

        string[] veiculos = {"Carro", "Navio", "Caminhão"};

        int[,] m=new int[3,5];
        m[0,0]=10; m[0,1]=20; m[0,2]=30; m[0,3]=40; m[0,4]=50;
        m[1,0]=60; m[1,1]=70; m[1,2]=80; m[1,3]=90; m[1,4]=15;
        m[2,0]=25; m[2,1]=35; m[2,2]=45; m[2,3]=55; m[2,1]=55;

        System.Console.WriteLine(n[3]);
        System.Console.WriteLine(num[1]);
        System.Console.WriteLine(veiculos[2]);
        System.Console.WriteLine(m[1,3]);   
    }
}
