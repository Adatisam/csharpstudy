using System;
abstract class Veiculo{//classe base  abstrata
    protected int velMax;
    protected int velAtual; 
    protected bool ligado;
    public Veiculo(){
        ligado=false;
        velAtual=0;
    }
    public void setLigado(bool ligado) {
        this.ligado=ligado;
    }
    public int getVelAtual() {
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}


class Carro:Veiculo{
    public Carro(){
        velMax=120;
    }
    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}
 

class Aula39{
    static void Main() {
        Carro c1=new Carro();
        c1.aceleracao(10);
        System.Console.WriteLine(c1.getVelAtual());

    }
}