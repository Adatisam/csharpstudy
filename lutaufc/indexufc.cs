using System;
using System.Collections.Generic;
using LutadorApp;

namespace LutadorApp{
    class horaLuta{
        static void Main() {
            replay:
            Console.Clear();
            Lutador l3 = new Lutador("Pretty boy", "França", 31, 1.75F, 104F, 9, 11, 2);
            Lutador l4 = new Lutador("Leitão", "Brasil", 25, 1.86F, 119.88F, 2, 8, 8);
            l3.apresentar();
            l4.apresentar();
            l3.ganharLuta();
            //l4.perderLuta();
            l3.status();
            l4.status();
            Luta bateroucorrer = new Luta();
            bateroucorrer.marcarLuta(l3, l4);
            bateroucorrer.lutar();
            System.Console.WriteLine("------------------------------");
            System.Console.Write("Deseja continuar? [s/n]");
            string alternativa=Console.ReadLine().ToUpper();
            if (alternativa == "S"){
                goto replay;
            } else {
                System.Console.WriteLine("FIM DO PROGRAMA!");
            }
        
            
        }
    }
}