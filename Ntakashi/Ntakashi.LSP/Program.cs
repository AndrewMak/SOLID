using System.Collections.Generic;

namespace Ntakashi.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            var aves = new List<Ave>
            {
                new Aguia(), 
                new Pinguim() 
            };
            aves.ForEach(n => n.Voar());
        }
    }
}
