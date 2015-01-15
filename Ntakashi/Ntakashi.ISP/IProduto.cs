
namespace Ntakashi.ISP
{
    public interface IProduto
    {
        int QuantidaEmEstoque { get; set; }
        int FaixaEtaria { get; set; }
        decimal ValorDoPRoduto { get; set; }
        float TempoDeDuracao { get; set; }

    }
}
