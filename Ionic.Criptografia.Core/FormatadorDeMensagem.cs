using System.Text.RegularExpressions;


namespace Ionic.Criptografia.Core
{
    public class FormatadorDeMensagem
    {
        public static string Formatar(string mensagem)
        {
            return Regex.Replace(mensagem, @"[^0-9a-zA-Z\._]", "");
        }
    }
}
