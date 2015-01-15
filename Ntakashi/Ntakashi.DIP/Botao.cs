namespace Ntakashi.DIP
{
    public class Botao
    {
        private readonly IDispositivo _dispositivo;
        public void Acionar()
        {
            if (!_dispositivo.Ligado)
            {
                _dispositivo.Ligar();
            }
        }
    }
}
