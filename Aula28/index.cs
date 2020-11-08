using System;


public class Jogador{
    public int energia;
    bool vivo=true;
}
public class Aula28{
  static void Main(){

      Jogador j1=new Jogador(); 
      Jogador j2=new Jogador();
      Jogador j3=new Jogador();

      j1.energia=50;
      j2.energia=100;

      Console.WriteLine("Energia do jogador 1: {0}", j1.energia);

  }

}