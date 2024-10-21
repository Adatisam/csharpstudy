using System;

class ex3 {

    static void Main(string[] args)
    {
        int tempo = 0;
        string escolha;

        resetar:

        Console.Clear();

        System.Console.WriteLine("Foz do Iguaçu/PR a Brasilia/DF");
        System.Console.WriteLine("Escolha o transporte: ");
        System.Console.WriteLine("[a] = Avião\t | R$1000");
        System.Console.WriteLine("[c] = Carro\t | R$300");
        System.Console.WriteLine("[o] = Ônibus\t | R$300");

        escolha = Console.ReadLine().ToUpper();
        switch (escolha) {
            case "A":
                escolha = "Avião";
                tempo = 50;
                break;
            case "C":
                escolha = "Carro";
                tempo = 500;
                break;
            case "O":
                escolha = "Ônibus";
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }
        if (tempo < 0) {
            System.Console.WriteLine("Opção inválida!");
        } else {
            System.Console.WriteLine($"A opção escolhida foi de {escolha} tempo de viagem sera de {tempo}.");
        }

        System.Console.Write("\nDeseja continuar? [s]/[n]: ");
        escolha = Console.ReadLine().ToUpper();

        if (escolha == "S") {
            goto resetar;
        } else {
            Console.Clear();
            System.Console.WriteLine("FIM DO PROPRAGA!");
        }
        
    }
}