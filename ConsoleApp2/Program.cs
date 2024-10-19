using System;
class ex2{
    static void Main(string[] args) {
        ola();
        int v1,v2,r;
        System.Console.Write("Digite o primeiro valor: ");
        v1=Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
        //soma(v1,v2);
        r=soma(v1,v2);
        Console.WriteLine($"A soma de {v1} + {v2} = {r}");

    }

    static void ola() {
        System.Console.WriteLine("oi");
    }

    static int soma(int n1,int n2){
        int resp=n1+n2;
        return resp;
        //Console.WriteLine($"A soma de {n1} + {n2} = {resp}");
    }
}
