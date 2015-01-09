using System;

namespace Ntakashi.LSP
{
    public class Pinguim : Ave
    {
        public override string Voar()
        {
            throw new Exception("Pinguim não voa.");
        }
    }
}
