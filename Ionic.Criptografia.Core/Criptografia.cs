namespace Ionic.Criptografia.Core
{
    public class Criptografia : ICriptografia
    {
        public IEnumerable<int> Criptografar(string mensagem, string chave)
        {
            var mensagemFormatada = FormatadorDeMensagem.Formatar(mensagem);
            var chaveFormatada = FormatadorDeMensagem.Formatar(chave);

            var polybius = new Polybius();

            var mensagemCriptografada = polybius.GerarCriptografia(mensagemFormatada);
            var chaveCriptografada = polybius.GerarCriptografia(chaveFormatada);

            Thread.Sleep(7000);

            return GerarCriptografia(mensagemCriptografada, chaveCriptografada);
        }

        public void Descriptografar(Task<IEnumerable<int>> resultadoCriptografia, string chave)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<int> GerarCriptografia(IEnumerable<int> resultadoMensagem, IEnumerable<int> resultadoChave)
        {
            for (int index = 0; index < resultadoMensagem.Count(); index++)
            {
                yield return resultadoMensagem.ElementAt(index) + resultadoChave.ElementAt(index);
            }
        }
    }
}