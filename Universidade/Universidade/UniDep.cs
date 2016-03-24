using System;

namespace Universidade
{
    /* Relacionamento entre Universidade e Departamentor */
    public class UniDep : IRelacionavel<int>, IComparable
    {
        /* Chaves.Item1 = CodigoUniversidade // Chaves.Item2 = CodigoDepartamento */
        public Tuple<int, int> Chaves { get; set; }
        
        public UniDep(Tuple<int, int> chaves)
        {
            Chaves = chaves;
        }

        public override int GetHashCode()
        {
            return new { Chaves.Item1, Chaves.Item2 }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj == null) ? false : Chaves.Equals((obj as UniDep).Chaves);
        }

        public int CompareTo(object other)
        {
            return Chaves.Equals((other as UniDep).Chaves) ? 1 : 0;
        }
    }
}
