namespace Universidade
{
    public class DepartamentoProfessor
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public int CodigoUniDep { get; set; }
        public int CodigoProfessor { get; set; }

        public DepartamentoProfessor(int unidep, int professor)
        {
            CodigoUniDep = unidep;
            CodigoProfessor = professor;
        }
    }
}
