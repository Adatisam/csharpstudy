using System;

class Base{
    public Base() {
        System.Console.WriteLine("Construtor da classe Base");
    }
    public void Info(){
        System.Console.WriteLine("Base");
    }
}
class Derivada1:Base{
    public Derivada1() {
        System.Console.WriteLine("Construtor da classe Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2() {
        System.Console.WriteLine("Construtor da classe Derivada2");
    }
}

class ex01{
    static void Main() {
        Derivada2 d2=new Derivada2();
        d2.Info();
    }
}