
namespace Ntakashi.LSP
{
    public class Quadrado : Retangulo
    {
        public override void InserirLargura(int largura)
        {
            base.Largura = largura;
            base.Altura = largura;
        }

        public override void InserirAltura(int altura)
        {
            base.Altura = altura;
            base.Largura = altura;
        }
    }
}
