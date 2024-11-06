using System;

public class Jogador {
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        nome="Jogador";
        energia=100;
        vivo=true;
    }
    public Jogador(string n) {
        nome=n;
        energia=100;
        vivo=true;
    }
    public Jogador(string n, int e) {
        nome=n;
        energia=e;
        vivo=true;
    }
    public Jogador(string n, int e, bool v) {
        nome=n;
        energia=e;
        vivo=v;
    }
    public void info() {
        System.Console.WriteLine($"Nome do jogador.......{nome}");
        System.Console.WriteLine($"Energia do jogador....{energia}");
        System.Console.WriteLine($"Condição do jogador...{vivo}\n");
    }
}

class ex05 {
    static void Main() {
        Jogador j1=new Jogador();
        Jogador j2=new Jogador("Bruno");
        Jogador j3=new Jogador("Theo", 100);
        Jogador j4=new Jogador("Mega",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}