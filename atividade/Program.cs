using System;
/*  enunciado: Chame todos os métodos criados no Program.cs, através de instâncias das classes filhas.
            Suba a atividade para um repositório no github chamado "RelatoriosPOO" e entregue o link como envio desta atividade
            Capacidade: Utilizar o paradigma da programação orientada a objetos

            Nesta atividade crie as classes:
            Relatorio
            - datetime data
            + public virtual void MostrarRelatorio();
                ConsoleWriteLine("Mostrando relatório geral")

            Mensal : Relatorio
            + public override void MostrarRelatorio();
                base.MostrarRelatorio();
                ConsoleWriteLine("Mostrando relatório por mês");
                
            Anual : Relatorio
            + public override void MostrarRelatorio();
                base.MostrarRelatorio();
                ConsoleWriteLine("Mostrando relatório por ano")
*/
namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
