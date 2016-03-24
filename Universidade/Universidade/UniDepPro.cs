using System;

namespace Universidade
{
    /* Relacionamento entre UniDep - Relação (Universidade, Departamento) e Professor */
    public class UniDepPro : IRelacionavel<UniDep>, IComparable
    {
        /* Chaves.Item1 = UniDep // Chaves.Item2 = CodigoProfessor */
        public Tuple<UniDep, int> Chaves { get; set; }

        public UniDepPro(Tuple<UniDep, int> chaves)
        {
            Chaves = chaves;
        }

        public override int GetHashCode()
        {
            return new { Chaves.Item1, Chaves.Item2 }.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return (obj == null) ? false : Chaves.Equals((obj as UniDepPro).Chaves);
        }

        public int CompareTo(object other)
        {
            return Chaves.Equals((other as UniDepPro).Chaves) ? 1 : 0;
        }
    }
}
