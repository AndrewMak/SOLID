
namespace Ntakashi.LSP
{
    public class Retangulo
    {

        protected int Largura;
        protected int Altura;
        public int Area;

        public virtual void InserirLargura(int largura)
        {
            Largura = largura;
        }

        public virtual void InserirAltura(int altura)
        {
            Altura = altura;
        }

        public int ObterLargura()
        {
            return Largura;
        }

        public int ObterAltura()
        {
            return Altura;
        }

    }
}
