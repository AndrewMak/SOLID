using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntakashi.DIP
{
    interface IDispositivo
    {
        bool Ligado { get; set; }
        void Ligar();
        void Desligar();
    }
}
