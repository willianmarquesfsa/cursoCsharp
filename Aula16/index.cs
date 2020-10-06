using System;

class Aula15{

    static void Main(){

        int tempo = 0;
        char escolha;

        Incio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG  Vitorio/ES");
        Console.WriteLine("Escolha o trasporte: [a]Avião | [c]Carro | [o] Ônibus");
        escolha=char.Parse(Console.ReadLine());
        switch(escolha){
            case 'a':
              tempo=50;
              break;

            case 'c':
               tempo=480;
               break;
            case 'o':
               tempo=660;
               break;   
            default:
               tempo=-1;
               break;             
        }

        if(tempo<0){
            Console.WriteLine("Transporte Indiponivel");
        }
        else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }
        Console.WriteLine("\nCalcular outro trasporte?");
        escolha=char.Parse(Console.ReadLine());

        if(escolha == 's'|| escolha=='S'){

            goto Incio;

        }else{
            Console.Clear();
            Console.WriteLine("Fim do Programa");
          
        }
    }
}