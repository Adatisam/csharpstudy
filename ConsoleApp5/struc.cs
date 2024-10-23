using System;

struct Car {
    public string marca;
    public string modelo;
    public string cor;
    public Car(string marca, string modelo, string cor) {
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }
    public void Info() {
        System.Console.Write($"Você tem um carro da marca {this.marca}, ");
        System.Console.Write($"com modelo de {this.modelo} e ");
        System.Console.WriteLine($"com a cor {this.cor}.");
    }
}

class Novo{
    static void Main() {
        int[] num;
        
        Car c1=new Car("Ford", "Mawerick", "preta");
        c1.Info();
        
        Car c2;
        c2.marca="Fiat";
        c2.modelo="Mile";
        c2.cor="Branca";
        c2.Info();
        
    }
}