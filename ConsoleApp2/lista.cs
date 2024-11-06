using System;
using System.Collections.Generic;
class ex2{
    static void Main()
    {
        Queue<string>veiculo = new();

        veiculo.Enqueue("Carro");
        veiculo.Enqueue("Moto");
        veiculo.Enqueue("Navio");
        veiculo.Enqueue("Aviao");
        
        string v="Aviao";
        if(veiculo.Contains(v)){
            System.Console.WriteLine($"Veiculo {v} encontrado");
        } else{
            System.Console.WriteLine($"Vieculo {v} não encontrado");
        }
        //System.Console.WriteLine("Primeiro veiculo: "+veiculo.Peek());
        foreach (string ve in veiculo){
            v=veiculo.Dequeue();
            System.Console.WriteLine($"Veiculo removido: {v}");
        }

        System.Console.WriteLine("Tamanho da fila:"+ veiculo.Count);

        while (veiculo.Count > 0){
            System.Console.WriteLine(veiculo.Dequeue);
        }
    }
}