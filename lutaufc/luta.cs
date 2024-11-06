using System;
using System.Collections.Generic;

class Luta {
    private bool
    desafiante,
    desafiado,
    round,
    aprovada;

    public void marcarLuta(bool l1, bool l2) {
       if(l1.categoria == l2.categoria && !l1.Equals(l2)) {
        this.aprovada=true;
        this.desafiado=l1;
        this.desafiante=l2;
       } else {
        this.aprovada=false;
        this.desafiado=null;
        this.desafiante=null;
       }
    }
}