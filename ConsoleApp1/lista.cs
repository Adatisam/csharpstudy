using System;
using System.Collections.Generic;

class Aula57{
    static void Main() {
        List<string>carros= new List<string>();
        //List<string>carros2= new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Mile");
        carros.Add("Golf");
        carros.Add("Civic");
        carros.Add("Astra");

       // carros2.AddRange(carros);

        //carros.Clear();

        if(carros.Contains("Civic")) {
            System.Console.WriteLine($"Carro Civic enconstrado");
        } else {
            System.Console.WriteLine("Carro Civic não encontrado ");
        }

        carros.CopyTo(carros2,2);

        foreach (string i in carros) {
            System.Console.WriteLine($"Carro registrado: {i}");
        }
        System.Console.WriteLine("----------------------------------------");
        foreach (string i in carros2) {
            System.Console.WriteLine($"Carro registrado: {i}");
        }

        string c="Astra";
        int pos=0;
        pos=carros.IndexOf(c); 
        System.Console.WriteLine($"Carro {c} posição {pos}");
    }
}