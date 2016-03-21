using System;

namespace Universidade
{
    public class UniDepPro : IRelacionavel
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public Tuple<int, int> Chaves { get; set; }
        /* Chaves.Item1 = CodigoUniDep, Chaves.Item2 = CodigoProfessor */

        public UniDepPro(Tuple<int, int> chaves)
        {
            Codigo = Cont++;
            Chaves = chaves;
        }
    }
}
