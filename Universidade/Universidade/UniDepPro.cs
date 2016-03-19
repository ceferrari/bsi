namespace Universidade
{
    public class UniDepPro
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public int CodigoUniDep { get; set; }
        public int CodigoProfessor { get; set; }

        public UniDepPro(int unidep, int professor)
        {
            Codigo = Cont++;
            CodigoUniDep = unidep;
            CodigoProfessor = professor;
        }
    }
}
