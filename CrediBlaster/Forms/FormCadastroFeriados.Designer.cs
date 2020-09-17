namespace CrediBlaster.Forms
{
    partial class FormCadastroFeriados
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxDescricaoFeriado = new System.Windows.Forms.TextBox();
            this.SalvarButton = new System.Windows.Forms.Button();
            this.DescricaoFeriadoGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDataSelecionada = new System.Windows.Forms.TextBox();
            this.groupBoxDataSelecionada = new System.Windows.Forms.GroupBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.DescricaoFeriadoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDataSelecionada.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBoxDescricaoFeriado
            // 
            this.textBoxDescricaoFeriado.Location = new System.Drawing.Point(10, 19);
            this.textBoxDescricaoFeriado.MaxLength = 50;
            this.textBoxDescricaoFeriado.Name = "textBoxDescricaoFeriado";
            this.textBoxDescricaoFeriado.Size = new System.Drawing.Size(248, 20);
            this.textBoxDescricaoFeriado.TabIndex = 1;
            this.textBoxDescricaoFeriado.TextChanged += new System.EventHandler(this.textBoxDescricaoFeriado_TextChanged);
            // 
            // SalvarButton
            // 
            this.SalvarButton.Location = new System.Drawing.Point(428, 366);
            this.SalvarButton.Name = "SalvarButton";
            this.SalvarButton.Size = new System.Drawing.Size(91, 34);
            this.SalvarButton.TabIndex = 2;
            this.SalvarButton.Text = "Salvar";
            this.SalvarButton.UseVisualStyleBackColor = true;
            this.SalvarButton.Click += new System.EventHandler(this.SalvarButton_Click);
            // 
            // DescricaoFeriadoGroupBox
            // 
            this.DescricaoFeriadoGroupBox.Controls.Add(this.textBoxDescricaoFeriado);
            this.DescricaoFeriadoGroupBox.Location = new System.Drawing.Point(65, 284);
            this.DescricaoFeriadoGroupBox.Name = "DescricaoFeriadoGroupBox";
            this.DescricaoFeriadoGroupBox.Size = new System.Drawing.Size(271, 60);
            this.DescricaoFeriadoGroupBox.TabIndex = 3;
            this.DescricaoFeriadoGroupBox.TabStop = false;
            this.DescricaoFeriadoGroupBox.Text = "Descrição do Feriado";
            this.DescricaoFeriadoGroupBox.Enter += new System.EventHandler(this.DescricaoFeriadoGroupBox_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(65, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 229);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma data";
            // 
            // textBoxDataSelecionada
            // 
            this.textBoxDataSelecionada.Location = new System.Drawing.Point(16, 19);
            this.textBoxDataSelecionada.Name = "textBoxDataSelecionada";
            this.textBoxDataSelecionada.Size = new System.Drawing.Size(152, 20);
            this.textBoxDataSelecionada.TabIndex = 5;
            this.textBoxDataSelecionada.TextChanged += new System.EventHandler(this.textBoxDataSelecionada_TextChanged);
            // 
            // groupBoxDataSelecionada
            // 
            this.groupBoxDataSelecionada.Controls.Add(this.textBoxDataSelecionada);
            this.groupBoxDataSelecionada.Location = new System.Drawing.Point(65, 350);
            this.groupBoxDataSelecionada.Name = "groupBoxDataSelecionada";
            this.groupBoxDataSelecionada.Size = new System.Drawing.Size(188, 50);
            this.groupBoxDataSelecionada.TabIndex = 6;
            this.groupBoxDataSelecionada.TabStop = false;
            this.groupBoxDataSelecionada.Text = "Data selecionada";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(549, 366);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(93, 34);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // FormCadastroFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.groupBoxDataSelecionada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DescricaoFeriadoGroupBox);
            this.Controls.Add(this.SalvarButton);
            this.Name = "FormCadastroFeriados";
            this.Text = "FormCadastroFeriados";
            this.DescricaoFeriadoGroupBox.ResumeLayout(false);
            this.DescricaoFeriadoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxDataSelecionada.ResumeLayout(false);
            this.groupBoxDataSelecionada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxDescricaoFeriado;
        private System.Windows.Forms.Button SalvarButton;
        private System.Windows.Forms.GroupBox DescricaoFeriadoGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDataSelecionada;
        private System.Windows.Forms.GroupBox groupBoxDataSelecionada;
        private System.Windows.Forms.Button CancelarButton;
    }
}