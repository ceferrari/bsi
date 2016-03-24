using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Universidade
{
    public static class Listas
    {
        public static BindingList<INomeavel> Universidades { get; private set; }
        public static BindingList<INomeavel> Departamentos { get; private set; }
        public static BindingList<INomeavel> Professores { get; private set; }
        public static HashSet<UniDep> UniDepList { get; private set; }
        public static HashSet<UniDepPro> UniDepProList { get; private set; }
        private static readonly Random Rnd = new Random();

        static Listas()
        {
            InicializaListas();
            VinculosAleatorios();
            //PrintChaves();
        }

        private static void InicializaListas()
        {
            Universidades = new BindingList<INomeavel>
            {
                new Universidade("** TODOS **"),
                new Universidade("UNIVEM"),
                new Universidade("UNIMAR"),
                new Universidade("UNESP"),
                new Universidade("UNICAMP"),
                new Universidade("USP"),
                new Universidade("PUC"),
                new Universidade("MACKENZIE"),
                new Universidade("ITA"),
                new Universidade("UFMG"),
                new Universidade("UFRJ"),
                new Universidade("UFSCAR"),
                new Universidade("UNIFEI")
            };

            Departamentos = new BindingList<INomeavel>
            {
                new Departamento("** TODOS **"),
                new Departamento("Administração"),
                new Departamento("Ciência da Computação"),
                new Departamento("Ciências Contábeis"),
                new Departamento("Design de Interiores"),
                new Departamento("Design Gráfico"),
                new Departamento("Direito"),
                new Departamento("Engenharia de Produção"),
                new Departamento("Gestão de Recursos Humanos"),
                new Departamento("Processos Gerenciais"),
                new Departamento("Sistemas de Informação")
            };

            Professores = new BindingList<INomeavel>
            {
                new Professor("** TODOS **"),
                new Professor("Carlos"),
                new Professor("Diego"),
                new Professor("Laura"),
                new Professor("Pedro"),
                new Professor("Bernardo"),
                new Professor("Manuela"),
                new Professor("Gabriel"),
                new Professor("Lucas"),
                new Professor("Helena"),
                new Professor("Matheus"),
                new Professor("Rafael"),
                new Professor("Beatriz"),
                new Professor("Guilherme"),
                new Professor("Mariana"),
                new Professor("Felipe"),
                new Professor("Gustavo"),
                new Professor("Henrique"),
                new Professor("Rafaela"),
                new Professor("Daniel"),
                new Professor("Murilo"),
                new Professor("Vitor")
            };

            UniDepList = new HashSet<UniDep>
            {
                new UniDep(new Tuple<int, int>(0, 0))
            };

            UniDepProList = new HashSet<UniDepPro>
            {
                new UniDepPro(new Tuple<UniDep, int>(UniDepList.First(), 0))
            };
        }

        /* Popula as listas de classes de relacionamentos (UniDepList e UniDepProList) aleatoriamente */
        private static void VinculosAleatorios()
        {
            for (var i = 1; i < Universidades.Count; i++)
            {
                for (var j = 0; j < Rnd.Next(1, Departamentos.Count); j++)
                {
                    var chaves = new Tuple<int, int>(Universidades[i].Codigo, Rnd.Next(1, Departamentos.Count));
                    UniDepList.Add(new UniDep(chaves));
                }
            }

            for (var i = 1; i < UniDepList.Count; i++)
            {
                for (var j = 0; j < Rnd.Next(1, Professores.Count); j++)
                {
                    var chaves = new Tuple<UniDep, int>(UniDepList.ToList()[i], Rnd.Next(1, Professores.Count));
                    UniDepProList.Add(new UniDepPro(chaves));
                }
            }
        }

        /* Debug */
        private static void PrintChaves()
        {
            foreach (var x in UniDepList)
            {
                Console.WriteLine(x.Chaves);
            }

            foreach (var x in UniDepProList)
            {
                Console.WriteLine(x.Chaves.Item1.Chaves + " " + x.Chaves.Item2);
            }
        }
    }
}
