using System;

class Veiculo {//Classe Base
    public int rodas;
    public int velMax;
    private bool ligado;

    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public bool getLigado() {
        if (ligado) {
            System.Console.WriteLine("Sim");;
        } else {
            System.Console.WriteLine("Não");
        }
    }
}

 class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor) {
        desligar();
        rodas=4;
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

class Go{
    static void Main(string[] args) {
        Carro c1=new Carro("Civic", "Azul");
        System.Console.WriteLine($"{c1.nome}");
        System.Console.WriteLine($"{c1.cor}");
        System.Console.WriteLine($"{c1.rodas}");
        System.Console.WriteLine($"{c1.velMax}");
        System.Console.WriteLine($"{c1.getLigado}");
        
        
        c1.ligar();
    }
}