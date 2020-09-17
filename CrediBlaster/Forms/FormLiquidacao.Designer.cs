namespace CrediBlaster
{
    partial class FormLiquidacao
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
            this.textBoxNumeroCtr = new System.Windows.Forms.TextBox();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxCodCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txJur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotParc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTotCalculado = new System.Windows.Forms.TextBox();
            this.textBoxValorDesconto = new System.Windows.Forms.TextBox();
            this.textBoxValorPago = new System.Windows.Forms.TextBox();
            this.textBoxParcela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.buttonLiquidar = new System.Windows.Forms.Button();
            this.textBoxJurosCobrado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonIncluirLote = new System.Windows.Forms.Button();
            this.textBoxNumLote = new System.Windows.Forms.TextBox();
            this.labelLote = new System.Windows.Forms.Label();
            this.textBoxSeq = new System.Windows.Forms.TextBox();
            this.buttonFecharLote = new System.Windows.Forms.Button();
            this.checkBoxContratosAbertos = new System.Windows.Forms.CheckBox();
            this.buttonNovaTela = new System.Windows.Forms.Button();
            this.GroupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.textBoxDescrAgencia = new System.Windows.Forms.TextBox();
            this.textBoxUnidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBoxFiltro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNumeroCtr
            // 
            this.textBoxNumeroCtr.Location = new System.Drawing.Point(72, 27);
            this.textBoxNumeroCtr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeroCtr.MaxLength = 15;
            this.textBoxNumeroCtr.Name = "textBoxNumeroCtr";
            this.textBoxNumeroCtr.Size = new System.Drawing.Size(88, 20);
            this.textBoxNumeroCtr.TabIndex = 0;
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(240, 27);
            this.textBoxNomeCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomeCliente.MaxLength = 50;
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.ReadOnly = true;
            this.textBoxNomeCliente.Size = new System.Drawing.Size(133, 20);
            this.textBoxNomeCliente.TabIndex = 1;
            // 
            // textBoxCodCliente
            // 
            this.textBoxCodCliente.Location = new System.Drawing.Point(440, 27);
            this.textBoxCodCliente.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCodCliente.Name = "textBoxCodCliente";
            this.textBoxCodCliente.ReadOnly = true;
            this.textBoxCodCliente.Size = new System.Drawing.Size(76, 20);
            this.textBoxCodCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(691, 18);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(68, 29);
            this.buttonBuscar.TabIndex = 6;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.Contrato,
            this.parcela,
            this.txJur,
            this.valorJuros,
            this.vrParcela,
            this.ValorTotParc,
            this.dtVencimento});
            this.dataGridView1.Location = new System.Drawing.Point(227, 221);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 563);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            // 
            // parcela
            // 
            this.parcela.HeaderText = "Parcela";
            this.parcela.MaxInputLength = 10;
            this.parcela.Name = "parcela";
            this.parcela.ReadOnly = true;
            // 
            // txJur
            // 
            this.txJur.HeaderText = "Taxa de Juros (%)";
            this.txJur.Name = "txJur";
            this.txJur.ReadOnly = true;
            // 
            // valorJuros
            // 
            this.valorJuros.HeaderText = "Valor Juros";
            this.valorJuros.Name = "valorJuros";
            this.valorJuros.ReadOnly = true;
            // 
            // vrParcela
            // 
            this.vrParcela.HeaderText = "Valor Parcela";
            this.vrParcela.Name = "vrParcela";
            this.vrParcela.ReadOnly = true;
            // 
            // ValorTotParc
            // 
            this.ValorTotParc.HeaderText = "Total da Parcela";
            this.ValorTotParc.Name = "ValorTotParc";
            this.ValorTotParc.ReadOnly = true;
            // 
            // dtVencimento
            // 
            this.dtVencimento.HeaderText = "Vencimento";
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.ReadOnly = true;
            // 
            // textBoxTotCalculado
            // 
            this.textBoxTotCalculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotCalculado.Location = new System.Drawing.Point(1298, 544);
            this.textBoxTotCalculado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotCalculado.Name = "textBoxTotCalculado";
            this.textBoxTotCalculado.ReadOnly = true;
            this.textBoxTotCalculado.Size = new System.Drawing.Size(175, 27);
            this.textBoxTotCalculado.TabIndex = 8;
            // 
            // textBoxValorDesconto
            // 
            this.textBoxValorDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorDesconto.Location = new System.Drawing.Point(1298, 612);
            this.textBoxValorDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValorDesconto.Name = "textBoxValorDesconto";
            this.textBoxValorDesconto.Size = new System.Drawing.Size(175, 27);
            this.textBoxValorDesconto.TabIndex = 9;
            this.textBoxValorDesconto.TextChanged += new System.EventHandler(this.textBoxValorDesconto_TextChanged);
            // 
            // textBoxValorPago
            // 
            this.textBoxValorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorPago.Location = new System.Drawing.Point(1298, 647);
            this.textBoxValorPago.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValorPago.Name = "textBoxValorPago";
            this.textBoxValorPago.ReadOnly = true;
            this.textBoxValorPago.Size = new System.Drawing.Size(175, 27);
            this.textBoxValorPago.TabIndex = 10;
            // 
            // textBoxParcela
            // 
            this.textBoxParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParcela.Location = new System.Drawing.Point(1298, 511);
            this.textBoxParcela.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParcela.MaxLength = 5;
            this.textBoxParcela.Name = "textBoxParcela";
            this.textBoxParcela.Size = new System.Drawing.Size(40, 27);
            this.textBoxParcela.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1124, 512);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parcela";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1124, 545);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total calculado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1124, 613);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1124, 648);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total a pagar";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCalcular.Location = new System.Drawing.Point(1127, 692);
            this.buttonCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(68, 29);
            this.buttonCalcular.TabIndex = 16;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // buttonLiquidar
            // 
            this.buttonLiquidar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLiquidar.Location = new System.Drawing.Point(1270, 692);
            this.buttonLiquidar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLiquidar.Name = "buttonLiquidar";
            this.buttonLiquidar.Size = new System.Drawing.Size(68, 29);
            this.buttonLiquidar.TabIndex = 17;
            this.buttonLiquidar.Text = "Liquidar";
            this.buttonLiquidar.UseVisualStyleBackColor = false;
            this.buttonLiquidar.Click += new System.EventHandler(this.buttonLiquidar_Click);
            // 
            // textBoxJurosCobrado
            // 
            this.textBoxJurosCobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJurosCobrado.Location = new System.Drawing.Point(1298, 574);
            this.textBoxJurosCobrado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJurosCobrado.Name = "textBoxJurosCobrado";
            this.textBoxJurosCobrado.ReadOnly = true;
            this.textBoxJurosCobrado.Size = new System.Drawing.Size(175, 27);
            this.textBoxJurosCobrado.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1124, 575);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Juros cobrado";
            // 
            // ButtonIncluirLote
            // 
            this.ButtonIncluirLote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonIncluirLote.Location = new System.Drawing.Point(1199, 692);
            this.ButtonIncluirLote.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonIncluirLote.Name = "ButtonIncluirLote";
            this.ButtonIncluirLote.Size = new System.Drawing.Size(68, 29);
            this.ButtonIncluirLote.TabIndex = 20;
            this.ButtonIncluirLote.Text = "Incluir Lote";
            this.ButtonIncluirLote.UseVisualStyleBackColor = false;
            this.ButtonIncluirLote.Click += new System.EventHandler(this.ButtonIncluirLote_Click);
            // 
            // textBoxNumLote
            // 
            this.textBoxNumLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumLote.Location = new System.Drawing.Point(1298, 480);
            this.textBoxNumLote.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumLote.Name = "textBoxNumLote";
            this.textBoxNumLote.ReadOnly = true;
            this.textBoxNumLote.Size = new System.Drawing.Size(40, 27);
            this.textBoxNumLote.TabIndex = 22;
            this.textBoxNumLote.TextChanged += new System.EventHandler(this.textBoxNumLote_TextChanged);
            // 
            // labelLote
            // 
            this.labelLote.AutoSize = true;
            this.labelLote.BackColor = System.Drawing.Color.Transparent;
            this.labelLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLote.ForeColor = System.Drawing.Color.White;
            this.labelLote.Location = new System.Drawing.Point(1124, 479);
            this.labelLote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLote.Name = "labelLote";
            this.labelLote.Size = new System.Drawing.Size(42, 20);
            this.labelLote.TabIndex = 23;
            this.labelLote.Text = "Lote";
            // 
            // textBoxSeq
            // 
            this.textBoxSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSeq.Location = new System.Drawing.Point(1298, 450);
            this.textBoxSeq.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSeq.MaxLength = 5;
            this.textBoxSeq.Name = "textBoxSeq";
            this.textBoxSeq.ReadOnly = true;
            this.textBoxSeq.Size = new System.Drawing.Size(40, 27);
            this.textBoxSeq.TabIndex = 24;
            this.textBoxSeq.Visible = false;
            this.textBoxSeq.TextChanged += new System.EventHandler(this.textBoxSeq_TextChanged);
            // 
            // buttonFecharLote
            // 
            this.buttonFecharLote.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonFecharLote.Location = new System.Drawing.Point(1127, 731);
            this.buttonFecharLote.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFecharLote.Name = "buttonFecharLote";
            this.buttonFecharLote.Size = new System.Drawing.Size(68, 48);
            this.buttonFecharLote.TabIndex = 25;
            this.buttonFecharLote.Text = "Fechar Lote";
            this.buttonFecharLote.UseVisualStyleBackColor = false;
            this.buttonFecharLote.Click += new System.EventHandler(this.buttonFecharLote_Click);
            // 
            // checkBoxContratosAbertos
            // 
            this.checkBoxContratosAbertos.AutoSize = true;
            this.checkBoxContratosAbertos.Location = new System.Drawing.Point(72, 67);
            this.checkBoxContratosAbertos.Name = "checkBoxContratosAbertos";
            this.checkBoxContratosAbertos.Size = new System.Drawing.Size(141, 17);
            this.checkBoxContratosAbertos.TabIndex = 26;
            this.checkBoxContratosAbertos.Text = "Trazer contratos abertos";
            this.checkBoxContratosAbertos.UseVisualStyleBackColor = true;
            this.checkBoxContratosAbertos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonNovaTela
            // 
            this.buttonNovaTela.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonNovaTela.Location = new System.Drawing.Point(1199, 731);
            this.buttonNovaTela.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovaTela.Name = "buttonNovaTela";
            this.buttonNovaTela.Size = new System.Drawing.Size(68, 29);
            this.buttonNovaTela.TabIndex = 27;
            this.buttonNovaTela.Text = "Nova Tela";
            this.buttonNovaTela.UseVisualStyleBackColor = false;
            this.buttonNovaTela.Click += new System.EventHandler(this.buttonNovaTela_Click);
            // 
            // GroupBoxFiltro
            // 
            this.GroupBoxFiltro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBoxFiltro.Controls.Add(this.buttonBuscar);
            this.GroupBoxFiltro.Controls.Add(this.textBoxNumeroCtr);
            this.GroupBoxFiltro.Controls.Add(this.checkBoxContratosAbertos);
            this.GroupBoxFiltro.Controls.Add(this.textBoxNomeCliente);
            this.GroupBoxFiltro.Controls.Add(this.textBoxCodCliente);
            this.GroupBoxFiltro.Controls.Add(this.label1);
            this.GroupBoxFiltro.Controls.Add(this.label2);
            this.GroupBoxFiltro.Controls.Add(this.label3);
            this.GroupBoxFiltro.Location = new System.Drawing.Point(227, 116);
            this.GroupBoxFiltro.Name = "GroupBoxFiltro";
            this.GroupBoxFiltro.Size = new System.Drawing.Size(844, 90);
            this.GroupBoxFiltro.TabIndex = 28;
            this.GroupBoxFiltro.TabStop = false;
            this.GroupBoxFiltro.Text = "Opções de filtro";
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(1759, 821);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 29;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxDataAtual);
            this.groupBox1.Controls.Add(this.textBoxDescrAgencia);
            this.groupBox1.Controls.Add(this.textBoxUnidade);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(1126, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 233);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abrangência";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Agência";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Unidade";
            // 
            // textBoxDataAtual
            // 
            this.textBoxDataAtual.Location = new System.Drawing.Point(100, 167);
            this.textBoxDataAtual.Name = "textBoxDataAtual";
            this.textBoxDataAtual.ReadOnly = true;
            this.textBoxDataAtual.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataAtual.TabIndex = 4;
            // 
            // textBoxDescrAgencia
            // 
            this.textBoxDescrAgencia.Location = new System.Drawing.Point(100, 131);
            this.textBoxDescrAgencia.Name = "textBoxDescrAgencia";
            this.textBoxDescrAgencia.ReadOnly = true;
            this.textBoxDescrAgencia.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescrAgencia.TabIndex = 3;
            // 
            // textBoxUnidade
            // 
            this.textBoxUnidade.Location = new System.Drawing.Point(100, 91);
            this.textBoxUnidade.Name = "textBoxUnidade";
            this.textBoxUnidade.ReadOnly = true;
            this.textBoxUnidade.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnidade.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Empresa";
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(100, 55);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.ReadOnly = true;
            this.textBoxEmpresa.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpresa.TabIndex = 0;
            // 
            // FormLiquidacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1846, 856);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.GroupBoxFiltro);
            this.Controls.Add(this.buttonNovaTela);
            this.Controls.Add(this.buttonFecharLote);
            this.Controls.Add(this.textBoxSeq);
            this.Controls.Add(this.labelLote);
            this.Controls.Add(this.textBoxNumLote);
            this.Controls.Add(this.ButtonIncluirLote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxJurosCobrado);
            this.Controls.Add(this.buttonLiquidar);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxParcela);
            this.Controls.Add(this.textBoxValorPago);
            this.Controls.Add(this.textBoxValorDesconto);
            this.Controls.Add(this.textBoxTotCalculado);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLiquidacao";
            this.Text = "FormLiquidacao";
            this.Load += new System.EventHandler(this.FormLiquidacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBoxFiltro.ResumeLayout(false);
            this.GroupBoxFiltro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumeroCtr;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxCodCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxTotCalculado;
        private System.Windows.Forms.TextBox textBoxValorDesconto;
        private System.Windows.Forms.TextBox textBoxValorPago;
        private System.Windows.Forms.TextBox textBoxParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Button buttonLiquidar;
        private System.Windows.Forms.TextBox textBoxJurosCobrado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonIncluirLote;
        private System.Windows.Forms.TextBox textBoxNumLote;
        private System.Windows.Forms.Label labelLote;
        private System.Windows.Forms.TextBox textBoxSeq;
        private System.Windows.Forms.Button buttonFecharLote;
        private System.Windows.Forms.CheckBox checkBoxContratosAbertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn txJur;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotParc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtVencimento;
        private System.Windows.Forms.Button buttonNovaTela;
        private System.Windows.Forms.GroupBox GroupBoxFiltro;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.TextBox textBoxDescrAgencia;
        private System.Windows.Forms.TextBox textBoxUnidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxEmpresa;
    }
}