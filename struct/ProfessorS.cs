namespace Struct{
    public struct ProfessorS{
        public string nome;
        public double salario;
        public int cargaHoraria;
        public int faltas;

        public ProfessorS(string nome, double salario, int faltas, int cargaHoraria){
            this.nome = nome;
            this.salario = salario;
            this.cargaHoraria = cargaHoraria;
            this.faltas = faltas;
        }

        public void reajusteSalarialEmValor(double valor){
            this.salario = this.salario + valor;
        }

        public void reajusteSalarialEmPorcentagem(int porcentagem){
            this.salario = this.salario + (this.salario * porcentagem)/100;
        }

        public void descontoSalarialPorFaltaEmValor(double valorPorFalta){
            for(int i = 0; i < this.faltas; i++){
            this.salario = this.salario - valorPorFalta;
            }
        }

        public void descontoSalarialPorFaltaEmPorcentagem(int porcentagem){
            double descontoTotal = (this.salario * porcentagem)/100;
            for(int i = 0; i < this.faltas; i++){
                this.salario = this.salario - descontoTotal;
            }
        }

        public void aumentarCargaHorariaDeTrabalho(int aumento, double valor){
            this.cargaHoraria = this.cargaHoraria + aumento;
            reajusteSalarialEmValor(valor);
        }

        public string imprimir(){
            return "\nNome: " + this.nome + 
            "\nSalario: " + this.salario + 
            "\nCarga Horária: " + this.cargaHoraria;
        }
    }
}