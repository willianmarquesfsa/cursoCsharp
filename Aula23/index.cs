using System;

class Aula23{

    static void Main(){
        int[] vetor1= new int[5];
        int[] vetor2= new int[5];
        int[] vetor3= new int[5];
        int[,] matriz= new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random=new Random(); //escolhe um numero aleatorio

        for(int i=0;i<vetor1.Length;i++){
            vetor1[i]=random.Next(50); //next() escolhe, 50 valor maximo ou minimo e maximo
        }
        Console.WriteLine("Elementos do Vetor1");
        foreach( int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,valor)

        Console.WriteLine("BanarySearch"); //retorna a posição do elemento pesquisado, se não tiver retorna -1
        int procurando=33;
        int pos=Array.BinarySearch(vetor1,procurando);

        Console.WriteLine("Valor {0} esta na posição {1}", procurando, pos);
        Console.WriteLine("___________________");

        //publuc static void Copy(Ar_origem, ar_destino,qtde_elementos) 
        Console.WriteLine("Copy");        
        Array.Copy(vetor1,vetor2,vetor1.Length); //copia dos elemento de arr para outro
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("___________________");

        //public void CopyTo(Ar_destino, a_pertir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0);  // copia com p parametro de destino e a partir de uma determinada posição 
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
        int MenorIndiceVetor=vetor1.GetLowerBound(0); //menor indice indice de um vetor
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
        int valor0=Convert.ToInt32(vetor1.GetValue(3)); //retorno o valor de um determinado indice
        //int vetor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("___________________");


        //public static int IndexOF(array,valor);
        Console.WriteLine("IndexOF");  //retorna a posição do primeiro valor encontrado
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Índice do promeiro valor 3: {0}", indice1);
        Console.WriteLine("__________________");

        //public static int LastIndexOF(array,valor);
        Console.WriteLine("LastIndexOF");  //retorna a posição do utimo valor encontrado
        int indice2=Array.IndexOf(vetor2,3);
        Console.WriteLine("Índice do promeiro valor 3: {0}", indice2);
        Console.WriteLine("__________________");

        //public static void Reverse(array)
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        

        //public void SetValue(object valor, logn pos) 
        vetor2.SetValue(99,0); //setar valor na posição indicada
        for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);

        }

        //public static void Sort(Array) //ordena na ordem crescenteaula
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("\nVetor1");
        foreach(var n in vetor1){
        Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach(var n in vetor2){
        Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach(var n in vetor3){
        Console.WriteLine(n);
        }

        {
            
        }

    


    }
}
