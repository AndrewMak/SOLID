
namespace Ntakashi.DIP.Violacao
{
    public class Botao
    {
        private readonly Lampada _lampada;
        public void Acionar()
        {
            if(!_lampada.Ligado)
            {
                _lampada.Ligar();
            } 
        }
        
    }
}
