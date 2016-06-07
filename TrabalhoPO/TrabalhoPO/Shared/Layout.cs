using System;

namespace TrabalhoPO.Shared
{
    public sealed class Classe
    {
        private readonly int valor;
        private readonly string nome;

        public static readonly Classe NULL = new Classe(0, String.Empty);
        public static readonly Classe SUCESSO = new Classe(1, "text-success");
        public static readonly Classe ALERTA = new Classe(2, "text-warning");
        public static readonly Classe ERRO = new Classe(3, "text-danger");

        private Classe(int valor, string nome)
        {
            this.valor = valor;
            this.nome = nome;
        }

        public override string ToString()
        {
            return nome;
        }
    }

    public sealed class Icone
    {
        private readonly int valor;
        private readonly string nome;

        public static readonly Icone NULL = new Icone(0, String.Empty);
        public static readonly Icone SUCESSO = new Icone(1, "fa fa-check-circle");
        public static readonly Icone ALERTA = new Icone(2, "fa fa-warning");
        public static readonly Icone ERRO = new Icone(3, "fa fa-times-circle");

        private Icone(int valor, string nome)
        {
            this.valor = valor;
            this.nome = nome;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}