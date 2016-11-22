using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using UnitTestProjectAcademia;
using Academia;


namespace UnitTestProjectAcademia
{
    [TestClass]
    public class UnitTest1
    {
        /*O metodo TestIMC() é um metodo de teste que verifica se o metodo de calculo do IMC está correto.
         * 22 é um valor conhecido de IMC para quando a altura é 1,75 metros e o peso é 67,36 kg.
         * O Teste consiste em criar um objeto do tipo Cliente e lhe atribuir os valores de altura e peso, 
         * que conhecidamente retornariam 22 de IMC. 
         * Em seguida aplica-se o metodo Assert.AreEqual() que compara se um ou mais 
         * valores de entradas em um metodo, retorna o valor conhecido, nesse caso 22.
         */ 
        [TestMethod]
        public void TestIMC()
        {
            Cliente auxcli = new Cliente();
            auxcli.setAltura(1.75);
            auxcli.setPeso(67.36);
            Assert.AreEqual(auxcli.IMCcalc(auxcli.getAltura(),auxcli.getPeso()), 22);
        }

        /*O metodo TestMassa() é um metodo de teste que verifica se o metodo de calculo do Percentual de Gordura Corporal está correto.
         * 27,1 é um valor conhecido de Percentual de Gordura Corporal para quando o IMC é 22, a idade 27 e o sexo da pessoa é feminino (o inteiro 1 no nosso projeto).
         * O Teste consiste em criar um objeto do tipo Cliente e lhe atribuir os valores de IMC, Idade e Sexo, 
         * que conhecidamente retornariam 27,21 de Percentual de Gordura Corporal. 
         * Em seguida aplica-se o metodo Assert.AreEqual() que compara se um ou mais 
         * valores de entradas em um metodo, retorna o valor conhecido, nesse caso 27,21.
         */ 

        [TestMethod]
        public void TestMassa()
        {
            Cliente auxcli = new Cliente();
            auxcli.setImc(22);
            auxcli.setIdade(27);
            auxcli.setGenero(1);
            Assert.AreEqual(auxcli.MassaGordaCalc(auxcli.getImc(), auxcli.getIdade(), auxcli.getGenero()), 27.21);
        }

        /*O metodo TestIdade() é um metodo de teste que verifica se o metodo de calculo do Idade da pessoa está está correto.
         * O metodo recebe uma data com dia, mes e ano e calcula a idade da pessoa e atribui o valor inteiro ao atributo idade.
        * 27 é um valor conhecido de Idade para quando a data de nascimento da pessoa é 01/01/1989.
        * O Teste consiste em criar um objeto do tipo Cliente e lhe atribuir os valores de de data (01/01/1989), 
        * que conhecidamente retornariam 27 anos de Idade. 
        * Em seguida aplica-se o metodo Assert.AreEqual() que compara se um ou mais 
        * valores de entradas em um metodo, retorna o valor conhecido, nesse caso 27.
        */ 

        [TestMethod]
        public void TestIdade()
        {
            Cliente auxcli = new Cliente();
            DateTime dtidade = new DateTime(1989, 1, 1);
            auxcli.calcIdade(dtidade);

            Assert.AreEqual(auxcli.getIdade(), 27);
            
        }
    }
}