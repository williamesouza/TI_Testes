using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class Cliente
    {
        //Atributos de Cliente
        protected int matricula;
        protected string nome;
        protected int idade;
        protected DateTime dataNasc;
        protected string sexo;
        protected int genero;
        protected double peso;
        protected double altura;
        protected string endereco;
        protected string telefone;
        protected string observacao;

        protected double imc;
        protected double massaGorda;
        //private AvaliacaoFisica af;

        //Inicio metodos construtores
        public Cliente( int matr, string nom, int idad, string sex, int gen, double pes, double alt, string end, string tel, string obs)//Construtor que recebe valores para todos os atributos
        {
            this.matricula = matr;
            this.nome = nom;
            this.idade = idad;
            this.sexo = sex;
            this.genero = gen;
            this.peso = pes;
            this.altura = alt;
            this.endereco = end;
            this.telefone = tel;
            this.observacao = obs;

            //af = new AvaliacaoFisica(); 
        }

        public Cliente()//construtor que atribui valores nulos
        {
            this.matricula = 0;
            this.nome = "";
            this.idade = 0;
            this.sexo = "";
            this.genero = 0;
            this.peso = 0.0;
            this.altura = 0.0;
            this.endereco = "";
            this.telefone = "";
            this.observacao = "";
        }

        //Fim metodos construtores

        //Inicio gets e sets
        public int getMatricula()
        {
            return this.matricula;
        }

        public void setMatricula(int matr)
        {
            this.matricula = matr;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nom)
        {
            this.nome = nom;
        }

        public DateTime getDataNasc()
        {
            return this.dataNasc;
        }

        public void setDataNasc(DateTime dtNasc)
        {
            this.dataNasc = dtNasc;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idad)
        {
            this.idade = idad;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public void setSexo(string sex)
        {
            this.sexo = sex;
        }

        public int getGenero()
        {
            return this.genero;
        }

        public void setGenero(int gen)
        {
            this.genero = gen;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public void setPeso(double pes)
        {
            this.peso = pes;
        }

        public double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double alt)
        {
            this.altura = alt;
        }

        public string getEndereco()
        {
            return this.endereco;
        }

        public void setEndereco(string end)
        {
            this.endereco = end;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setTelefone(string tel)
        {
            this.telefone = tel;
        }

        public string getObservacao()
        {
            return this.observacao;
        }

        public void setObservacao(string obs)
        {
            this.observacao = obs;
        }
        //Fim gets e sets

        //Inicio metodos funcionais

        public double calcIMC(int matrc) //IMC = peso/(altura*altura)
        {
            this.imc = this.peso / (this.altura * this.altura);
            this.imc = Math.Round(this.imc, 2);

            return this.imc;
        }

        public double calcMassaGorda(int matric, int genero) //Percentual de gordura corporal = (1,20 *IMC) + (o,23 * Idade) - (10,8 * sexo [1 mulher, 2 homem]) - 5,4
        {
            if (genero == 1)//Mulher
            {
                this.massaGorda = 1.20 * this.imc + 0.23 * this.idade - 10.8 * 0 - 5.4;
            }

            if (genero == 2) //Homem
            { this.massaGorda = 1.20 * this.imc + 0.23 * this.idade - 10.8 * 1 - 5.4; }

            this.massaGorda = Math.Round(this.massaGorda, 2);

            return this.massaGorda;
        }

        public int calcIdade(DateTime dtNasc)//recebe uma data com dia, mes, ano ecalcula a idade.
        {
            int atualIdade = DateTime.Now.Year - dtNasc.Year;

            // Se a data de aniversário nao ocorreu ainda este ano, subtrair um ano a partir da idade
            if (DateTime.Now.Month < dtNasc.Month || (DateTime.Now.Month == dtNasc.Month && DateTime.Now.Day < dtNasc.Day))
            {
                atualIdade -= 1;
            }
            this.idade = atualIdade;
            return this.idade;
        }

        /*Criar metodos:
         * alterar cliente
         * excluir cliente
         * pesquisar cliente
        */ 

        //Fim metodos funcionais
    }
}
