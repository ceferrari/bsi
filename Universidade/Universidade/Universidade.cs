namespace Universidade
{
    public class Universidade : INomeavel
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Universidade(string nome)
        {
            Codigo = Cont++;
            Nome = nome;
        }
    }
}
