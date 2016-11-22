using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        static List<Cliente> listClientes;
        static List<AvaliacaoFisica> listAvalFisica;
        static int idincremCliente = 1;

        public Form1()
        {
            listClientes = new List<Cliente>(); //inicaliza a lista de Clientes
            listAvalFisica = new List<AvaliacaoFisica>(); //inicaliza a lista de AvaliacaoFisica
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Cliente auxCli = new Cliente();


            auxCli.setNome(textB_NomeCliente.Text);

            //Inicio controle de dominio das entradas digitadas
            int rIdade;
            int rGen;
            double rPeso;
            double rAltura;
            bool bIdade = int.TryParse(textB_Idade.Text, out rIdade);
            bool bGenero = int.TryParse(textB_Genero.Text, out rGen);
            bool bPeso = double.TryParse(textB_Peso.Text, out rPeso);
            bool bAltura = double.TryParse(textB_Altura.Text, out rAltura);

            if ((bIdade) && (bGenero) && (bPeso) && (bAltura))
            {
                if ((Convert.ToInt32(textB_Genero.Text) > 0) && (Convert.ToInt32(textB_Genero.Text) < 3))
                {
                    auxCli.setGenero(Convert.ToInt32(textB_Genero.Text));
                    auxCli.setMatricula(idincremCliente);
                    auxCli.setAltura(Convert.ToDouble(textB_Altura.Text));
                    auxCli.setIdade(Convert.ToInt32(textB_Idade.Text));
                    auxCli.setPeso(Convert.ToDouble(textB_Peso.Text));
                    auxCli.setEndereco(richTextBox_Endereco.Text);
                    auxCli.setMatricula(idincremCliente);
                    lbl_NumMatric.Text = Convert.ToString(idincremCliente);
                    auxCli.setSexo(textB_Sexo.Text);
                    auxCli.setTelefone(textB_Telefone.Text);
                    auxCli.setObservacao(richTextBox_Obs.Text);

                    listClientes.Add(auxCli);
                    listBox_ListaClientes.Items.Add(auxCli.getNome() + " | \t" + auxCli.getMatricula() + "\t | " + auxCli.getIdade() + "\t | " + auxCli.getPeso() + "\t | " + auxCli.getAltura() + "\t | " + auxCli.getGenero());
                }
                else
                {
                    MessageBox.Show("Insira um valor válido para o Genero: " + "\nDeve ser 1 para mulher; ou."
                        + "\n 2 para Homem");
                    
                }
                //Fim controle de dominio das entradas digitadas

                
            }
            
            lbl_NumMatric.Text = Convert.ToString(idincremCliente);
            
            idincremCliente += 1;
            lbl_NumClientes.Text = listClientes.Count.ToString();

            //Inicio Limpa campos apos salvo
            textB_NomeCliente.Clear();
            textB_Genero.Clear();
            textB_Altura.Clear();
            textB_Idade.Clear();
            textB_Peso.Clear();
            richTextBox_Endereco.Clear();
            lbl_NumMatric.Text = "";
            textB_Sexo.Clear();
            textB_Telefone.Clear();
            richTextBox_Obs.Clear();
            //Fim Limpa campos apos salvo
            
        }

        private void btn_CalcIMC_Click(object sender, EventArgs e)//calcula IMC e Massa Gorda
        {
            int mat = int.Parse(textBox_MatricCliente.Text);
            double resultIMC = 0;
            double resultMassaG = 0;

            foreach (Cliente auxCli in listClientes)//Calcula IMC
            {
                int mTemp = auxCli.getMatricula();

                if (mTemp == mat)
                { 
                    resultIMC = auxCli.calcIMC(mat);
                    resultMassaG = auxCli.calcMassaGorda(mat, auxCli.getGenero()); 
                    lbl_NomeResult.Text = auxCli.getNome();
                }
            }
            lbl_ResultImc.Text = Convert.ToString(resultIMC);

            //foreach (Cliente auxCli in listClientes)//Calcula Massa Gorda
            //{
            //    int mTemp = auxCli.getMatricula();

            //    if (mTemp == mat)
            //    { resultMassaG = auxCli.calcMassaGorda(mat, auxCli.getGenero()); }
            //    lbl_NomeResult.Text = auxCli.getNome();
            //}
            lbl_ResultMassaGorda.Text = Convert.ToString(resultMassaG);

            
        }

        private void lbl_ResultIMC_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_LimparTudoClientes_Click(object sender, EventArgs e)
        {//Limpa campos
            textB_NomeCliente.Clear();
            textB_Genero.Clear();
            textB_Altura.Clear();
            textB_Idade.Clear();
            textB_Peso.Clear();
            richTextBox_Endereco.Clear();
            lbl_NumMatric.Text = "";
            textB_Sexo.Clear();
            textB_Telefone.Clear();
            richTextBox_Obs.Clear();
        }
    }
}
