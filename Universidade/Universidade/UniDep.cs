using System;

namespace Universidade
{
    /* Relacionamento entre Universidade e Departamentor */
    public class UniDep : IRelacionavel<Tuple<int, int>>
    {
        /* Chaves.Item1 = CodigoUniversidade // Chaves.Item2 = CodigoDepartamento */
        public Tuple<int, int> Chaves { get; set; }
        
        public UniDep(Tuple<int, int> chaves)
        {
            Chaves = chaves;
        }

        public override bool Equals(object obj)
        {
            return (obj == null) ? false : Chaves.Equals((obj as UniDep).Chaves);
        }

        public override int GetHashCode()
        {
            return new { Chaves.Item1, Chaves.Item2 }.GetHashCode();
        }
    }
}
