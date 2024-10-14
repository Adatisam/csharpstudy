using System;
class ex01 {
    static void Main() {
        string nome = "Matheus";
        int num1, num2, num3 = 0;

        System.Console.WriteLine($"Nome: {nome}");

        num1 = 3;
        num2 = 4;
        num3 = 2;
        int soma = num1 + num2 + num3;

        System.Console.WriteLine($"A soma entre os valores de {num1}, {num2} e {num3} é igual a {soma}.");
    
        static void teste() {
            int num = 12;
            System.Console.WriteLine(num);
        }
    }
}
