using System;
class Carro {
    private int[] velMax={80,120,160,240,300};
    public int this[int i] {
        get{
            return velMax[i];
        }
        set {
            if (value < 0) {
                velMax[i]=0;
            } else if (value>300) {
                velMax[i]=300;
            } else {
                velMax[i]=value;
            }
        }
    }
}
class Bora{
    static void Main() {
        Carro c1=new Carro();
        c1[1]=200;
        System.Console.WriteLine($"Velocidade: {c1[1]}");
    }
}