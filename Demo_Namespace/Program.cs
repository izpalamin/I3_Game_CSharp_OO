namespace Demo_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventaire.Item objetInventaire = new Inventaire.Item();
            objetInventaire.nom = "Pépite";
            objetInventaire.value = 500;
            Console.WriteLine($"Dans mon sac, j'ai une {objetInventaire.nom} de {objetInventaire.value} Pokédollars !");
        }
    }
}
