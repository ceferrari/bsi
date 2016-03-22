using System;

namespace Universidade
{
    public class UniDepPro : IRelacionavel<Tuple<UniDep, int>>
    {
        /* Chaves.Item1 = CodigoUniDep, Chaves.Item2 = CodigoProfessor */
        public Tuple<UniDep, int> Chaves { get; set; }

        public UniDepPro(Tuple<UniDep, int> chaves)
        {
            Chaves = chaves;
        }

        public override bool Equals(object obj)
        {
            return Chaves.Equals((obj as UniDepPro).Chaves);
        }

        public override int GetHashCode()
        {
            return new { Chaves.Item1, Chaves.Item2 }.GetHashCode();
        }
    }
}
