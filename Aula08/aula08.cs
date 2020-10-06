using System;


class Aula08{

    static void Main(){

        int v1, v2, soma;

        string nome;

        Console.Write("Digite v1:");
        v1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite v2:");
        v2=int.Parse(Console.ReadLine());

        soma=v1+v2;

        Console.WriteLine("A soma de {0} + {1} = {2}", v1,v2,soma);
    }
}