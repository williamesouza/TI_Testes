using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class AvaliacaoFisica : Cliente
    {
        protected Cliente cliente;
        protected double imcCli;
        protected double massa;
        protected string obsAvaliacao;

        //Inicio construtores
        public AvaliacaoFisica(Cliente cli1)
        {
            this.cliente = cli1;
        }

        public AvaliacaoFisica(Cliente cli1, double indmc, double mass)
        {
            this.cliente = cli1;
            this.imcCli = indmc;
            this.massa = mass;
        }

        public AvaliacaoFisica(Cliente cli1, string obsAval)
        {
            this.cliente = cli1;
            this.obsAvaliacao = obsAval;
        }

        //Fim construtores

        //Inicio gets e sets

        public Cliente getCliente()
        {
            return this.cliente;
        }

        public void setCliente(Cliente cli1)
        {
            this.cliente = cli1;
        }

        public double getImcCli()
        {
            return this.imcCli;
        }

        public void setImcCli(double indmc)
        {
            this.imcCli = indmc;
        }

        public double getMassa()
        {
            return this.massa;
        }

        public void setMassa(double mass)
        {
            this.massa = mass;
        }

        public string getObsAvaliacao()
        {
            return this.obsAvaliacao;
        }

        public void setObsAvaliacao(string obsAval)
        {
            this.obsAvaliacao = obsAval;
        }

       //Fim gets e sets

        //Inicio metodos funcionais

        //public double calcIMC(Cliente cli1) //IMC = peso/(altura*altura)
        //{
        //    this.imc = cli1.getPeso() / (cli1.getAltura() * cli1.getAltura());
        //    this.imc = Math.Round(this.imc, 2);

        //    return this.imc;
        //}

        //public double calcMassaGorda(Cliente cli1, int genero) //Percentual de gordura corporal = (1,20 *IMC) + (o,23 * Idade) - (10,8 * sexo [0 mulher, 1 homem]) - 5,4
        //{
        //    if (genero == 0)//Mulher
        //    {
        //        this.massa = ((1.20 * this.imc) + (0.23 * cli1.getIdade()) - (10.8 * genero) - (5.4));
        //    }

        //    if (genero == 1) //Homem
        //    { this.massa = ((1.20 * this.imc) + (0.23 * cli1.getIdade()) - (10.8 * genero) - (5.4)); }

        //    return this.massa;
        //}
        
        //Fim metodos funcionais

    }
}
