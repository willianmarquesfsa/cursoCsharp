using System;

class Aula25{
    static void Main(){
        int num=10;
        dobrar(ref num);
        Console.WriteLine(num);

    }
    static void dobrar( ref int valor){ //ref para a passagem de referencia
       valor*=2;
    }
}