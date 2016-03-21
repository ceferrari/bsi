using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Universidade
{
    public static class Listas
    {
        public static BindingList<Universidade> Universidades { get; private set; }
        public static BindingList<Departamento> Departamentos { get; private set; }
        public static BindingList<Professor> Professores { get; private set; }
        public static HashSet<UniDep> UniDepList { get; private set; }
        public static HashSet<UniDepPro> UniDepProList { get; private set; }
        private static Random Rnd = new Random();

        static Listas()
        {
            InicializaListas();
        }

        private static void InicializaListas()
        {
            Universidades = new BindingList<Universidade>();
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

            Departamentos = new BindingList<Departamento>();
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

            Professores = new BindingList<Professor>();
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

            UniDepList = new HashSet<UniDep>();
            UniDepList.Add(new UniDep(new Tuple<int, int>(0, 0)));

            UniDepProList = new HashSet<UniDepPro>();
            UniDepProList.Add(new UniDepPro(new Tuple<int, int>(0, 0)));

            Aleatorios();
        }

        /* Atribui Departamentos e Professores aleatoriamente */
        private static void Aleatorios()
        {
            for (int i = 1; i < Universidades.Count; i++)
            {
                for (int j = 0; j < Rnd.Next(1, Departamentos.Count); j++)
                {
                    Tuple<int, int> chaves = new Tuple<int, int>(Universidades[i].Codigo, Rnd.Next(1, Departamentos.Count));

                    if (!UniDepList.Any(x => x.Chaves.Equals(chaves)))
                    {
                        UniDepList.Add(new UniDep(chaves));
                    }
                }
            }

            for (int i = 1; i < UniDepList.Count; i++)
            {
                for (int j = 0; j < Rnd.Next(1, Professores.Count); j++)
                {
                    Tuple<int, int> chaves = new Tuple<int, int>(UniDepList.ToList()[i].Codigo, Rnd.Next(1, Professores.Count));

                    if (!UniDepProList.Any(x => x.Chaves.Equals(chaves)))
                    {
                        UniDepProList.Add(new UniDepPro(chaves));
                    }
                }
            }
        }

        /* Debug */
        private static void PrintChaves()
        {
            List<UniDep> UniDepAux = UniDepList.ToList();
            for (int i = 0; i < UniDepList.Count; i++)
            {
                Console.WriteLine(UniDepAux[i].Codigo + " " + UniDepAux[i].Chaves.Item1 + " " + UniDepAux[i].Chaves.Item2);
            }

            List<UniDepPro> UniDepProAux = UniDepProList.ToList();
            for (int i = 0; i < UniDepProList.Count; i++)
            {
                Console.WriteLine(UniDepProAux[i].Codigo + " " + UniDepProAux[i].Chaves.Item1 + " " + UniDepProAux[i].Chaves.Item2);
            }
        }
    }
}
