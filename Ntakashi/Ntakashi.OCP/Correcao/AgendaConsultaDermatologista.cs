namespace Ntakashi.OCP.Correcao
{
    public class AgendaConsultaDermatologista : ConsultaMedica
    {
        public override System.DateTime AgendaConsulta(System.DateTime horario)
        {
            return horario;
        }
    }
}
