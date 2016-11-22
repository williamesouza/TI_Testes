namespace Academia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maskedTB_DtNasc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DtNasc = new System.Windows.Forms.Label();
            this.btn_LimparTudoClientes = new System.Windows.Forms.Button();
            this.lbl_Rotulos = new System.Windows.Forms.Label();
            this.lbl_CamposObrigatorios = new System.Windows.Forms.Label();
            this.textB_Genero = new System.Windows.Forms.TextBox();
            this.lbl_Gen = new System.Windows.Forms.Label();
            this.lbl_ListaClientes = new System.Windows.Forms.Label();
            this.listBox_ListaClientes = new System.Windows.Forms.ListBox();
            this.lbl_NumClientes = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.richTextBox_Endereco = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Obs = new System.Windows.Forms.RichTextBox();
            this.lbl_NumMatric = new System.Windows.Forms.Label();
            this.textB_Telefone = new System.Windows.Forms.TextBox();
            this.textB_Altura = new System.Windows.Forms.TextBox();
            this.textB_Peso = new System.Windows.Forms.TextBox();
            this.textB_NomeCliente = new System.Windows.Forms.TextBox();
            this.lbl_Obs = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Peso = new System.Windows.Forms.Label();
            this.lbl_Matricula = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_NomeResult = new System.Windows.Forms.Label();
            this.lbl_ResultMassaGorda = new System.Windows.Forms.Label();
            this.lbl_ResultImc = new System.Windows.Forms.Label();
            this.lbl_MassaGorda = new System.Windows.Forms.Label();
            this.lbl_IMC = new System.Windows.Forms.Label();
            this.btn_CalcIMC = new System.Windows.Forms.Button();
            this.textBox_MatricCliente = new System.Windows.Forms.TextBox();
            this.lbl_MatricCliente = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_ExibeCliente = new System.Windows.Forms.Button();
            this.lbl_AlertaDel = new System.Windows.Forms.Label();
            this.btn_DelCliente = new System.Windows.Forms.Button();
            this.textBox_MatricDel = new System.Windows.Forms.TextBox();
            this.lbl_ExibeNome = new System.Windows.Forms.Label();
            this.lbl_NomeDel = new System.Windows.Forms.Label();
            this.lbl_MatricDel = new System.Windows.Forms.Label();
            this.lbl_DeletarCliente = new System.Windows.Forms.Label();
            this.btn_PesquisarCli = new System.Windows.Forms.Button();
            this.lbl_PesquisarCli = new System.Windows.Forms.Label();
            this.lbl_MatricPesq = new System.Windows.Forms.Label();
            this.textB_MatricPesq = new System.Windows.Forms.TextBox();
            this.listBox_PesqCli = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1128, 344);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.maskedTB_DtNasc);
            this.tabPage1.Controls.Add(this.lbl_DtNasc);
            this.tabPage1.Controls.Add(this.btn_LimparTudoClientes);
            this.tabPage1.Controls.Add(this.lbl_Rotulos);
            this.tabPage1.Controls.Add(this.lbl_CamposObrigatorios);
            this.tabPage1.Controls.Add(this.textB_Genero);
            this.tabPage1.Controls.Add(this.lbl_Gen);
            this.tabPage1.Controls.Add(this.lbl_ListaClientes);
            this.tabPage1.Controls.Add(this.listBox_ListaClientes);
            this.tabPage1.Controls.Add(this.lbl_NumClientes);
            this.tabPage1.Controls.Add(this.btn_Salvar);
            this.tabPage1.Controls.Add(this.richTextBox_Endereco);
            this.tabPage1.Controls.Add(this.richTextBox_Obs);
            this.tabPage1.Controls.Add(this.lbl_NumMatric);
            this.tabPage1.Controls.Add(this.textB_Telefone);
            this.tabPage1.Controls.Add(this.textB_Altura);
            this.tabPage1.Controls.Add(this.textB_Peso);
            this.tabPage1.Controls.Add(this.textB_NomeCliente);
            this.tabPage1.Controls.Add(this.lbl_Obs);
            this.tabPage1.Controls.Add(this.lbl_Telefone);
            this.tabPage1.Controls.Add(this.lbl_Endereco);
            this.tabPage1.Controls.Add(this.lbl_Altura);
            this.tabPage1.Controls.Add(this.lbl_Peso);
            this.tabPage1.Controls.Add(this.lbl_Matricula);
            this.tabPage1.Controls.Add(this.lbl_Nome);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1120, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            // 
            // maskedTB_DtNasc
            // 
            this.maskedTB_DtNasc.Location = new System.Drawing.Point(140, 59);
            this.maskedTB_DtNasc.Mask = "00/00/0000";
            this.maskedTB_DtNasc.Name = "maskedTB_DtNasc";
            this.maskedTB_DtNasc.Size = new System.Drawing.Size(100, 20);
            this.maskedTB_DtNasc.TabIndex = 5;
            this.maskedTB_DtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DtNasc
            // 
            this.lbl_DtNasc.AutoSize = true;
            this.lbl_DtNasc.Location = new System.Drawing.Point(25, 65);
            this.lbl_DtNasc.Name = "lbl_DtNasc";
            this.lbl_DtNasc.Size = new System.Drawing.Size(109, 13);
            this.lbl_DtNasc.TabIndex = 4;
            this.lbl_DtNasc.Text = "Data Nascimento*";
            // 
            // btn_LimparTudoClientes
            // 
            this.btn_LimparTudoClientes.Location = new System.Drawing.Point(339, 270);
            this.btn_LimparTudoClientes.Name = "btn_LimparTudoClientes";
            this.btn_LimparTudoClientes.Size = new System.Drawing.Size(102, 23);
            this.btn_LimparTudoClientes.TabIndex = 20;
            this.btn_LimparTudoClientes.Text = "Limpar Tudo";
            this.btn_LimparTudoClientes.UseVisualStyleBackColor = true;
            this.btn_LimparTudoClientes.Click += new System.EventHandler(this.btn_LimparTudoClientes_Click);
            // 
            // lbl_Rotulos
            // 
            this.lbl_Rotulos.AutoSize = true;
            this.lbl_Rotulos.Location = new System.Drawing.Point(620, 33);
            this.lbl_Rotulos.Name = "lbl_Rotulos";
            this.lbl_Rotulos.Size = new System.Drawing.Size(274, 13);
            this.lbl_Rotulos.TabIndex = 23;
            this.lbl_Rotulos.Text = "Nome | Matricula | Idade | Peso | Altura | Sexo |";
            // 
            // lbl_CamposObrigatorios
            // 
            this.lbl_CamposObrigatorios.AutoSize = true;
            this.lbl_CamposObrigatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CamposObrigatorios.Location = new System.Drawing.Point(109, 263);
            this.lbl_CamposObrigatorios.Name = "lbl_CamposObrigatorios";
            this.lbl_CamposObrigatorios.Size = new System.Drawing.Size(161, 16);
            this.lbl_CamposObrigatorios.TabIndex = 19;
            this.lbl_CamposObrigatorios.Text = "*Campos Obrigatorios";
            // 
            // textB_Genero
            // 
            this.textB_Genero.Location = new System.Drawing.Point(451, 62);
            this.textB_Genero.Name = "textB_Genero";
            this.textB_Genero.Size = new System.Drawing.Size(43, 20);
            this.textB_Genero.TabIndex = 7;
            // 
            // lbl_Gen
            // 
            this.lbl_Gen.AutoSize = true;
            this.lbl_Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gen.Location = new System.Drawing.Point(273, 62);
            this.lbl_Gen.Name = "lbl_Gen";
            this.lbl_Gen.Size = new System.Drawing.Size(159, 13);
            this.lbl_Gen.TabIndex = 6;
            this.lbl_Gen.Text = "Sexo* (1 Mulher/2 Homem)";
            // 
            // lbl_ListaClientes
            // 
            this.lbl_ListaClientes.AutoSize = true;
            this.lbl_ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ListaClientes.Location = new System.Drawing.Point(718, 7);
            this.lbl_ListaClientes.Name = "lbl_ListaClientes";
            this.lbl_ListaClientes.Size = new System.Drawing.Size(145, 13);
            this.lbl_ListaClientes.TabIndex = 21;
            this.lbl_ListaClientes.Text = "Lista de Clientes | Total:";
            // 
            // listBox_ListaClientes
            // 
            this.listBox_ListaClientes.FormattingEnabled = true;
            this.listBox_ListaClientes.Location = new System.Drawing.Point(623, 55);
            this.listBox_ListaClientes.Name = "listBox_ListaClientes";
            this.listBox_ListaClientes.Size = new System.Drawing.Size(448, 238);
            this.listBox_ListaClientes.TabIndex = 24;
            // 
            // lbl_NumClientes
            // 
            this.lbl_NumClientes.AutoSize = true;
            this.lbl_NumClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumClientes.Location = new System.Drawing.Point(865, 7);
            this.lbl_NumClientes.Name = "lbl_NumClientes";
            this.lbl_NumClientes.Size = new System.Drawing.Size(60, 13);
            this.lbl_NumClientes.TabIndex = 22;
            this.lbl_NumClientes.Text = "#Clientes";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(28, 260);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 18;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // richTextBox_Endereco
            // 
            this.richTextBox_Endereco.Location = new System.Drawing.Point(28, 192);
            this.richTextBox_Endereco.Name = "richTextBox_Endereco";
            this.richTextBox_Endereco.Size = new System.Drawing.Size(180, 49);
            this.richTextBox_Endereco.TabIndex = 15;
            this.richTextBox_Endereco.Text = "";
            // 
            // richTextBox_Obs
            // 
            this.richTextBox_Obs.Location = new System.Drawing.Point(338, 185);
            this.richTextBox_Obs.Name = "richTextBox_Obs";
            this.richTextBox_Obs.Size = new System.Drawing.Size(198, 78);
            this.richTextBox_Obs.TabIndex = 17;
            this.richTextBox_Obs.Text = "";
            // 
            // lbl_NumMatric
            // 
            this.lbl_NumMatric.AutoSize = true;
            this.lbl_NumMatric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumMatric.Location = new System.Drawing.Point(335, 26);
            this.lbl_NumMatric.Name = "lbl_NumMatric";
            this.lbl_NumMatric.Size = new System.Drawing.Size(67, 13);
            this.lbl_NumMatric.TabIndex = 3;
            this.lbl_NumMatric.Text = "#Matricula";
            // 
            // textB_Telefone
            // 
            this.textB_Telefone.Location = new System.Drawing.Point(327, 127);
            this.textB_Telefone.Name = "textB_Telefone";
            this.textB_Telefone.Size = new System.Drawing.Size(100, 20);
            this.textB_Telefone.TabIndex = 13;
            // 
            // textB_Altura
            // 
            this.textB_Altura.Location = new System.Drawing.Point(269, 101);
            this.textB_Altura.Name = "textB_Altura";
            this.textB_Altura.Size = new System.Drawing.Size(54, 20);
            this.textB_Altura.TabIndex = 11;
            // 
            // textB_Peso
            // 
            this.textB_Peso.Location = new System.Drawing.Point(28, 122);
            this.textB_Peso.Name = "textB_Peso";
            this.textB_Peso.Size = new System.Drawing.Size(100, 20);
            this.textB_Peso.TabIndex = 9;
            // 
            // textB_NomeCliente
            // 
            this.textB_NomeCliente.Location = new System.Drawing.Point(75, 26);
            this.textB_NomeCliente.Name = "textB_NomeCliente";
            this.textB_NomeCliente.Size = new System.Drawing.Size(100, 20);
            this.textB_NomeCliente.TabIndex = 1;
            // 
            // lbl_Obs
            // 
            this.lbl_Obs.AutoSize = true;
            this.lbl_Obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Obs.Location = new System.Drawing.Point(335, 159);
            this.lbl_Obs.Name = "lbl_Obs";
            this.lbl_Obs.Size = new System.Drawing.Size(79, 13);
            this.lbl_Obs.TabIndex = 16;
            this.lbl_Obs.Text = "Observação:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone.Location = new System.Drawing.Point(266, 130);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(57, 13);
            this.lbl_Telefone.TabIndex = 12;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(25, 176);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(61, 13);
            this.lbl_Endereco.TabIndex = 14;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Altura.Location = new System.Drawing.Point(266, 85);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(175, 13);
            this.lbl_Altura.TabIndex = 10;
            this.lbl_Altura.Text = "Altura* (Metros,  use virgulas)";
            // 
            // lbl_Peso
            // 
            this.lbl_Peso.AutoSize = true;
            this.lbl_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Peso.Location = new System.Drawing.Point(25, 101);
            this.lbl_Peso.Name = "lbl_Peso";
            this.lbl_Peso.Size = new System.Drawing.Size(143, 13);
            this.lbl_Peso.TabIndex = 8;
            this.lbl_Peso.Text = "Peso* (Kg, use virgulas)";
            // 
            // lbl_Matricula
            // 
            this.lbl_Matricula.AutoSize = true;
            this.lbl_Matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Matricula.Location = new System.Drawing.Point(260, 26);
            this.lbl_Matricula.Name = "lbl_Matricula";
            this.lbl_Matricula.Size = new System.Drawing.Size(59, 13);
            this.lbl_Matricula.TabIndex = 2;
            this.lbl_Matricula.Text = "Matricula";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(25, 29);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome*";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.lbl_NomeResult);
            this.tabPage2.Controls.Add(this.lbl_ResultMassaGorda);
            this.tabPage2.Controls.Add(this.lbl_ResultImc);
            this.tabPage2.Controls.Add(this.lbl_MassaGorda);
            this.tabPage2.Controls.Add(this.lbl_IMC);
            this.tabPage2.Controls.Add(this.btn_CalcIMC);
            this.tabPage2.Controls.Add(this.textBox_MatricCliente);
            this.tabPage2.Controls.Add(this.lbl_MatricCliente);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1120, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Avaliaçao";
            // 
            // lbl_NomeResult
            // 
            this.lbl_NomeResult.AutoSize = true;
            this.lbl_NomeResult.Location = new System.Drawing.Point(23, 73);
            this.lbl_NomeResult.Name = "lbl_NomeResult";
            this.lbl_NomeResult.Size = new System.Drawing.Size(82, 13);
            this.lbl_NomeResult.TabIndex = 7;
            this.lbl_NomeResult.Text = "Nome Cliente";
            // 
            // lbl_ResultMassaGorda
            // 
            this.lbl_ResultMassaGorda.AutoSize = true;
            this.lbl_ResultMassaGorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResultMassaGorda.Location = new System.Drawing.Point(372, 179);
            this.lbl_ResultMassaGorda.Name = "lbl_ResultMassaGorda";
            this.lbl_ResultMassaGorda.Size = new System.Drawing.Size(142, 13);
            this.lbl_ResultMassaGorda.TabIndex = 5;
            this.lbl_ResultMassaGorda.Text = "Resultado Massa Gorda";
            // 
            // lbl_ResultImc
            // 
            this.lbl_ResultImc.AutoSize = true;
            this.lbl_ResultImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ResultImc.Location = new System.Drawing.Point(67, 179);
            this.lbl_ResultImc.Name = "lbl_ResultImc";
            this.lbl_ResultImc.Size = new System.Drawing.Size(90, 13);
            this.lbl_ResultImc.TabIndex = 3;
            this.lbl_ResultImc.Text = "Resultado IMC";
            // 
            // lbl_MassaGorda
            // 
            this.lbl_MassaGorda.AutoSize = true;
            this.lbl_MassaGorda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MassaGorda.Location = new System.Drawing.Point(293, 179);
            this.lbl_MassaGorda.Name = "lbl_MassaGorda";
            this.lbl_MassaGorda.Size = new System.Drawing.Size(89, 13);
            this.lbl_MassaGorda.TabIndex = 4;
            this.lbl_MassaGorda.Text = "Massa Gorda: ";
            // 
            // lbl_IMC
            // 
            this.lbl_IMC.AutoSize = true;
            this.lbl_IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IMC.Location = new System.Drawing.Point(24, 179);
            this.lbl_IMC.Name = "lbl_IMC";
            this.lbl_IMC.Size = new System.Drawing.Size(37, 13);
            this.lbl_IMC.TabIndex = 2;
            this.lbl_IMC.Text = "IMC: ";
            this.lbl_IMC.Click += new System.EventHandler(this.lbl_ResultIMC_Click);
            // 
            // btn_CalcIMC
            // 
            this.btn_CalcIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcIMC.Location = new System.Drawing.Point(283, 228);
            this.btn_CalcIMC.Name = "btn_CalcIMC";
            this.btn_CalcIMC.Size = new System.Drawing.Size(128, 34);
            this.btn_CalcIMC.TabIndex = 6;
            this.btn_CalcIMC.Text = "Calcular IMC/Massa Gorda";
            this.btn_CalcIMC.UseVisualStyleBackColor = true;
            this.btn_CalcIMC.Click += new System.EventHandler(this.btn_CalcIMC_Click);
            // 
            // textBox_MatricCliente
            // 
            this.textBox_MatricCliente.Location = new System.Drawing.Point(128, 44);
            this.textBox_MatricCliente.Name = "textBox_MatricCliente";
            this.textBox_MatricCliente.Size = new System.Drawing.Size(100, 20);
            this.textBox_MatricCliente.TabIndex = 1;
            // 
            // lbl_MatricCliente
            // 
            this.lbl_MatricCliente.AutoSize = true;
            this.lbl_MatricCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatricCliente.Location = new System.Drawing.Point(20, 47);
            this.lbl_MatricCliente.Name = "lbl_MatricCliente";
            this.lbl_MatricCliente.Size = new System.Drawing.Size(102, 13);
            this.lbl_MatricCliente.TabIndex = 0;
            this.lbl_MatricCliente.Text = "Matricula Cliente";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.listBox_PesqCli);
            this.tabPage3.Controls.Add(this.textB_MatricPesq);
            this.tabPage3.Controls.Add(this.lbl_MatricPesq);
            this.tabPage3.Controls.Add(this.lbl_PesquisarCli);
            this.tabPage3.Controls.Add(this.btn_PesquisarCli);
            this.tabPage3.Controls.Add(this.btn_ExibeCliente);
            this.tabPage3.Controls.Add(this.lbl_AlertaDel);
            this.tabPage3.Controls.Add(this.btn_DelCliente);
            this.tabPage3.Controls.Add(this.textBox_MatricDel);
            this.tabPage3.Controls.Add(this.lbl_ExibeNome);
            this.tabPage3.Controls.Add(this.lbl_NomeDel);
            this.tabPage3.Controls.Add(this.lbl_MatricDel);
            this.tabPage3.Controls.Add(this.lbl_DeletarCliente);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1120, 318);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ações";
            // 
            // btn_ExibeCliente
            // 
            this.btn_ExibeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExibeCliente.Location = new System.Drawing.Point(982, 126);
            this.btn_ExibeCliente.Name = "btn_ExibeCliente";
            this.btn_ExibeCliente.Size = new System.Drawing.Size(75, 40);
            this.btn_ExibeCliente.TabIndex = 5;
            this.btn_ExibeCliente.Text = "Exibe Cliente";
            this.btn_ExibeCliente.UseVisualStyleBackColor = true;
            this.btn_ExibeCliente.Click += new System.EventHandler(this.btn_ExibeCliente_Click);
            // 
            // lbl_AlertaDel
            // 
            this.lbl_AlertaDel.AutoSize = true;
            this.lbl_AlertaDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlertaDel.Location = new System.Drawing.Point(931, 271);
            this.lbl_AlertaDel.Name = "lbl_AlertaDel";
            this.lbl_AlertaDel.Size = new System.Drawing.Size(161, 13);
            this.lbl_AlertaDel.TabIndex = 7;
            this.lbl_AlertaDel.Text = "ALERTA: Ação Irreversível";
            // 
            // btn_DelCliente
            // 
            this.btn_DelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelCliente.Location = new System.Drawing.Point(982, 231);
            this.btn_DelCliente.Name = "btn_DelCliente";
            this.btn_DelCliente.Size = new System.Drawing.Size(75, 37);
            this.btn_DelCliente.TabIndex = 6;
            this.btn_DelCliente.Text = "Deleta Cliente";
            this.btn_DelCliente.UseVisualStyleBackColor = true;
            // 
            // textBox_MatricDel
            // 
            this.textBox_MatricDel.Location = new System.Drawing.Point(971, 45);
            this.textBox_MatricDel.Name = "textBox_MatricDel";
            this.textBox_MatricDel.Size = new System.Drawing.Size(100, 20);
            this.textBox_MatricDel.TabIndex = 2;
            this.textBox_MatricDel.TextChanged += new System.EventHandler(this.textBox_MatricDel_TextChanged);
            // 
            // lbl_ExibeNome
            // 
            this.lbl_ExibeNome.AutoSize = true;
            this.lbl_ExibeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExibeNome.Location = new System.Drawing.Point(1010, 92);
            this.lbl_ExibeNome.Name = "lbl_ExibeNome";
            this.lbl_ExibeNome.Size = new System.Drawing.Size(39, 13);
            this.lbl_ExibeNome.TabIndex = 4;
            this.lbl_ExibeNome.Text = "Nome";
            // 
            // lbl_NomeDel
            // 
            this.lbl_NomeDel.AutoSize = true;
            this.lbl_NomeDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeDel.Location = new System.Drawing.Point(909, 92);
            this.lbl_NomeDel.Name = "lbl_NomeDel";
            this.lbl_NomeDel.Size = new System.Drawing.Size(86, 13);
            this.lbl_NomeDel.TabIndex = 3;
            this.lbl_NomeDel.Text = "Nome Cliente:";
            // 
            // lbl_MatricDel
            // 
            this.lbl_MatricDel.AutoSize = true;
            this.lbl_MatricDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatricDel.Location = new System.Drawing.Point(906, 48);
            this.lbl_MatricDel.Name = "lbl_MatricDel";
            this.lbl_MatricDel.Size = new System.Drawing.Size(59, 13);
            this.lbl_MatricDel.TabIndex = 1;
            this.lbl_MatricDel.Text = "Matricula";
            // 
            // lbl_DeletarCliente
            // 
            this.lbl_DeletarCliente.AutoSize = true;
            this.lbl_DeletarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeletarCliente.Location = new System.Drawing.Point(903, 9);
            this.lbl_DeletarCliente.Name = "lbl_DeletarCliente";
            this.lbl_DeletarCliente.Size = new System.Drawing.Size(91, 13);
            this.lbl_DeletarCliente.TabIndex = 0;
            this.lbl_DeletarCliente.Text = "Deletar Cliente";
            // 
            // btn_PesquisarCli
            // 
            this.btn_PesquisarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarCli.Location = new System.Drawing.Point(30, 245);
            this.btn_PesquisarCli.Name = "btn_PesquisarCli";
            this.btn_PesquisarCli.Size = new System.Drawing.Size(75, 39);
            this.btn_PesquisarCli.TabIndex = 8;
            this.btn_PesquisarCli.Text = "Pesquisar Cliente";
            this.btn_PesquisarCli.UseVisualStyleBackColor = true;
            // 
            // lbl_PesquisarCli
            // 
            this.lbl_PesquisarCli.AutoSize = true;
            this.lbl_PesquisarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PesquisarCli.Location = new System.Drawing.Point(18, 9);
            this.lbl_PesquisarCli.Name = "lbl_PesquisarCli";
            this.lbl_PesquisarCli.Size = new System.Drawing.Size(105, 13);
            this.lbl_PesquisarCli.TabIndex = 9;
            this.lbl_PesquisarCli.Text = "Pesquisar Cliente";
            // 
            // lbl_MatricPesq
            // 
            this.lbl_MatricPesq.AutoSize = true;
            this.lbl_MatricPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatricPesq.Location = new System.Drawing.Point(21, 51);
            this.lbl_MatricPesq.Name = "lbl_MatricPesq";
            this.lbl_MatricPesq.Size = new System.Drawing.Size(59, 13);
            this.lbl_MatricPesq.TabIndex = 10;
            this.lbl_MatricPesq.Text = "Matricula";
            // 
            // textB_MatricPesq
            // 
            this.textB_MatricPesq.Location = new System.Drawing.Point(86, 45);
            this.textB_MatricPesq.Name = "textB_MatricPesq";
            this.textB_MatricPesq.Size = new System.Drawing.Size(100, 20);
            this.textB_MatricPesq.TabIndex = 11;
            // 
            // listBox_PesqCli
            // 
            this.listBox_PesqCli.FormattingEnabled = true;
            this.listBox_PesqCli.Items.AddRange(new object[] {
            "ID: ",
            "Nome: ",
            "Idade: ",
            "Peso: ",
            "Altura: ",
            "Sexo: "});
            this.listBox_PesqCli.Location = new System.Drawing.Point(21, 106);
            this.listBox_PesqCli.Name = "listBox_PesqCli";
            this.listBox_PesqCli.Size = new System.Drawing.Size(713, 108);
            this.listBox_PesqCli.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_Obs;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Peso;
        private System.Windows.Forms.Label lbl_Matricula;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_MassaGorda;
        private System.Windows.Forms.Label lbl_IMC;
        private System.Windows.Forms.Button btn_CalcIMC;
        private System.Windows.Forms.TextBox textBox_MatricCliente;
        private System.Windows.Forms.Label lbl_MatricCliente;
        private System.Windows.Forms.Label lbl_NumMatric;
        private System.Windows.Forms.TextBox textB_Telefone;
        private System.Windows.Forms.TextBox textB_Altura;
        private System.Windows.Forms.TextBox textB_Peso;
        private System.Windows.Forms.TextBox textB_NomeCliente;
        private System.Windows.Forms.RichTextBox richTextBox_Obs;
        private System.Windows.Forms.RichTextBox richTextBox_Endereco;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label lbl_NumClientes;
        private System.Windows.Forms.Label lbl_ListaClientes;
        private System.Windows.Forms.ListBox listBox_ListaClientes;
        private System.Windows.Forms.Label lbl_ResultMassaGorda;
        private System.Windows.Forms.Label lbl_ResultImc;
        private System.Windows.Forms.TextBox textB_Genero;
        private System.Windows.Forms.Label lbl_Gen;
        private System.Windows.Forms.Label lbl_CamposObrigatorios;
        private System.Windows.Forms.Label lbl_Rotulos;
        private System.Windows.Forms.Label lbl_NomeResult;
        private System.Windows.Forms.Button btn_LimparTudoClientes;
        private System.Windows.Forms.MaskedTextBox maskedTB_DtNasc;
        private System.Windows.Forms.Label lbl_DtNasc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_AlertaDel;
        private System.Windows.Forms.Button btn_DelCliente;
        private System.Windows.Forms.TextBox textBox_MatricDel;
        private System.Windows.Forms.Label lbl_ExibeNome;
        private System.Windows.Forms.Label lbl_NomeDel;
        private System.Windows.Forms.Label lbl_MatricDel;
        private System.Windows.Forms.Label lbl_DeletarCliente;
        private System.Windows.Forms.Button btn_ExibeCliente;
        private System.Windows.Forms.TextBox textB_MatricPesq;
        private System.Windows.Forms.Label lbl_MatricPesq;
        private System.Windows.Forms.Label lbl_PesquisarCli;
        private System.Windows.Forms.Button btn_PesquisarCli;
        private System.Windows.Forms.ListBox listBox_PesqCli;
    }
}

