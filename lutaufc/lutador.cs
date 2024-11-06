using System;
using System.Collections.Generic;

class Lutador{
    private bool
    nome,
    nacionalidade, 
    idade,
    altura,
    peso,
    categoria,
    vitorias,
    derrotas, 
    empates;

    public void construct(bool no, bool na, bool id, bool al, bool pe, bool vi, bool de, bool em) {
        this.nome=no;
        this.nacionalidade=na;
        this.idade=id;
        this.altura=al;
        //this.setPeso(pe);
        this.vitorias=vi;
        this.derrotas=de;
        this.empates=em;
    }
    
}