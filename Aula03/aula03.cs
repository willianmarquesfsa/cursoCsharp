using System;

class Aula03{
    static void Main(){
        int num1,num2, num3, res;

        num1=10;
        num2=20;
        num3=30;
        res= num1*num2;

        Console.Write(num1*num3);
        byte n1=10; //0 e 255
        int num=-10; 
        char letra= 'c'; // apenas 1 caractere
        float pontoflutuante=5.3f;
        string nome="Willian";

        var auxiliar=10; // com o var não especifica o tipo, o compular determina sozinho

        var auxi=nome;

        Console.Write("Meu nome é:"+auxi);
    }
}