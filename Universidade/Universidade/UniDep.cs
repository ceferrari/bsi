using System;

namespace Universidade
{
    public class UniDep : IRelacionavel
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public Tuple<int, int> Chaves { get; set; }
        /* Chaves.Item1 = CodigoUniversidade, Chaves.Item2 = CodigoDepartamento */

        public UniDep(Tuple<int, int> chaves)
        {
            Codigo = Cont++;
            Chaves = chaves;
        }
    }
}
