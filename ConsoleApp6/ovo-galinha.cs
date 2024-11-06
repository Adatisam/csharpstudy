using System;

class Galinha {
    public string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha) {
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }
    public Ovo botar() {
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}
class Ovo {
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string nomeGalinha) {
        this.numOvo=numOvo;
        this.minhaGalinha=nomeGalinha;
        System.Console.WriteLine($"Ovo criado {this.numOvo} - {this.minhaGalinha}.");
    }
}
class Ref{
    static void Main1() {
        Galinha g1=new Galinha("Rinha de Galo");
        Galinha g2=new Galinha("Frangolino");
        Galinha g3=new Galinha("Joao Frango");

        g1.botar();
        g1.botar(); 
        g1.botar(); 
        g1.botar(); 
    }
}