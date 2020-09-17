namespace CrediBlaster.Forms
{
    partial class Processamento
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridLotes = new System.Windows.Forms.DataGridView();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cdCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtAmo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCtr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txJur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrOri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrLiq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataAtual = new System.Windows.Forms.TextBox();
            this.textBoxDescrAgencia = new System.Windows.Forms.TextBox();
            this.textBoxUnidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView1.Location = new System.Drawing.Point(29, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(225, 198);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeView2.Location = new System.Drawing.Point(22, 28);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(232, 192);
            this.treeView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotes Pendentes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.treeView2);
            this.groupBox2.Location = new System.Drawing.Point(38, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações Pendentes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // GridLotes
            // 
            this.GridLotes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.GridLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contrato,
            this.cliente,
            this.Parcela,
            this.desconto,
            this.Valor,
            this.tipo_lote});
            this.GridLotes.Location = new System.Drawing.Point(349, 49);
            this.GridLotes.Name = "GridLotes";
            this.GridLotes.Size = new System.Drawing.Size(648, 198);
            this.GridLotes.TabIndex = 4;
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // Parcela
            // 
            this.Parcela.HeaderText = "Parcela";
            this.Parcela.Name = "Parcela";
            this.Parcela.ReadOnly = true;
            // 
            // desconto
            // 
            this.desconto.HeaderText = "desconto";
            this.desconto.Name = "desconto";
            this.desconto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // tipo_lote
            // 
            this.tipo_lote.HeaderText = "Tipo do lote";
            this.tipo_lote.Name = "tipo_lote";
            this.tipo_lote.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdCli,
            this.qtAmo,
            this.nrCtr,
            this.txJur,
            this.VrOri,
            this.vrLiq,
            this.nmCli});
            this.dataGridView1.Location = new System.Drawing.Point(349, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 159);
            this.dataGridView1.TabIndex = 5;
            // 
            // cdCli
            // 
            this.cdCli.HeaderText = "Cliente";
            this.cdCli.Name = "cdCli";
            this.cdCli.ReadOnly = true;
            // 
            // qtAmo
            // 
            this.qtAmo.HeaderText = "Parcelas";
            this.qtAmo.Name = "qtAmo";
            // 
            // nrCtr
            // 
            this.nrCtr.HeaderText = "Contrato";
            this.nrCtr.Name = "nrCtr";
            this.nrCtr.ReadOnly = true;
            // 
            // txJur
            // 
            this.txJur.HeaderText = "Taxa de Juros";
            this.txJur.Name = "txJur";
            this.txJur.ReadOnly = true;
            // 
            // VrOri
            // 
            this.VrOri.HeaderText = "Valor Original";
            this.VrOri.Name = "VrOri";
            this.VrOri.ReadOnly = true;
            // 
            // vrLiq
            // 
            this.vrLiq.HeaderText = "Total";
            this.vrLiq.Name = "vrLiq";
            this.vrLiq.ReadOnly = true;
            // 
            // nmCli
            // 
            this.nmCli.HeaderText = "Nome";
            this.nmCli.Name = "nmCli";
            this.nmCli.ReadOnly = true;
            // 
            // buttonProcess
            // 
            this.buttonProcess.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(865, 582);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(101, 45);
            this.buttonProcess.TabIndex = 6;
            this.buttonProcess.Text = "Processar";
            this.buttonProcess.UseVisualStyleBackColor = false;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAtualizar.Location = new System.Drawing.Point(758, 582);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(101, 45);
            this.buttonAtualizar.TabIndex = 9;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.BackColor = System.Drawing.Color.Red;
            this.buttonVoltar.ForeColor = System.Drawing.Color.White;
            this.buttonVoltar.Location = new System.Drawing.Point(1727, 824);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 10;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = false;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxDataAtual);
            this.groupBox3.Controls.Add(this.textBoxDescrAgencia);
            this.groupBox3.Controls.Add(this.textBoxUnidade);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxEmpresa);
            this.groupBox3.Location = new System.Drawing.Point(1088, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 233);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Abrangência";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            // Processamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1814, 859);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GridLotes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Processamento";
            this.Text = "Processamento";
            this.Load += new System.EventHandler(this.Processamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridLotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_lote;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtAmo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn txJur;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrOri;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrLiq;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmCli;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDataAtual;
        private System.Windows.Forms.TextBox textBoxDescrAgencia;
        private System.Windows.Forms.TextBox textBoxUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmpresa;
    }
}