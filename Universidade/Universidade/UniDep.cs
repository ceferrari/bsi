namespace Universidade
{
    public class UniDep
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public int CodigoUniversidade { get; set; }
        public int CodigoDepartamento { get; set; }

        public UniDep(int universidade, int departamento)
        {
            Codigo = Cont++;
            CodigoUniversidade = universidade;
            CodigoDepartamento = departamento;
        }
    }
}
