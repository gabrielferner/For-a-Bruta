
using System;
using System.Diagnostics;
namespace CShp_ForcaBruta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de Força Bruta");
            Console.Write("\nInforme uma senha  > ");

            Cracker.password = Convert.ToString(Console.ReadLine());
            Cracker.password = Cracker.password.ToLower();
            Console.WriteLine("\nQuebrando a senha...");
            Stopwatch timer = Stopwatch.StartNew();

            Cracker.tamanhoSenha = Cracker.password.Length;
            Cracker.QuebraSenha(string.Empty);

            timer.Stop();
            long elapsedMs = timer.ElapsedMilliseconds;
            double tempoGasto = elapsedMs / 1000;

            if (tempoGasto > 0)
            {
                Console.WriteLine("\n\nA senha foi hackeada! Estatísticas:");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Password: {0}", Cracker.password);
                Console.WriteLine("Tamanho Senha: {0}", Cracker.tamanhoSenha);
                Console.WriteLine("Tentativas: {0}", Cracker.tentativas);
                string plural = "segundos";
                if (tempoGasto == 1)
                {
                    plural = "segundo";
                }
                Console.WriteLine("Tempo gasto para hackear a senha: {0} {1}", tempoGasto, plural);
                Console.WriteLine("Senhas por segundo : {0}", (long)(Cracker.tentativas / tempoGasto));
            }
            else
            {
                Console.WriteLine("\n\nA senha foi hackeada ! Estatísticas:");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Senha: {0}", Cracker.password);
                Console.WriteLine("Tamnho da Senha: {0}", Cracker.tamanhoSenha);
                Console.WriteLine("Tentativas: {0}", Cracker.tentativas);
                Console.WriteLine("Tempo para hackear : {0} segundos", tempoGasto);
            }
            Console.ReadKey();
        }
    }
}