using System;

namespace setimaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("j1");
            Personagemum mario = new Personagemum();
            mario.Correr();
            mario.Pular();

            System.Console.WriteLine("j1");
            Jogadordois luigi = new Jogadordois();
            luigi.Correr();
            luigi.Pular();
        }
    }
}
