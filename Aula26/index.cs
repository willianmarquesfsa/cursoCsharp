using System;

class Aula26{
    static void Main(){
        int divid,divis,quac,rest;
        divid=10;
        divis=3;
        quac=divide(divid,divis, out rest);
        Console.WriteLine("{0}/{1}: quociente={2} e resto={3}", divid, divis,quac, rest);



    }

    static int divide(int dividento, int divisor,out int resto){
        int quociente;
        quociente=dividento/divisor;
        resto=dividento%divisor;
        return quociente;
    }
}