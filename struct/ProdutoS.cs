namespace Struct{
    public struct ProdutoS{
        public string nome;
        public double preco;
        public int estoque;

        public ProdutoS(string nome, double preco, int estoque){
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoque;
        }

        public double aplicarCupomDescontoValor(double desconto){
            return this.preco - desconto;
        }

        public double aplicarCupomDescontoPorcentagem(double porcentagem){
            return this.preco - (this.preco * porcentagem)/100;
        }

        public int verificarQuantidadeEmEstoque(){
            return this.estoque;
        }

        public string imprimir(){
            return "\nNome: " + this.nome + 
            "\nPreço: " + this.preco + 
            "\nQuantidade em Estoque: " + this.estoque;
        }
    }
}