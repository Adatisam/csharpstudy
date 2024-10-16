using System;

class teste {
    enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}
    static void Main(string[] args)
    {
        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana dc = (DiasSemana)3;
        int dd = (int)DiasSemana.Sexta;
        System.Console.WriteLine(ds);
        System.Console.WriteLine(dc);
        System.Console.WriteLine(dd);
    }
    
}
