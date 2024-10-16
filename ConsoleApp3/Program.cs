using System;

class ex3 {

    static void Main(string[] args)
    {
        int idade,v1,v2,soma;
        string nome;

        System.Console.Write("Digite seu nome: ");
        nome=Console.ReadLine();
        System.Console.WriteLine($"Prazer em conhece-lo(a) {nome}");
        if (nome == "Matheus")
        {
            System.Console.WriteLine("Seu nome é foda.");
        } else
        {
            System.Console.WriteLine("Nome meia boca.");
        }
        System.Console.WriteLine("Digite sua idade: ");
        idade=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Idade armazenada.");
        System.Console.Write("Digite um valor: ");
        v1=int.Parse(Console.ReadLine());
        System.Console.Write("Digite um segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine());
        soma=v1+v2;
        System.Console.WriteLine($"A soma entre {v1} e {v2} é {soma}");

    }
}