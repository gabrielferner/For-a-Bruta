
public class Cracker
{
        public static char primeirochar = 'a';
        public static char ultimochar = 'z';
        public static int tamanhoSenha = 8;
        public static long tentativas = 0;
        public static bool concluido = false;
        public static string password = "abc";

        public static void QuebraSenha(string chaves)
        {
            if (chaves == password)
            {
                concluido = true;
            }
            if (chaves.Length == tamanhoSenha || concluido == true)
            {
                return;
            }
            for (char c = primeirochar; c <= ultimochar; c++)
            {
                tentativas++;
                QuebraSenha(chaves + c);
            }
        }
 }