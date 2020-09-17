namespace CrediBlaster
{
    partial class FormContratos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataSetCrediblaster = new CrediBlaster.DataSetCrediblaster();
            this.dataSetCrediblasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t402SIMUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t402SIMUTableAdapter = new CrediBlaster.DataSetCrediblasterTableAdapters.T402SIMUTableAdapter();
            this.buttonSimulaParcelas = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.t402OPERTableAdapter1 = new CrediBlaster.DataSetCrediblasterTableAdapters.T402OPERTableAdapter();
            this.t402OPERTableAdapter2 = new CrediBlaster.DataSetCrediblasterTableAdapters.T402OPERTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nr_prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_jur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_jur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vr_tot_prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCtrSelecionado = new System.Windows.Forms.TextBox();
            this.buttonImprimirCtr = new System.Windows.Forms.Button();
            this.buttonEfetivarCtr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonLiquidar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.textBoxDescrAgencia = new System.Windows.Forms.TextBox();
            this.textBoxUnidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCrediblaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCrediblasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t402SIMUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBuscar.Location = new System.Drawing.Point(369, 646);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(106, 39);
            this.buttonBuscar.TabIndex = 0;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataSetCrediblaster
            // 
            this.dataSetCrediblaster.DataSetName = "DataSetCrediblaster";
            this.dataSetCrediblaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetCrediblasterBindingSource
            // 
            this.dataSetCrediblasterBindingSource.DataSource = this.dataSetCrediblaster;
            this.dataSetCrediblasterBindingSource.Position = 0;
            // 
            // t402SIMUBindingSource
            // 
            this.t402SIMUBindingSource.DataMember = "T402SIMU";
            this.t402SIMUBindingSource.DataSource = this.dataSetCrediblasterBindingSource;
            // 
            // t402SIMUTableAdapter
            // 
            this.t402SIMUTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSimulaParcelas
            // 
            this.buttonSimulaParcelas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSimulaParcelas.Location = new System.Drawing.Point(500, 646);
            this.buttonSimulaParcelas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimulaParcelas.Name = "buttonSimulaParcelas";
            this.buttonSimulaParcelas.Size = new System.Drawing.Size(100, 38);
            this.buttonSimulaParcelas.TabIndex = 2;
            this.buttonSimulaParcelas.Text = "Ver parcelas";
            this.buttonSimulaParcelas.UseVisualStyleBackColor = false;
            this.buttonSimulaParcelas.Click += new System.EventHandler(this.buttonSimulaParcelas_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.Location = new System.Drawing.Point(325, 62);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(233, 362);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // t402OPERTableAdapter1
            // 
            this.t402OPERTableAdapter1.ClearBeforeFill = true;
            // 
            // t402OPERTableAdapter2
            // 
            this.t402OPERTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nr_prc,
            this.tx_jur,
            this.vr_jur,
            this.vr_prc,
            this.vr_tot_prc,
            this.dt_venc});
            this.dataGridView1.Location = new System.Drawing.Point(17, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 534);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // nr_prc
            // 
            this.nr_prc.HeaderText = "Parcela";
            this.nr_prc.Name = "nr_prc";
            this.nr_prc.ReadOnly = true;
            // 
            // tx_jur
            // 
            this.tx_jur.HeaderText = "Taxa de Juros (%)";
            this.tx_jur.Name = "tx_jur";
            this.tx_jur.ReadOnly = true;
            // 
            // vr_jur
            // 
            this.vr_jur.HeaderText = "Valor do juros ";
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
            // textBoxCtrSelecionado
            // 
            this.textBoxCtrSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCtrSelecionado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCtrSelecionado.Location = new System.Drawing.Point(475, 550);
            this.textBoxCtrSelecionado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCtrSelecionado.Name = "textBoxCtrSelecionado";
            this.textBoxCtrSelecionado.ReadOnly = true;
            this.textBoxCtrSelecionado.Size = new System.Drawing.Size(102, 27);
            this.textBoxCtrSelecionado.TabIndex = 5;
            this.textBoxCtrSelecionado.TextChanged += new System.EventHandler(this.textBoxCtrSelecionado_TextChanged);
            // 
            // buttonImprimirCtr
            // 
            this.buttonImprimirCtr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonImprimirCtr.Location = new System.Drawing.Point(623, 646);
            this.buttonImprimirCtr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImprimirCtr.Name = "buttonImprimirCtr";
            this.buttonImprimirCtr.Size = new System.Drawing.Size(106, 38);
            this.buttonImprimirCtr.TabIndex = 6;
            this.buttonImprimirCtr.Text = "Imprimir contrato";
            this.buttonImprimirCtr.UseVisualStyleBackColor = false;
            this.buttonImprimirCtr.Click += new System.EventHandler(this.buttonImprimirCtr_Click);
            // 
            // buttonEfetivarCtr
            // 
            this.buttonEfetivarCtr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonEfetivarCtr.Location = new System.Drawing.Point(749, 646);
            this.buttonEfetivarCtr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEfetivarCtr.Name = "buttonEfetivarCtr";
            this.buttonEfetivarCtr.Size = new System.Drawing.Size(106, 38);
            this.buttonEfetivarCtr.TabIndex = 7;
            this.buttonEfetivarCtr.Text = "Efetivar contrato";
            this.buttonEfetivarCtr.UseVisualStyleBackColor = false;
            this.buttonEfetivarCtr.Click += new System.EventHandler(this.buttonEfetivarCtr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(623, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(702, 578);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações de parcelas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(283, 557);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contrato selecionado";
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonVoltar.Location = new System.Drawing.Point(869, 646);
            this.buttonVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(106, 38);
            this.buttonVoltar.TabIndex = 10;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLiquidar
            // 
            this.buttonLiquidar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonLiquidar.Location = new System.Drawing.Point(993, 646);
            this.buttonLiquidar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLiquidar.Name = "buttonLiquidar";
            this.buttonLiquidar.Size = new System.Drawing.Size(106, 37);
            this.buttonLiquidar.TabIndex = 11;
            this.buttonLiquidar.Text = "Liquidar";
            this.buttonLiquidar.UseVisualStyleBackColor = false;
            this.buttonLiquidar.Click += new System.EventHandler(this.buttonLiquidar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxDataAtual);
            this.groupBox2.Controls.Add(this.textBoxDescrAgencia);
            this.groupBox2.Controls.Add(this.textBoxUnidade);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(1395, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 233);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Abrangência";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1725, 737);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 776);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonLiquidar);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEfetivarCtr);
            this.Controls.Add(this.buttonImprimirCtr);
            this.Controls.Add(this.textBoxCtrSelecionado);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonSimulaParcelas);
            this.Controls.Add(this.buttonBuscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormContratos";
            this.Text = "Contratos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCrediblaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCrediblasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t402SIMUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.BindingSource dataSetCrediblasterBindingSource;
        private DataSetCrediblaster dataSetCrediblaster;
        private System.Windows.Forms.BindingSource t402SIMUBindingSource;
        private DataSetCrediblasterTableAdapters.T402SIMUTableAdapter t402SIMUTableAdapter;
        private System.Windows.Forms.Button buttonSimulaParcelas;
        private System.Windows.Forms.TreeView treeView1;
        private DataSetCrediblasterTableAdapters.T402OPERTableAdapter t402OPERTableAdapter1;
        private DataSetCrediblasterTableAdapters.T402OPERTableAdapter t402OPERTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCtrSelecionado;
        private System.Windows.Forms.Button buttonImprimirCtr;
        private System.Windows.Forms.Button buttonEfetivarCtr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonLiquidar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.TextBox textBoxDescrAgencia;
        private System.Windows.Forms.TextBox textBoxUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tx_jur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_jur;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn vr_tot_prc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_venc;
    }
}

