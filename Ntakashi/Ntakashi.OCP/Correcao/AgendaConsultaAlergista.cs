namespace Ntakashi.OCP.Correcao
{
    public class AgendaConsultaAlergista : ConsultaMedica
    {
        public override System.DateTime AgendaConsulta(System.DateTime horario)
        {
            return horario;
        }
    }
}
