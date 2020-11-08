using System;

public class Jogador{
    public int energia;
    bool vivo;
    public string nome;

    public Jogador(string n){  //metodo contrutor e de mesmo noma da classe
        nome=n;
        vivo=true;
        energia=100;
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido", nome);
    }
}
class Aula29{

  static void Main(){

      string nome1;
      string nome2;

      Console.WriteLine("Digite o nome do jogador 1");
      nome1=Console.ReadLine();  
      Console.WriteLine("Digite o nome do jogador 2");
      nome2=Console.ReadLine();
      Jogador j1=new Jogador(nome1); 
      Jogador j2=new Jogador(nome2);
      //Jogador j3=new Jogador();

     

      Console.WriteLine("Energia do jogador 1: {0} é {1}", j1.nome, j1.energia);
      Console.WriteLine("Energia do jogador 1: {0} é {1}", j2.nome, j2.energia);

  }

}