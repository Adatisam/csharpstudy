using System;
namespace Cala1{
    class Area{
    public static float Quad(float bas, float alt){
        if (bas==0||alt==0) {
            throw new Exception("Base ou altura não pode ser igual a 0");
        }
        return bas*alt;
    }
}

}
class Ex01{
    static void Main(string[] args) {
        float area=0;

        try{
            area=Cala1.Area.Quad(6.5F, 4.3F);
            System.Console.WriteLine($"Area do quadrado: {area}m³");
        } catch(Exception e) {
            System.Console.WriteLine($"ERRO: {e.Message}");
        } finally {
            System.Console.WriteLine("Fim do processo");
        }
        
    }
}