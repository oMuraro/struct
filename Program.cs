using System;
using Struct;

namespace tad{
    class Program{
        static void Main(string[] args){
            ClienteS cliente1 = new();
            cliente1.nome = "Luke";
            cliente1.cpf = "1928581928";
            cliente1.dataNascimento = "01/01/2001";
            cliente1.email = "exemplo@gmail.com";

            Console.WriteLine(cliente1.imprimir());
        }
    }
}