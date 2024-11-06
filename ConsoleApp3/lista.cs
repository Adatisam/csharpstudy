using System;
using System.Collections.Generic;  
class Teste {
    static void Main() {
        LinkedList<string>transp = new LinkedList<string>();
        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bike");

        LinkedListNode<string>no;
        no=transp.FindLast("Navio");
        transp.AddAfter(no,"Patinete");
        no=transp.FindLast("Navio");
        transp.AddBefore(no,"Patins");

        if (transp.Find("Caroo")==null) {
            System.Console.WriteLine("Elemento não encontrado");
        } else {
            System.Console.WriteLine("Elemento encontrado");
        }

        transp.Remove("Navio");
        transp.RemoveFirst();
        transp.RemoveLast();

        foreach (string i in transp) {
            System.Console.WriteLine($"Transporte: {i}"); 
             
        }

    }
}