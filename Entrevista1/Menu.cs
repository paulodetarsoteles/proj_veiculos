namespace Entrevista1
{
    public struct Menu
    {
        public static string Opcoes()
        {
            Console.WriteLine("DIGITE A OPCAO DESEJADA: ");
            Console.WriteLine();
            Console.WriteLine("1. Listar Veiculos");
            Console.WriteLine("Outra tecla para sair");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}