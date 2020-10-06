using System;

class Aula10{
   enum DiasSemanas{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}    
  

  static void Main(){
         //DiasSemanas ds = DiasSemanas.Quarta;
         DiasSemanas dspn = (DiasSemanas)1;

         int ds = (int)DiasSemanas.Sexta;
         Console.WriteLine(ds);
  }
}