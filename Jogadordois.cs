namespace setimaPOO
{
    public class Jogadordois : jogador
    {
        public override void Pular(){

            // Manter as ações do método pai
            base.Pular();
            System.Console.WriteLine("Luigi agora está pulando com uma altura 30% mais alta");

        }
        
    }
}