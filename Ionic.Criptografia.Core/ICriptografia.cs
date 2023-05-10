namespace Ionic.Criptografia.Core
{
    public interface ICriptografia
    {
        IEnumerable<int> Criptografar(string mensagem, string chave);

        void Descriptografar(Task<IEnumerable<int>> resultadoCriptografia, string chave);
    }
}