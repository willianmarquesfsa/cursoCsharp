using System;

 class Aula27{
   
   static void Main(){

       soma(10,25,12,23);

   }

   static void soma(params int[]n){
       int res=0;
       if(n.Length<1){
         Console.WriteLine("Não ha valores");
       } else if(n.Length<2){
           Console.WriteLine("Não tem soma com 1 numero");
       }
       else{
           for(int i=0;i<n.Length;i++){
               res+=n[i];
           }
           Console.WriteLine("A soma dos valores é {0}",res);
       }
       
   }
        
}
