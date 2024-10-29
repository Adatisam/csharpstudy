using System;
class Juros {
    static void Main(){

        Voltar:
        Console.Clear();

        System.Console.Write("Digite o valor total do imóvel: ");
        double preco = double.Parse(Console.ReadLine()); //valor do imóvel
        System.Console.Write("Digite o valor da taxa de juros ao ano: ");
        double porc = double.Parse(Console.ReadLine()); //taxa de juros anual
        porc = porc/100;
        System.Console.Write("Digite em quantos anos ira pagar o financiamento: ");
        int ano = int.Parse(Console.ReadLine()); //tempo em ano

        double meses = porc /12;
        int n = ano * 12;

        //prestação
        double mensal = preco * (meses * Math.Pow(1+meses,n))/(Math.Pow(1+meses,n)-1);
        //total a pagar
        double total = mensal * n;

        System.Console.WriteLine($"Valor da prestação mensal: R$ {mensal:F2}");
        System.Console.WriteLine($"Valor total a pagar: R$ {total:F2}");

        System.Console.Write("Deseja continuar [s/n]: ");
        string resp = Console.ReadLine().ToUpper();

        if (resp == "S") {
            goto Voltar;
        } else {
            System.Console.WriteLine("FIM DO PROGRAMA!");
        }
    }
}