using System;
using System.Collections.Generic;

namespace LutadorApp{
    class Lutador{
        private string nome;
        private string categoria;
        private string nacionalidade;
        private int idade;
        private int vitorias;
        private int derrotas; 
        private int empates;
        private float peso;
        private float altura;

        public Lutador(string no, string na, int id, float al, float pe, int vi, int de, int em) {
            nome=no;
            nacionalidade=na;
            idade=id;
            altura=al;
            setPeso(pe);
            vitorias=vi;
            derrotas=de;
            empates=em;
        }

        public string getNome(){
            return nome;
        }
        public void setNome(string no){
            nome=no;
        }
        public string getNac(){
            return nacionalidade;
        }
        public void setNac(string na){
            nacionalidade=na;
        }
        public int getIdade(){
            return idade;
        }
        public void setIdade(int id) {
            idade=id;
        }
        public float getAlt(){
            return altura;
        }
        public void setAlt(float al) {
            altura=al;
        }
        public float getPeso(){
            return peso;
        }
        public void setPeso(float pe){
            peso=pe;
            setCategoria();
        }
        public string getCategoria(){
            return categoria;
        }
        public void setCategoria() {
            if (peso < 52.2F){
                categoria="Inválido";
            } else if (peso <= 70.3F) {
                categoria="Pena";
            } else if (peso <= 83.9F) {
                categoria="Médio";
            } else if (peso <= 120.2F) {
                categoria="Pesado";
            } else {
                categoria="Inválido";
            }
        }
        public int getVitorias() {
            return vitorias;
        }
        public void setVitorias(int vi) {
            vitorias=vi;
        }
        public int getDerrotas() {
            return derrotas;
        }
        public void setDerrotas(int de) {
            derrotas=de;
        }
        public int getEmpates() {
            return empates;
        }
        public void setEmpates(int em) {
            empates=em;
        }

        public void apresentar() {
            System.Console.WriteLine("-------------------------------");
            System.Console.WriteLine("CHEGOU A HORA! O lutador" + getNome());
            System.Console.WriteLine("veio diretamente de " + getNac() + ", com " + getAlt() + " metros de altura, pesando " + getPeso() + "Kg,");
            System.Console.WriteLine(getVitorias() + " Vitórias, " + getDerrotas() + " Derrotas, e " + getEmpates() + " Empates.");
        }
        public void status() {
            System.Console.WriteLine(getNome() + " é um peso " + getCategoria() + " e já ganhou " + getVitorias() + " vezes, perdeu "+ getDerrotas() + " e empatou "+ getEmpates() + "!");
            System.Console.WriteLine("-------------------------------");
        }
        public void ganharLuta() {
            setVitorias(getVitorias()+1);
        }
        public void perderLuta() {
            setDerrotas(getDerrotas()+1);
        }
        public void empatarLuta() {
            setEmpates(getEmpates()+1);
        } 
    }
}