using System;

class Aula12{
    static void Main(){

         int nota=0;
         int n1,n2,n3,n4,res;
         n1=n2=n3=n4=res=0;

         Console.Write("Ditige a nota 1");
         n1=int.Parse(Console.ReadLine());

         Console.Write("Ditige a nota 2");
         n2=int.Parse(Console.ReadLine());

         Console.Write("Ditige a nota 3");
         n3=int.Parse(Console.ReadLine());

         Console.Write("Ditige a nota 4");
         n4=int.Parse(Console.ReadLine());

         res=n1+n2+n3+n4;

         string resultadoReprp = "Reprovado";
         
                  
         if(res>=60){
             resultadoReprp="Aprovado";
             //Console.WriteLine("Aprovado");
         }

         Console.WriteLine("Nota: {0} - Resultado: {1}",res, resultadoReprp); 
    }
}