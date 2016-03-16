using System;

namespace Estoque
{
    public class Produto
    {
        public static int Cont { get; private set; }
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }
        public int EstoqueAtual { get; private set; }
        public int EstoqueMinimo { get; private set; }
        public bool PrecisaReposicao { get; private set; }
        public DateTime DataAlteracao { get; private set; }

        public Produto(string descricao, double preco = 0, int atual = 0, int minimo = 0)
        {
            try {
                Produto.Cont++;
                Codigo = Produto.Cont;
                SetDescricao(descricao);
                SetPreco(preco);
                SetEstoqueAtual(atual);
                SetEstoqueMinimo(minimo);
                PrecisaReposicao = minimo > atual;
                DataAlteracao = DateTime.Now;
            }
            catch (Exception ex)
            {
                Produto.Cont--;
                throw new Exception(ex.Message);
            }
        }

        public bool SetDescricao(string descricao)
        {
            if (descricao.Equals(""))
            {
                throw new Exception("O campo Descrição não pode ser vazio.");
            }

            Descricao = descricao;
            SetDataAlteracao();

            return true;
        }

        public bool SetPreco(double preco)
        {
            if (preco < 0)
            {
                throw new Exception("Nâo é possível definir um valor negativo para o Preço.");
            }

            Preco = preco;
            SetDataAlteracao();

            return true;
        }

        public bool Inserir(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("O valor informado é inválido.");
            }

            SetEstoqueAtual(EstoqueAtual + qtd);

            return true;
        }

        public bool Retirar(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("O valor informado é inválido.");
            }

            if (qtd > EstoqueAtual)
            {
                throw new Exception("Estoque insuficiente para a operação solicitada.");
            }

            SetEstoqueAtual(EstoqueAtual - qtd);

            return true;
        }

        public void SetEstoqueAtual(int qtd)
        {
            EstoqueAtual = qtd;
            SetPrecisaReposicao();
            SetDataAlteracao();
        }

        public bool SetEstoqueMinimo(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("Nâo é possível definir um valor negativo para o Estoque Mínimo.");
            }

            EstoqueMinimo = qtd;
            SetPrecisaReposicao();
            SetDataAlteracao();

            return true;
        }

        private void SetPrecisaReposicao()
        {
            PrecisaReposicao = EstoqueMinimo > EstoqueAtual;
        }

        private void SetDataAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
