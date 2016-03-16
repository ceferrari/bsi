using System;
using System.Reflection;

namespace Logistica
{
    public abstract class Produto
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }
        private PropertyInfo EstoqueAtual { get; set; }
        private PropertyInfo EstoqueMinimo { get; set; }
        private PropertyInfo PrecisaReposicao { get; set; }
        private PropertyInfo DataAlteracao { get; set; }

        public Produto()
        {
            EstoqueAtual = GetPropertyInfo("EstoqueAtual");
            EstoqueMinimo = GetPropertyInfo("EstoqueMinimo");
            PrecisaReposicao = GetPropertyInfo("PrecisaReposicao");
            DataAlteracao = GetPropertyInfo("DataAlteracao");

            int qtd = GetEstoqueAtual() + 1;
            SetEstoqueAtual(qtd);
            Codigo = qtd;
            Descricao = GetType().Name + " " + qtd;
        }

        public bool Inserir(int qtd)
        {
            if (qtd <= 0)
            {
                throw new Exception("O valor informado é inválido.");
            }

            SetEstoqueAtual(GetEstoqueAtual() + qtd);

            return true;
        }

        public bool Retirar(int qtd)
        {
            if (qtd <= 0)
            {
                throw new Exception("O valor informado é inválido.");
            }

            if (qtd > GetEstoqueAtual())
            {
                throw new Exception("Estoque insuficiente para a operação solicitada.");
            }

            SetEstoqueAtual(GetEstoqueAtual() - qtd);

            return true;
        }

        private PropertyInfo GetPropertyInfo(string property)
        {
            return GetType().UnderlyingSystemType.GetProperty(property);
        }

        public int GetEstoqueAtual()
        {
            return Convert.ToInt32(EstoqueAtual.GetValue(null, null));
        }

        private void SetEstoqueAtual(int qtd)
        {
            EstoqueAtual.SetValue(null, qtd);
            SetPrecisaReposicao();
            SetDataAlteracao();
        }

        public int GetEstoqueMinimo()
        {
            return Convert.ToInt32(EstoqueMinimo.GetValue(null, null));
        }

        public bool SetEstoqueMinimo(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("Nâo é possível definir um valor negativo para o Estoque Mínimo.");
            }

            EstoqueMinimo.SetValue(null, qtd);
            SetPrecisaReposicao();

            return true;
        }

        public bool GetPrecisaReposicao()
        {
            return GetEstoqueAtual() < GetEstoqueMinimo();
        }

        private void SetPrecisaReposicao()
        {
            PrecisaReposicao.SetValue(null, GetPrecisaReposicao());
        }

        public DateTime GetDataAlteracao()
        {
            return Convert.ToDateTime(DataAlteracao.GetValue(null, null));
        }

        private void SetDataAlteracao()
        {
            DataAlteracao.SetValue(null, DateTime.Now);
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
