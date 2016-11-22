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
        static List<Cliente> listClientes; //Lista que armazena os Objetos Clientes
        static List<AvaliacaoFisica> listAvalFisica; ////Lista que armazena os Objetos AvaliacaoFisica
        static int idincremCliente = 1; // Variavel int que incrementa automaticamente o numero de matricula

        public Form1()
        {
            listClientes = new List<Cliente>(); //inicaliza a lista de Clientes
            listAvalFisica = new List<AvaliacaoFisica>(); //inicaliza a lista de AvaliacaoFisica
            InitializeComponent();
        }

        public void cadastrarCliente()//Metodo que salva, insere os Clientes na lista
        {
            int recebeIdade;
            Cliente auxCli = new Cliente();//Objeto Cliente auxiliar para receber dados inseridos no formulario de cadastro e salva-los na lista de Cliente

            auxCli.setNome(textB_NomeCliente.Text); //recebe o Nome do cliente e atribui o ao Cliente

            //Inicio controle de dominio das entradas digitadas, pra evitar que se ponha, por exemplo uma string onde deve ser um int
            //int rIdade;
            int rGen;
            double rPeso;
            double rAltura;
            //bool bIdade = int.TryParse(textB_Idade.Text, out rIdade);
            bool bGenero = int.TryParse(textB_Genero.Text, out rGen);
            bool bPeso = double.TryParse(textB_Peso.Text, out rPeso);
            bool bAltura = double.TryParse(textB_Altura.Text, out rAltura);

            if ((bGenero) && (bPeso) && (bAltura))//if que confirma se o dominio das entradas estao corretos
            {
                if ((Convert.ToInt32(textB_Genero.Text) > 0) && (Convert.ToInt32(textB_Genero.Text) < 3))//if que limita a entrada genero a 1 ou 2
                {
                    auxCli.setGenero(Convert.ToInt32(textB_Genero.Text));//recebe o Genero do cliente e atribui o ao Cliente
                    auxCli.setMatricula(idincremCliente);//recebe a Matricula do cliente e atribui o ao Cliente. Eh inserida e incrementada automaticamente
                    auxCli.setAltura(Convert.ToDouble(textB_Altura.Text));//recebe a Altura do cliente e atribui o ao Cliente

                    //Inicio calcula idade
                    recebeIdade = auxCli.calcIdade(Convert.ToDateTime(maskedTB_DtNasc.Text));

                    //Fim calcula Idade
                    auxCli.setIdade(recebeIdade);//recebe a Idade do cliente e atribui o ao Cliente

                    auxCli.setPeso(Convert.ToDouble(textB_Peso.Text));//recebe o Peso do cliente e atribui o ao Cliente
                    auxCli.setEndereco(richTextBox_Endereco.Text); //recebe o Endereço do cliente e atribui o ao Cliente
                    lbl_NumMatric.Text = Convert.ToString(idincremCliente);//recebe e exibe numa Label o numero de Matricula do cliente
                    //auxCli.setSexo(textB_Sexo.Text);//recebe o Sexo do cliente e atribui o ao Cliente
                    auxCli.setTelefone(textB_Telefone.Text);//recebe o Telefone do cliente e atribui o ao Cliente
                    auxCli.setObservacao(richTextBox_Obs.Text);//recebe a Observacao sobre o cliente e atribui o ao Cliente

                    listClientes.Add(auxCli); //Adiciona o Objeto Cliente na Lista, com todos pos dados inseridos no formulario, quando o usuario pressiona o Botao Salvar

                    //Exibe todos os Clientes cadastrados na listBox ao lado
                    listBox_ListaClientes.Items.Add(auxCli.getNome() + " | \t" + auxCli.getMatricula() + "\t | " + auxCli.getIdade() + "\t | " + auxCli.getPeso() + "\t | " + auxCli.getAltura() + "\t | " + auxCli.getGenero());
                }
                else
                {//Exibe mensagem alertando para inserir valor valido para genero (1 para mulher, e 2 para homem
                    MessageBox.Show("Insira um valor válido para o Genero: " + "\nDeve ser 1 para mulher; ou."
                        + "\n 2 para Homem");

                }
                //Fim controle de dominio das entradas digitadas


            }

            lbl_NumMatric.Text = Convert.ToString(idincremCliente);// recebe e exibe o numero de Matricula numa Label

            idincremCliente += 1; //incrementa o numero de Matricula
            lbl_NumClientes.Text = listClientes.Count.ToString();//exibe a quantidade de Clientes numa Label

            //Inicio Limpa campos apos salvo
            textB_NomeCliente.Clear();
            textB_Genero.Clear();
            textB_Altura.Clear();
            maskedTB_DtNasc.Clear();
            textB_Peso.Clear();
            richTextBox_Endereco.Clear();
            lbl_NumMatric.Text = "";
            //textB_Sexo.Clear();
            textB_Telefone.Clear();
            richTextBox_Obs.Clear();
            //Fim Limpa campos apos salvo
        }

        public void calculaImcMassaGorda()//Metodo que calcula o IMC e o indice de gordura corporal
        {
            int mat = int.Parse(textBox_MatricCliente.Text);//recebe o numero de Matricula inserido no campo Matricula do Cliente na aba Avaliacao
            double resultIMC = 0;
            double resultMassaG = 0;

            foreach (Cliente auxCli in listClientes)//Calcula IMC // Percorre toda a lista de clientes procurando uma matricula que corresponda aquela digitada pelo 
            {                                       //usuario no campo Matricula do Cliente na aba Avaliacao
                int mTemp = auxCli.getMatricula();//Recebe cada matricula contida na lista dos varios Clientes contidos na lista

                if (mTemp == mat)//compara se a matricula inserida eh igual a alguma existente, se for calcula e exibe o IMC e o Indce de Massa Gorda
                {
                    resultIMC = auxCli.calcIMC(mat);
                    resultMassaG = auxCli.calcMassaGorda(mat, auxCli.getGenero());
                    lbl_NomeResult.Text = auxCli.getNome();
                }
            }
            lbl_ResultImc.Text = Convert.ToString(resultIMC);//exibe o IMC em uma Label

            lbl_ResultMassaGorda.Text = Convert.ToString(resultMassaG);//exibe o Indice de Massa Gorda em uma Label

        }

        private void btn_Salvar_Click(object sender, EventArgs e)//Botao que chama o metodo de cadastrar, inserir Cliente na lista
        {

            cadastrarCliente();
            
        }

        private void btn_CalcIMC_Click(object sender, EventArgs e)//Botao que chama o metodo que calcula IMC e Massa Gorda
        {
            calculaImcMassaGorda();
            
        }

        public void resultImcMassaGorda()//Metodo que exibe na tela o resultado do IMC e do indice de gordura corporal
        {
            int mat = int.Parse(textBox_MatricCliente.Text);//recebe o numero de Matricula inserido no campo Matricula do Cliente na aba Avaliacao
            double resultIMC = 0;
            double resultMassaG = 0;

            foreach (Cliente auxCli in listClientes)//Calcula IMC // Percorre toda a lista de clientes procurando uma matricula que corresponda aquela digitada pelo 
            {                                       //usuario no campo Matricula do Cliente na aba Avaliacao
                int mTemp = auxCli.getMatricula();//Recebe cada matricula contida na lista dos varios Clientes contidos na lista

                if (mTemp == mat)//compara se a matricula inserida eh igual a alguma existente, se for calcula e exibe o IMC e o Indce de Massa Gorda
                {
                    resultIMC = auxCli.calcIMC(mat);
                    resultMassaG = auxCli.calcMassaGorda(mat, auxCli.getGenero());
                    lbl_NomeResult.Text = auxCli.getNome();
                }
            }
            lbl_ResultImc.Text = Convert.ToString(resultIMC);//exibe o IMC em uma Label

            lbl_ResultMassaGorda.Text = Convert.ToString(resultMassaG);//exibe o Indice de Massa Gorda em uma Label
        }

        private void lbl_ResultIMC_Click(object sender, EventArgs e)//Botao que chama o metodo que exibe o resultado do IMC e do Indice de Gordura Corporal
        {

            resultImcMassaGorda();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_LimparTudoClientes_Click(object sender, EventArgs e)//Botao limpa todos os campos da tela de cadastro
        {//Limpa campos
            textB_NomeCliente.Clear();
            textB_Genero.Clear();
            textB_Altura.Clear();
            maskedTB_DtNasc.Clear();
            textB_Peso.Clear();
            richTextBox_Endereco.Clear();
            lbl_NumMatric.Text = "";
            //textB_Sexo.Clear();
            textB_Telefone.Clear();
            richTextBox_Obs.Clear();
        }

        public void exibirClienteDel()//Metodo que exibe Cliente a ser deletado
        {
            int rMatric;

            bool bMatric = int.TryParse(textBox_MatricDel.Text, out rMatric);

            if (bMatric)//if que confirma se o dominio das entradas estao corretos
            {
                int matricTmp = Convert.ToInt32(textBox_MatricDel.Text);//Recebe matricula a ser deletada


                foreach (Cliente auxCli in listClientes)
                {
                    int matTemp = auxCli.getMatricula();
                    if (matTemp == matricTmp)//compara se a matricula inserida eh igual a alguma existente, se for exibe cliente a ser deletado
                    {
                        lbl_ExibeNome.Text = auxCli.getNome();

                        MessageBox.Show("ALERTA: Clicar em deletar é " + "\numa ação irreversivel. " + "\nO Cliente será deletado permanentemente");
                    }
                }
            }

            else
            {//Exibe mensagem alertando para inserir valor valido para genero (1 para mulher, e 2 para homem
                MessageBox.Show("Insira um valor numerico inteiro valido para a matricula ");

            }
            //btn_DelCliente.Enabled();
        }

        private void btn_ExibeCliente_Click(object sender, EventArgs e)//Botao que chama metodo que exibe Cliente a ser deletado
        {
            exibirClienteDel();
        }

        private void textBox_MatricDel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
