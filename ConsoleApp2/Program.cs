using System;

class ex2{
    static void Main(string[] args) {
        int n1, n2, n3;
        int mult;
        n1=22;
        n2=22;
        n3=44;
        mult= n1*n2*n3;
        
        System.Console.WriteLine($"{n1} * {n2} * {n3} = {mult}");

        double valorCompra = 1200;
        double valorVenda;
        double lucro = 0.2;
        string produto = "Notebook";
        valorVenda=valorCompra+(valorCompra*lucro);
        System.Console.WriteLine("Produto:.....{0,15}",produto);
        System.Console.WriteLine("Val.Compra:..{0,15:c}",valorCompra);
        System.Console.WriteLine("Lucro:.......{0,15:p}",lucro);
        System.Console.WriteLine("Val.Venda:...{0,15:c}",valorVenda);
    }
}
