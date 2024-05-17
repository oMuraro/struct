using System;
using Struct;

namespace tad{
    class Program{
        static void Main(string[] args){
            // ClienteS cliente1 = new();
            // cliente1.nome = "Luke";
            // cliente1.cpf = "1928581928";
            // cliente1.dataNascimento = "01/01/2001";
            // cliente1.email = "exemplo@gmail.com";

            // Console.WriteLine(cliente1.imprimir());

            EquipeEsports equipe1 = new();
            equipe1.nome = "Giants";
            equipe1.qntJogadores = 8;
            equipe1.qntCampVencidos = 3;
            equipe1.valorGanho = 20000;
            equipe1.anoEstreia = 2023;

            equipe1.registrarCampeonatoVencido(2000);
            equipe1.atualizarValorTotalPremiacoes(1500);
            Console.WriteLine(equipe1.verificarAnoEstreia());

            Console.WriteLine(equipe1.imprimir());
        }
    }
}