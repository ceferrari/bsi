﻿namespace Universidade
{
    public class Professor : INomeavel
    {
        public static int Cont { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Professor(string nome)
        {
            Codigo = Cont++;
            Nome = nome;
        }
    }
}
