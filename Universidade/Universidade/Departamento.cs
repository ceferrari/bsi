namespace Universidade
{
    public class Departamento : INomeavel
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Departamento(string nome)
        {
            Codigo = Cont++;
            Nome = nome;
        }
    }
}
