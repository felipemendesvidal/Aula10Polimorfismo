namespace atividade
{
    public class relatorio
    {
            // - datetime data
            // + public virtual void MostrarRelatorio();
            //     ConsoleWriteLine("Mostrando relatório geral")
        public DataTime data;
        public virtual void MostrarRelatorio(){
            System.Console.WriteLine("mostra relatorio");
        }
    }
}