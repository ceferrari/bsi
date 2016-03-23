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
        public static SortedSet<UniDep> UniDepList { get; private set; }
        public static SortedSet<UniDepPro> UniDepProList { get; private set; }
        private static Random Rnd = new Random();

        static Listas()
        {
            InicializaListas();
            VinculosAleatorios();
            //PrintChaves();
        }

        private static void InicializaListas()
        {
            Universidades = new BindingList<INomeavel>();
            Universidades.Add(new Universidade("** TODOS **"));
            Universidades.Add(new Universidade("UNIVEM"));
            Universidades.Add(new Universidade("UNIMAR"));
            Universidades.Add(new Universidade("UNESP"));
            Universidades.Add(new Universidade("UNICAMP"));
            Universidades.Add(new Universidade("USP"));
            Universidades.Add(new Universidade("PUC"));
            Universidades.Add(new Universidade("MACKENZIE"));
            Universidades.Add(new Universidade("ITA"));
            Universidades.Add(new Universidade("UFMG"));
            Universidades.Add(new Universidade("UFRJ"));
            Universidades.Add(new Universidade("UFSCAR"));
            Universidades.Add(new Universidade("UNIFEI"));

            Departamentos = new BindingList<INomeavel>();
            Departamentos.Add(new Departamento("** TODOS **"));
            Departamentos.Add(new Departamento("Administração"));
            Departamentos.Add(new Departamento("Ciência da Computação"));
            Departamentos.Add(new Departamento("Ciências Contábeis"));
            Departamentos.Add(new Departamento("Design de Interiores"));
            Departamentos.Add(new Departamento("Design Gráfico"));
            Departamentos.Add(new Departamento("Direito"));
            Departamentos.Add(new Departamento("Engenharia de Produção"));
            Departamentos.Add(new Departamento("Gestão de Recursos Humanos"));
            Departamentos.Add(new Departamento("Processos Gerenciais"));
            Departamentos.Add(new Departamento("Sistemas de Informação"));

            Professores = new BindingList<INomeavel>();
            Professores.Add(new Professor("** TODOS **"));
            Professores.Add(new Professor("Carlos"));
            Professores.Add(new Professor("Diego"));
            Professores.Add(new Professor("Laura"));
            Professores.Add(new Professor("Pedro"));
            Professores.Add(new Professor("Bernardo"));
            Professores.Add(new Professor("Manuela"));
            Professores.Add(new Professor("Gabriel"));
            Professores.Add(new Professor("Lucas"));
            Professores.Add(new Professor("Helena"));
            Professores.Add(new Professor("Matheus"));
            Professores.Add(new Professor("Rafael"));
            Professores.Add(new Professor("Beatriz"));
            Professores.Add(new Professor("Guilherme"));
            Professores.Add(new Professor("Mariana"));
            Professores.Add(new Professor("Felipe"));
            Professores.Add(new Professor("Gustavo"));
            Professores.Add(new Professor("Henrique"));
            Professores.Add(new Professor("Rafaela"));
            Professores.Add(new Professor("Daniel"));
            Professores.Add(new Professor("Murilo"));
            Professores.Add(new Professor("Vitor"));

            UniDepList = new SortedSet<UniDep>();
            UniDepList.Add(new UniDep(new Tuple<int, int>(0, 0)));

            UniDepProList = new SortedSet<UniDepPro>();
            UniDepProList.Add(new UniDepPro(new Tuple<UniDep, int>(UniDepList.First(), 0)));
        }

        /* Popula as listas de classes de relacionamentos (UniDepList e UniDepProList) aleatoriamente */
        private static void VinculosAleatorios()
        {
            for (int i = 1; i < Universidades.Count; i++)
            {
                for (int j = 0; j < Rnd.Next(1, Departamentos.Count); j++)
                {
                    Tuple<int, int> chaves = new Tuple<int, int>(Universidades[i].Codigo, Rnd.Next(1, Departamentos.Count));
                    UniDepList.Add(new UniDep(chaves));
                }
            }

            for (int i = 1; i < UniDepList.Count; i++)
            {
                for (int j = 0; j < Rnd.Next(1, Professores.Count); j++)
                {
                    Tuple<UniDep, int> chaves = new Tuple<UniDep, int>(UniDepList.ToList()[i], Rnd.Next(1, Professores.Count));
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
