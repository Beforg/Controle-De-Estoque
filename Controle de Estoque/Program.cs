namespace Controle_de_Estoque
{
    internal static class Program
    {
        // Copyright (c) 2024 Bruno Benitez Forgiarni @Beforg.

        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            Application.Run(new FormControleDeEstoque());
            
        }
    }
}