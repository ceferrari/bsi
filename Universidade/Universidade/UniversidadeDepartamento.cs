namespace Universidade
{
    public class UniversidadeDepartamento
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public int CodigoUniversidade { get; set; }
        public int CodigoDepartamento { get; set; }

        public UniversidadeDepartamento(int universidade, int departamento)
        {
            Codigo = UniversidadeDepartamento.Cont++;
            CodigoUniversidade = universidade;
            CodigoDepartamento = departamento;
        }
    }
}
