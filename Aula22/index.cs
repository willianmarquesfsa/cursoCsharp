using System;

class Aula22 {
    static void Main(){
        int[] num=new int[3]{11,22,33};

        for(int i=0; i<num.Length;i++){

                 Console.WriteLine(num[i]);
        }

        foreach(int n in num){    //loop que pega elememtos de array e faz alguma coisa
            Console.WriteLine(n); 
        }

    }
}