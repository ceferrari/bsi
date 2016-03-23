using System;

namespace Universidade
{
    /* Relacionamento entre UniDep - Relação (Universidade, Departamento) e Professor */
    public class UniDepPro : IRelacionavel<Tuple<UniDep, int>>, IComparable<UniDepPro>
    {
        /* Chaves.Item1 = UniDep // Chaves.Item2 = CodigoProfessor */
        public Tuple<UniDep, int> Chaves { get; set; }

        public UniDepPro(Tuple<UniDep, int> chaves)
        {
            Chaves = chaves;
        }

        public override bool Equals(object obj)
        {
            return (obj == null) ? false : Chaves.Equals((obj as UniDepPro).Chaves);
        }

        public override int GetHashCode()
        {
            return new { Chaves.Item1, Chaves.Item2 }.GetHashCode();
        }

        public int CompareTo(UniDepPro other)
        {
            int result = Chaves.Item1.CompareTo(other.Chaves.Item1);
            return result == 1 ? result : Chaves.Item2.CompareTo(other.Chaves.Item2);
        }
    }
}
