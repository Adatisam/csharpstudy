using System;


class ex01{
    static void Main(string[] args) {
        int n1,n2,res;
        res=n1=n2=0;

        n1=10;
        n2=2;

        try{
            res=n1/n2;
            System.Console.WriteLine($"{n1}/{n2}={res}");
        } catch(Exception e) {
            System.Console.WriteLine($"ERRO:{e.Message}");
            System.Console.WriteLine($"Ex:{e.GetType()}");
        }
        
    }
}