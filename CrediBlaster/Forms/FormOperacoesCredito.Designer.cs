namespace CrediBlaster
{
    partial class FormOperacoesCredito
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
            this.textBoxCodCliente = new System.Windows.Forms.TextBox();
            this.labelCodCliente = new System.Windows.Forms.Label();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.textBoxSituacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosOperacao = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNumContrato = new System.Windows.Forms.Label();
            this.textBoxNumeroContrato = new System.Windows.Forms.TextBox();
            this.textBoxParcelas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelTipoVencimento = new System.Windows.Forms.Label();
            this.comboBoxTipoVencimento = new System.Windows.Forms.ComboBox();
            this.labelCarencia = new System.Windows.Forms.Label();
            this.textBoxCarencia = new System.Windows.Forms.TextBox();
            this.labelTxJuros = new System.Windows.Forms.Label();
            this.textBoxTxJuros = new System.Windows.Forms.TextBox();
            this.labelValorOperacao = new System.Windows.Forms.Label();
            this.textBoxValorOperacao = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nr_prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_jur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_jur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_tot_prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.textBoxJurosCalculado = new System.Windows.Forms.TextBox();
            this.labelJurosCalc = new System.Windows.Forms.Label();
            this.textBoxTotalAPagar = new System.Windows.Forms.TextBox();
            this.labelTotPagar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.textBoxDescrAgencia = new System.Windows.Forms.TextBox();
            this.textBoxUnidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrazoTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxDadosCliente.SuspendLayout();
            this.groupBoxDadosOperacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCodCliente
            // 
            this.textBoxCodCliente.Location = new System.Drawing.Point(106, 32);
            this.textBoxCodCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodCliente.MaxLength = 6;
            this.textBoxCodCliente.Name = "textBoxCodCliente";
            this.textBoxCodCliente.Size = new System.Drawing.Size(79, 20);
            this.textBoxCodCliente.TabIndex = 0;
            this.textBoxCodCliente.TextChanged += new System.EventHandler(this.textBoxCodCliente_TextChanged);
            // 
            // labelCodCliente
            // 
            this.labelCodCliente.AutoSize = true;
            this.labelCodCliente.Location = new System.Drawing.Point(16, 35);
            this.labelCodCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodCliente.Name = "labelCodCliente";
            this.labelCodCliente.Size = new System.Drawing.Size(64, 13);
            this.labelCodCliente.TabIndex = 1;
            this.labelCodCliente.Text = "Cód. Cliente";
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(284, 32);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeCliente.MaxLength = 50;
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(238, 20);
            this.textBoxNomeCliente.TabIndex = 2;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(226, 35);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCliente.TabIndex = 3;
            this.labelNomeCliente.Text = "Nome";
            // 
            // textBoxSituacao
            // 
            this.textBoxSituacao.Location = new System.Drawing.Point(644, 31);
            this.textBoxSituacao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSituacao.MaxLength = 10;
            this.textBoxSituacao.Name = "textBoxSituacao";
            this.textBoxSituacao.Size = new System.Drawing.Size(125, 20);
            this.textBoxSituacao.TabIndex = 4;
            this.textBoxSituacao.TextChanged += new System.EventHandler(this.textBoxSituacao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Situação";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(812, 25);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(74, 29);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDadosCliente.Controls.Add(this.textBoxCodCliente);
            this.groupBoxDadosCliente.Controls.Add(this.buttonBuscar);
            this.groupBoxDadosCliente.Controls.Add(this.labelCodCliente);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxSituacao);
            this.groupBoxDadosCliente.Controls.Add(this.label1);
            this.groupBoxDadosCliente.Controls.Add(this.textBoxNomeCliente);
            this.groupBoxDadosCliente.Controls.Add(this.labelNomeCliente);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(321, 92);
            this.groupBoxDadosCliente.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(899, 81);
            this.groupBoxDadosCliente.TabIndex = 7;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Dados do cliente";
            this.groupBoxDadosCliente.Enter += new System.EventHandler(this.groupBoxDadosCliente_Enter);
            // 
            // groupBoxDadosOperacao
            // 
            this.groupBoxDadosOperacao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxDadosOperacao.Controls.Add(this.label7);
            this.groupBoxDadosOperacao.Controls.Add(this.comboBox1);
            this.groupBoxDadosOperacao.Controls.Add(this.labelNumContrato);
            this.groupBoxDadosOperacao.Controls.Add(this.textBoxNumeroContrato);
            this.groupBoxDadosOperacao.Controls.Add(this.textBoxParcelas);
            this.groupBoxDadosOperacao.Controls.Add(this.label2);
            this.groupBoxDadosOperacao.Controls.Add(this.buttonCalcular);
            this.groupBoxDadosOperacao.Controls.Add(this.labelTipoVencimento);
            this.groupBoxDadosOperacao.Controls.Add(this.comboBoxTipoVencimento);
            this.groupBoxDadosOperacao.Controls.Add(this.labelCarencia);
            this.groupBoxDadosOperacao.Controls.Add(this.textBoxCarencia);
            this.groupBoxDadosOperacao.Controls.Add(this.labelTxJuros);
            this.groupBoxDadosOperacao.Controls.Add(this.textBoxTxJuros);
            this.groupBoxDadosOperacao.Controls.Add(this.labelValorOperacao);
            this.groupBoxDadosOperacao.Controls.Add(this.textBoxValorOperacao);
            this.groupBoxDadosOperacao.Location = new System.Drawing.Point(321, 209);
            this.groupBoxDadosOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDadosOperacao.Name = "groupBoxDadosOperacao";
            this.groupBoxDadosOperacao.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDadosOperacao.Size = new System.Drawing.Size(899, 110);
            this.groupBoxDadosOperacao.TabIndex = 8;
            this.groupBoxDadosOperacao.TabStop = false;
            this.groupBoxDadosOperacao.Text = "Dados da operação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Método de Calculo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(573, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNumContrato
            // 
            this.labelNumContrato.AutoSize = true;
            this.labelNumContrato.Location = new System.Drawing.Point(669, 44);
            this.labelNumContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumContrato.Name = "labelNumContrato";
            this.labelNumContrato.Size = new System.Drawing.Size(47, 13);
            this.labelNumContrato.TabIndex = 12;
            this.labelNumContrato.Text = "Contrato";
            // 
            // textBoxNumeroContrato
            // 
            this.textBoxNumeroContrato.Location = new System.Drawing.Point(720, 41);
            this.textBoxNumeroContrato.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeroContrato.Name = "textBoxNumeroContrato";
            this.textBoxNumeroContrato.ReadOnly = true;
            this.textBoxNumeroContrato.Size = new System.Drawing.Size(74, 20);
            this.textBoxNumeroContrato.TabIndex = 11;
            this.textBoxNumeroContrato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxParcelas
            // 
            this.textBoxParcelas.Location = new System.Drawing.Point(573, 41);
            this.textBoxParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParcelas.Name = "textBoxParcelas";
            this.textBoxParcelas.Size = new System.Drawing.Size(76, 20);
            this.textBoxParcelas.TabIndex = 10;
            this.textBoxParcelas.TextChanged += new System.EventHandler(this.textBoxParcelas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Número de parcelas";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(812, 32);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(72, 29);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelTipoVencimento
            // 
            this.labelTipoVencimento.AutoSize = true;
            this.labelTipoVencimento.Location = new System.Drawing.Point(226, 83);
            this.labelTipoVencimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoVencimento.Name = "labelTipoVencimento";
            this.labelTipoVencimento.Size = new System.Drawing.Size(87, 13);
            this.labelTipoVencimento.TabIndex = 7;
            this.labelTipoVencimento.Text = "Tipo Vencimento";
            // 
            // comboBoxTipoVencimento
            // 
            this.comboBoxTipoVencimento.FormattingEnabled = true;
            this.comboBoxTipoVencimento.Location = new System.Drawing.Point(319, 80);
            this.comboBoxTipoVencimento.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipoVencimento.Name = "comboBoxTipoVencimento";
            this.comboBoxTipoVencimento.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTipoVencimento.TabIndex = 6;
            this.comboBoxTipoVencimento.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoVencimento_SelectedIndexChanged);
            // 
            // labelCarencia
            // 
            this.labelCarencia.AutoSize = true;
            this.labelCarencia.Location = new System.Drawing.Point(226, 40);
            this.labelCarencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCarencia.Name = "labelCarencia";
            this.labelCarencia.Size = new System.Drawing.Size(49, 13);
            this.labelCarencia.TabIndex = 5;
            this.labelCarencia.Text = "Carencia";
            // 
            // textBoxCarencia
            // 
            this.textBoxCarencia.Location = new System.Drawing.Point(319, 37);
            this.textBoxCarencia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCarencia.MaxLength = 3;
            this.textBoxCarencia.Name = "textBoxCarencia";
            this.textBoxCarencia.Size = new System.Drawing.Size(76, 20);
            this.textBoxCarencia.TabIndex = 4;
            // 
            // labelTxJuros
            // 
            this.labelTxJuros.AutoSize = true;
            this.labelTxJuros.Location = new System.Drawing.Point(8, 81);
            this.labelTxJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTxJuros.Name = "labelTxJuros";
            this.labelTxJuros.Size = new System.Drawing.Size(88, 13);
            this.labelTxJuros.TabIndex = 3;
            this.labelTxJuros.Text = "Taxa de Juros(%)";
            // 
            // textBoxTxJuros
            // 
            this.textBoxTxJuros.Location = new System.Drawing.Point(106, 79);
            this.textBoxTxJuros.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTxJuros.MaxLength = 10;
            this.textBoxTxJuros.Name = "textBoxTxJuros";
            this.textBoxTxJuros.Size = new System.Drawing.Size(93, 20);
            this.textBoxTxJuros.TabIndex = 2;
            // 
            // labelValorOperacao
            // 
            this.labelValorOperacao.AutoSize = true;
            this.labelValorOperacao.Location = new System.Drawing.Point(8, 41);
            this.labelValorOperacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValorOperacao.Name = "labelValorOperacao";
            this.labelValorOperacao.Size = new System.Drawing.Size(94, 13);
            this.labelValorOperacao.TabIndex = 1;
            this.labelValorOperacao.Text = "Valor da operação";
            // 
            // textBoxValorOperacao
            // 
            this.textBoxValorOperacao.AcceptsTab = true;
            this.textBoxValorOperacao.Location = new System.Drawing.Point(106, 37);
            this.textBoxValorOperacao.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValorOperacao.MaxLength = 10;
            this.textBoxValorOperacao.Name = "textBoxValorOperacao";
            this.textBoxValorOperacao.Size = new System.Drawing.Size(86, 20);
            this.textBoxValorOperacao.TabIndex = 0;
            this.textBoxValorOperacao.TextChanged += new System.EventHandler(this.textBoxValorOperacao_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_prc,
            this.tx_jur,
            this.vr_jur,
            this.vr_prc,
            this.vr_tot_prc,
            this.dt_venc});
            this.dataGridView1.Location = new System.Drawing.Point(321, 358);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(658, 362);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nr_prc
            // 
            this.nr_prc.HeaderText = "Parcela";
            this.nr_prc.Name = "nr_prc";
            this.nr_prc.ReadOnly = true;
            // 
            // tx_jur
            // 
            this.tx_jur.HeaderText = "Taxa de Júros (%)";
            this.tx_jur.Name = "tx_jur";
            this.tx_jur.ReadOnly = true;
            // 
            // vr_jur
            // 
            this.vr_jur.HeaderText = "Valor do júros ";
            this.vr_jur.Name = "vr_jur";
            this.vr_jur.ReadOnly = true;
            // 
            // vr_prc
            // 
            this.vr_prc.HeaderText = "Valor da Parcela";
            this.vr_prc.Name = "vr_prc";
            this.vr_prc.ReadOnly = true;
            // 
            // vr_tot_prc
            // 
            this.vr_tot_prc.HeaderText = "Total a pagar";
            this.vr_tot_prc.Name = "vr_tot_prc";
            this.vr_tot_prc.ReadOnly = true;
            // 
            // dt_venc
            // 
            this.dt_venc.HeaderText = "Vencimento";
            this.dt_venc.Name = "dt_venc";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(1013, 734);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(72, 29);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(1100, 735);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(72, 27);
            this.buttonConfirmar.TabIndex = 11;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // textBoxJurosCalculado
            // 
            this.textBoxJurosCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJurosCalculado.Location = new System.Drawing.Point(1155, 376);
            this.textBoxJurosCalculado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJurosCalculado.Name = "textBoxJurosCalculado";
            this.textBoxJurosCalculado.Size = new System.Drawing.Size(147, 27);
            this.textBoxJurosCalculado.TabIndex = 12;
            this.textBoxJurosCalculado.TextChanged += new System.EventHandler(this.textBoxJurosCalculado_TextChanged);
            // 
            // labelJurosCalc
            // 
            this.labelJurosCalc.AutoSize = true;
            this.labelJurosCalc.BackColor = System.Drawing.Color.Transparent;
            this.labelJurosCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJurosCalc.ForeColor = System.Drawing.Color.White;
            this.labelJurosCalc.Location = new System.Drawing.Point(1006, 376);
            this.labelJurosCalc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJurosCalc.Name = "labelJurosCalc";
            this.labelJurosCalc.Size = new System.Drawing.Size(127, 20);
            this.labelJurosCalc.TabIndex = 13;
            this.labelJurosCalc.Text = "Juros calculado";
            // 
            // textBoxTotalAPagar
            // 
            this.textBoxTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAPagar.Location = new System.Drawing.Point(1155, 412);
            this.textBoxTotalAPagar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalAPagar.Name = "textBoxTotalAPagar";
            this.textBoxTotalAPagar.Size = new System.Drawing.Size(147, 27);
            this.textBoxTotalAPagar.TabIndex = 14;
            this.textBoxTotalAPagar.TextChanged += new System.EventHandler(this.textBoxTotalAPagar_TextChanged);
            // 
            // labelTotPagar
            // 
            this.labelTotPagar.AutoSize = true;
            this.labelTotPagar.BackColor = System.Drawing.Color.Transparent;
            this.labelTotPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotPagar.ForeColor = System.Drawing.Color.White;
            this.labelTotPagar.Location = new System.Drawing.Point(1026, 415);
            this.labelTotPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotPagar.Name = "labelTotPagar";
            this.labelTotPagar.Size = new System.Drawing.Size(107, 20);
            this.labelTotPagar.TabIndex = 15;
            this.labelTotPagar.Text = "Total a pagar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDataAtual);
            this.groupBox1.Controls.Add(this.textBoxDescrAgencia);
            this.groupBox1.Controls.Add(this.textBoxUnidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(1275, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 233);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrangência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Agência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidade";
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Location = new System.Drawing.Point(100, 167);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.ReadOnly = true;
            this.textBoxDataAtual.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataAtual.TabIndex = 4;
            this.textBoxDataAtual.TextChanged += new System.EventHandler(this.textBoxDataAtual_TextChanged);
            // 
            // textBoxDescrAgencia
            // 
            this.textBoxDescrAgencia.Location = new System.Drawing.Point(100, 131);
            this.textBoxDescrAgencia.Name = "textBoxDescrAgencia";
            this.textBoxDescrAgencia.ReadOnly = true;
            this.textBoxDescrAgencia.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescrAgencia.TabIndex = 3;
            this.textBoxDescrAgencia.TextChanged += new System.EventHandler(this.textBoxDescrAgencia_TextChanged);
            // 
            // textBoxUnidade
            // 
            this.textBoxUnidade.Location = new System.Drawing.Point(100, 91);
            this.textBoxUnidade.Name = "textBoxUnidade";
            this.textBoxUnidade.ReadOnly = true;
            this.textBoxUnidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnidade.TabIndex = 2;
            this.textBoxUnidade.TextChanged += new System.EventHandler(this.textBoxUnidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Empresa";
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(100, 55);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.ReadOnly = true;
            this.textBoxEmpresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpresa.TabIndex = 0;
            this.textBoxEmpresa.TextChanged += new System.EventHandler(this.textBoxEmpresa_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1750, 828);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPrazoTotal
            // 
            this.textBoxPrazoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrazoTotal.Location = new System.Drawing.Point(1155, 454);
            this.textBoxPrazoTotal.Name = "textBoxPrazoTotal";
            this.textBoxPrazoTotal.Size = new System.Drawing.Size(147, 27);
            this.textBoxPrazoTotal.TabIndex = 18;
            this.textBoxPrazoTotal.TextChanged += new System.EventHandler(this.textBoxPrazoTotal_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1080, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Prazo";
            // 
            // FormOperacoesCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1837, 863);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPrazoTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTotPagar);
            this.Controls.Add(this.textBoxTotalAPagar);
            this.Controls.Add(this.labelJurosCalc);
            this.Controls.Add(this.textBoxJurosCalculado);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxDadosOperacao);
            this.Controls.Add(this.groupBoxDadosCliente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOperacoesCredito";
            this.Text = "FormOperacoesCredito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOperacoesCredito_Load);
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.groupBoxDadosCliente.PerformLayout();
            this.groupBoxDadosOperacao.ResumeLayout(false);
            this.groupBoxDadosOperacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCodCliente;
        private System.Windows.Forms.Label labelCodCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textBoxSituacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.GroupBox groupBoxDadosCliente;
        private System.Windows.Forms.GroupBox groupBoxDadosOperacao;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelTipoVencimento;
        private System.Windows.Forms.ComboBox comboBoxTipoVencimento;
        private System.Windows.Forms.Label labelCarencia;
        private System.Windows.Forms.TextBox textBoxCarencia;
        private System.Windows.Forms.Label labelTxJuros;
        private System.Windows.Forms.TextBox textBoxTxJuros;
        private System.Windows.Forms.Label labelValorOperacao;
        private System.Windows.Forms.TextBox textBoxValorOperacao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tx_jur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_jur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_tot_prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_venc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxParcelas;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxNumeroContrato;
        private System.Windows.Forms.Label labelNumContrato;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TextBox textBoxJurosCalculado;
        private System.Windows.Forms.Label labelJurosCalc;
        private System.Windows.Forms.TextBox textBoxTotalAPagar;
        private System.Windows.Forms.Label labelTotPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.TextBox textBoxDescrAgencia;
        private System.Windows.Forms.TextBox textBoxUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrazoTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}