using System;
using System.Collections.Generic;
using LutadorApp;

namespace LutadorApp{
    class Luta {
        private Lutador desafiante;
        private Lutador desafiado;
        private bool aprovada;
        Random rand= new Random();

        public void marcarLuta(Lutador l1, Lutador l2) {
            if (l1.getCategoria == l2.getCategoria && (l1 != l2)) {
                aprovada=true;
                desafiado=l1;
                desafiante=l2;
            } else {
                aprovada=false;
                desafiado=null;
                desafiante=null;
            }
        }
        public void lutar() {
            if (aprovada) {
                desafiado.apresentar();
                desafiante.apresentar();
                int vencedor = rand.Next(0,2);
                switch (vencedor) {
                    case 0: //empate
                        System.Console.WriteLine("Empate!");
                        desafiado.empatarLuta();
                        desafiante.empatarLuta();
                        break;
                    case 1: //desafiado vence
                        System.Console.WriteLine("O vencedor é " + desafiado.getNome() + "!");
                        desafiado.ganharLuta();
                        desafiante.perderLuta();
                        break;
                    case 2: //desafiante vence
                        System.Console.WriteLine("O vencedor é " + desafiante.getNome() + "!");
                        desafiado.perderLuta();
                        desafiante.ganharLuta();
                        break;
                }
            } else {
                System.Console.WriteLine("===============================");
                System.Console.WriteLine("A luta foi cancelada!");
                System.Console.WriteLine("===============================");
            }
        }
        public Lutador getDesafiante() {
            return desafiante;
        }
        public void setDesafiante(Lutador de){
            desafiante=de;
        }
        public Lutador getDesafiado(){
            return desafiado;
        }
        public void setDesafiado(Lutador d){
            desafiado=d;
        }
        public bool getAprovada(){
            return aprovada;
        }
        public void setAprovada(bool a){
            aprovada=a;
        }
    }
}