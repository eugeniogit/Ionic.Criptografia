using Ionic.Criptografia.Core;
using Xunit;

namespace Ionic.Criptografia.Test
{
    public class PolybiusTest
    {
        private readonly Polybius _polybius;

        public PolybiusTest()
        {
            _polybius = new Polybius();
        }

        [Fact]
        public void Criptografar()
        {
            // arrange
            var mensagem = "IONIC";

            // act
            var resultado = _polybius.GerarCriptografia(mensagem).ToList();

            // assert
            Assert.Collection(resultado,
               item => Assert.Equal(24, item),
               item => Assert.Equal(34, item),
               item => Assert.Equal(33, item),
               item => Assert.Equal(24, item),
               item => Assert.Equal(13, item)
           );
        }
    }
}