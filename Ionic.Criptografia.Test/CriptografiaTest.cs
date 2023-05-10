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
        public void Criptografar()
        {
            // arrange
            var mensagem = "IONIC";
            var chave = "IONIC";

            // act
            var resultado = _criptografia.Criptografar(mensagem, chave);

            // A
            Assert.Collection(resultado.ToList(),
               item => Assert.Equal(48, item),
               item => Assert.Equal(68, item),
               item => Assert.Equal(66, item),
               item => Assert.Equal(48, item),
               item => Assert.Equal(26, item)
           );
        }
    }
}