namespace Struct{
    public struct EquipeEsports{
        public string nome;
        public int qntJogadores;
        public int qntCampVencidos;
        public double valorGanho;
        public int anoEstreia;

        public EquipeEsports(string nome, int qntJogadores, int qntCampVencidos, double valorGanho, int anoEstreia){
        this.nome = nome;
        this.qntJogadores = qntJogadores;
        this.qntCampVencidos = qntCampVencidos;
        this.valorGanho = valorGanho;
        this.anoEstreia = anoEstreia;
    }

    public void registrarCampeonatoVencido(double valorPremio){
        this.qntCampVencidos = this.qntCampVencidos + 1;
        atualizarValorTotalPremiacoes(valorPremio);
    }

    public void atualizarValorTotalPremiacoes(double valor){
        this.valorGanho = this.valorGanho + valor;
    }

    public string verificarAnoEstreia(){
        DateTime year = DateTime.Now;
        if(this.anoEstreia == year.Year){
            return "Novata";
        } else {
            return "Veterana";
        }
    }

    public string imprimir(){
        return "\nNome: " + this.nome + 
        "\nQuantidade de Jogadores: " + this.qntJogadores + 
        "\nQuantidade de Campeonatos Vencidos: " + this.qntCampVencidos + 
        "\nValor Ganho: " + this.valorGanho + 
        "\nAno de Estréia: " + this.anoEstreia;
    }
    }
}