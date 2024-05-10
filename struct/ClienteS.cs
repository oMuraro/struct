using System.Reflection.Metadata.Ecma335;

namespace Struct;

public struct ClienteS{
    //Dados da Struct
    public string nome;
    public string cpf;
    public string dataNascimento;
    public string email;

    //Operações da Struct
    public ClienteS(string nome, string cpf, string dataNascimento, string email){
        this.nome = nome;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.email = email;
    }

    public string imprimir(){
        return "\nNome: " + this.nome + "\nCPF: " + this.cpf + "\nData de Nascimento: " + dataNascimento + "\nEmail: " + email;
    }
}