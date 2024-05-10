using System.Reflection.Metadata.Ecma335;

namespace Struct;
public struct JogadorS{
public string nome;
    public string posicao;
    public double peso;
    public double altura;
    public string clube;
    public int qntAmarelo;
    public int qntVermelho;

    public JogadorS(string nome, string posicao, double peso, double altura, int qntAmarelo, int qntVermelho, string clube){
        this.nome = nome;
        this.posicao = posicao;
        this.peso = peso;
        this.altura = altura;
        this.clube = clube;
        this.qntAmarelo = qntAmarelo;
        this.qntVermelho = qntVermelho;
    }

    public void registrarNumeroCartoesAmarelos(int qnt){
        this.qntAmarelo = qntAmarelo + qnt;
    }

    public void registrarNumeroCartoesVermelhos(int qnt){
        this.qntAmarelo = qntAmarelo + qnt;
    }

    public string verificarVinculoClube(){
        return "Clube: " + this.clube;
    }

    public string imprimir(){
        return "\nNome: " + this.nome + 
        "\nPosição: " + this.posicao + 
        "\nPeso: " + this.peso + 
        "\nAltura: " + this.altura + 
        "\nClube: " + this.clube + 
        "\nCartões Amarelo: " + this.qntAmarelo + 
        "\nCartões Vermelhos: " + this.qntVermelho;
    }
}
