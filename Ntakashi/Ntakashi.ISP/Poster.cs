
namespace Ntakashi.ISP
{
    public class Poster : IProduto
    {
        public int QuantidaEmEstoque { get; set; }
        public int FaixaEtaria { get; set; }
        public decimal ValorDoPRoduto { get; set; }
        public float TempoDeDuracao { get; set; }
    }
}
