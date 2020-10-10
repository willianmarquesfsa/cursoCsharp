using System;

class Aula23{

    static void Main(){
        int[] vetor1= new int[5];
        int[] vetor2= new int[5];
        int[] vetor3= new int[5];
        int[,] matriz= new int[2,5]{{11,22,00,44},{66,77,88,99,00}};

        Random random=new Random(); //escolhe um numero aleatorio

        for(int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50); //next() escolhe, 50 valor maximo ou minimo e maximo
        }
        Console.WriteLine("Elementos do Vetor1");
        foreach( int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,valor)

        Console.WriteLine("BanarySearch");
        int procurando=33;
        int pos=Array.BinarySearch(vetor1,procurando);

        Console.WriteLine("Valor {0} esta na posição {1}", procurando, pos);
        Console.WriteLine("___________________");

        //publuc static void Copy(Ar_origem, ar_destino,qtde_elementos)
        Console.WriteLine("Copy");        
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("___________________");

        //public void CopyTo(Ar_destino, a_pertir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);
        foreach(int m in vetor3){
            Console.WriteLine(m);
        }
        Console.WriteLine("__________________");

        //public lonh GetLongLength(dimenção);
        Console.WriteLine("GetLonglength");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("__________________");

        //public int GetlowerBound(dimanção);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menos Índice do vetor {0}", MenorIndiceVetor);
        Console.WriteLine("__________________");

        //public int GetUpperBound(dimanção);
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVelor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior Índice do vetor1 {0}",MaiorIndiceVelor);

        //public object GetValue(long íncice);
        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int vetor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("___________________")


        //public static int IndexOF(array,valor);
        Console.WriteLine("IndexOF");
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Índice do promeiro valor 3: {0}", indice1);
        Console.WriteLine("__________________");

    


    }
}
