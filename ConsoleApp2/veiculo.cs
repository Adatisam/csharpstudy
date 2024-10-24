using System;

/*class Veiculo {//Classe Base
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas){
        this.rodas=rodas;
    }
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }

    public string getLigado() {
        if (ligado) {
            return "Sim";
        } else {
            return "Não";
        }
    }
    public int getRodas() {
        return rodas;
    }
    public void setRodas(int rodas) {
        if(rodas<0) {
            this.rodas=0;
        } else if(rodas>40) {
            this.rodas=40;
        } else {
            this.rodas=rodas;
        }
    }
}

 class Carro:Veiculo{
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4) {
        desligar();
        velMax=120;
        this.nome=nome;
        this.cor=cor;
    }
}

class CarroCombate:Carro {
    public int municao;
    public CarroCombate():base("Carro de Combate", "Camuflado") {
        municao=100;
        setRodas(6);
    }
}

class Go{
    static void Main(string[] args) {
        Carro c1=new Carro("Civic", "Azul");
        CarroCombate c2=new CarroCombate();

        c1.ligar();
        c2.ligar();

        System.Console.WriteLine($"Nome........:{c1.nome}");
        System.Console.WriteLine($"Cor.........:{c1.cor}");
        System.Console.WriteLine($"Rodas.......:{c1.getRodas()}");
        System.Console.WriteLine($"Vel.máxima..:{c1.velMax}");
        System.Console.WriteLine($"Ligado......:{c1.getLigado()}\n");

        System.Console.WriteLine($"Nome........:{c2.nome}");
        System.Console.WriteLine($"Cor.........:{c2.cor}");
        System.Console.WriteLine($"Rodas.......:{c2.getRodas()}");
        System.Console.WriteLine($"Vel.máxima..:{c2.velMax}");
        System.Console.WriteLine($"Ligado......:{c2.getLigado()}");
        System.Console.WriteLine($"Munição.....:{c2.municao}");
        
        
    }
}*/