namespace Universidade
{
    public class Departamento
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Departamento(string nome)
        {
            Codigo = Departamento.Cont++;
            Nome = nome;
        }
    }
}
