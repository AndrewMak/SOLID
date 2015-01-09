using System;

namespace Ntakashi.OCP
{
    public class ConsultaMedica
    {
        public DateTime AgendaConsulta(Medico medico)
        {
            if (medico.Especialidade.Equals(Especialidade.Alergista))
                return new DateTime(2014, 10, 15);
            if (medico.Especialidade.Equals(Especialidade.Dermatologista))
                return new DateTime(2014, 10, 20);
            throw new Exception("Não foi possivel agendar sua consulta");
        }
    }
}
