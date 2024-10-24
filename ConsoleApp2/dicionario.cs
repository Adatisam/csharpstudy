using System;
using System.Collections.Generic;
class Aula55{
    static void Main(string[] args) {
        Dictionary <int,string> veiculos = new Dictionary<int, string>();
        //topo:
        Random num=new Random();

        veiculos.Clear();
        int n1 = num.Next(1,20);
        int n2 = num.Next(1,20);
        int n3= num.Next(1,20);
        int n4 = num.Next(1,20);

        veiculos.Add(n1,"d");
        veiculos.Add(n2,"r");
        veiculos.Add(n3,"n");
        veiculos.Add(n4,"o");
        veiculos.Remove(9);
    
        System.Console.WriteLine($"Tamanho do Dictionary: {veiculos.Count()}");
        int chave= num.Next(1,20);
        if (veiculos.ContainsKey(chave)) {
            System.Console.WriteLine($"A chave \"{chave}\" esta na coleção.");
        } else {
            System.Console.WriteLine($"A chave \"{chave}\" não esta na coleção.");
        }

        Dictionary<int, string>.ValueCollection valores=veiculos.Values;
        foreach(KeyValuePair<int, string> i in veiculos) {
            System.Console.WriteLine(i.Key);
        }
         
        string valor="a";
        if (veiculos.ContainsValue(valor)) {
            System.Console.WriteLine($"O valor \"{valor}\" esta na coleção.");
        } else {
            System.Console.WriteLine($"O valor \"{valor}\" não esta na coleção.");
        }
        //goto topo, parou na aula 56;
    }
}