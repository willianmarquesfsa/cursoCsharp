using System;

class Aula12{
    static void Main(){
        /*int num=5;
        while(num<5){
              Console.WriteLine("Willian1");  
        }
        do{
                 Console.WriteLine("Willian2");
        }while(num<5);//executa e depois ele testa
        */
        string senha="123";
        string senhauser;
        int tetativas=0;

        

        do{  
             Console.Clear();
             Console.WriteLine("Digite a senha");
             senhauser=Console.ReadLine();
             tetativas++;
        }while(senha != senhauser);  //so vai para o loop quando não atender a equação
         Console.Clear();
         Console.WriteLine("Senha correta, tentativas: {0}", tetativas);
    }
}