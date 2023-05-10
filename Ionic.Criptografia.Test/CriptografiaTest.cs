using Ionic.Criptografia.Core;
using System.Collections.Generic;
using Xunit;

namespace Ionic.Criptografia.Test
{
    public class CriptografiaTest
    {
        private readonly ICriptografia _criptografia;

        public CriptografiaTest()
        {
            _criptografia = new Core.Criptografia();
        }

        [Fact]
        public async Task Criptografar()
        {
            // arrange
            var mensagem = "IONIC";
            var chave = "IONIC";

            // act
            var resultado = await _criptografia.CriptografarAsync(mensagem, chave);

            // A
            Assert.Collection(resultado.ToList(),
               item => Assert.Equal(38, item),
               item => Assert.Equal(49, item),
               item => Assert.Equal(76, item),
               item => Assert.Equal(35, item),
               item => Assert.Equal(34, item)
           );
        }
    }
}