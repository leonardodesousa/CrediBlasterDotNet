namespace CrediBlaster
{
    partial class FormTelaPrincipal
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
            this.buttonMovimento = new System.Windows.Forms.Button();
            this.buttonLiquidar = new System.Windows.Forms.Button();
            this.buttonNovaOper = new System.Windows.Forms.Button();
            this.buttonMovimentoLotes = new System.Windows.Forms.Button();
            this.buttonProcessamento = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.CadastrarFeriadosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMovimento
            // 
            this.buttonMovimento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMovimento.Location = new System.Drawing.Point(373, 292);
            this.buttonMovimento.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMovimento.Name = "buttonMovimento";
            this.buttonMovimento.Size = new System.Drawing.Size(90, 52);
            this.buttonMovimento.TabIndex = 0;
            this.buttonMovimento.Text = "Movimento";
            this.buttonMovimento.UseVisualStyleBackColor = false;
            this.buttonMovimento.Click += new System.EventHandler(this.buttonMovimento_Click);
            // 
            // buttonLiquidar
            // 
            this.buttonLiquidar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLiquidar.Location = new System.Drawing.Point(505, 293);
            this.buttonLiquidar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLiquidar.Name = "buttonLiquidar";
            this.buttonLiquidar.Size = new System.Drawing.Size(90, 51);
            this.buttonLiquidar.TabIndex = 1;
            this.buttonLiquidar.Text = "Liquidar ";
            this.buttonLiquidar.UseVisualStyleBackColor = false;
            this.buttonLiquidar.Click += new System.EventHandler(this.buttonLiquidar_Click);
            // 
            // buttonNovaOper
            // 
            this.buttonNovaOper.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonNovaOper.Location = new System.Drawing.Point(630, 293);
            this.buttonNovaOper.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovaOper.Name = "buttonNovaOper";
            this.buttonNovaOper.Size = new System.Drawing.Size(90, 51);
            this.buttonNovaOper.TabIndex = 2;
            this.buttonNovaOper.Text = "Nova Operação";
            this.buttonNovaOper.UseVisualStyleBackColor = false;
            this.buttonNovaOper.Click += new System.EventHandler(this.buttonNovaOper_Click);
            // 
            // buttonMovimentoLotes
            // 
            this.buttonMovimentoLotes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMovimentoLotes.Location = new System.Drawing.Point(740, 293);
            this.buttonMovimentoLotes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMovimentoLotes.Name = "buttonMovimentoLotes";
            this.buttonMovimentoLotes.Size = new System.Drawing.Size(90, 51);
            this.buttonMovimentoLotes.TabIndex = 3;
            this.buttonMovimentoLotes.Text = "Movimento Lotes";
            this.buttonMovimentoLotes.UseVisualStyleBackColor = false;
            this.buttonMovimentoLotes.Click += new System.EventHandler(this.buttonMovimentoLotes_Click);
            // 
            // buttonProcessamento
            // 
            this.buttonProcessamento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonProcessamento.Location = new System.Drawing.Point(855, 293);
            this.buttonProcessamento.Name = "buttonProcessamento";
            this.buttonProcessamento.Size = new System.Drawing.Size(90, 51);
            this.buttonProcessamento.TabIndex = 4;
            this.buttonProcessamento.Text = "Fechamento";
            this.buttonProcessamento.UseVisualStyleBackColor = false;
            this.buttonProcessamento.Click += new System.EventHandler(this.buttonProcessamento_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Red;
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(1762, 834);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarFeriadosButton
            // 
            this.CadastrarFeriadosButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CadastrarFeriadosButton.Location = new System.Drawing.Point(970, 293);
            this.CadastrarFeriadosButton.Name = "CadastrarFeriadosButton";
            this.CadastrarFeriadosButton.Size = new System.Drawing.Size(90, 52);
            this.CadastrarFeriadosButton.TabIndex = 6;
            this.CadastrarFeriadosButton.Text = "Cadastrar Feriados";
            this.CadastrarFeriadosButton.UseVisualStyleBackColor = false;
            this.CadastrarFeriadosButton.Click += new System.EventHandler(this.CadastrarFeriadosButton_Click);
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1849, 869);
            this.Controls.Add(this.CadastrarFeriadosButton);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonProcessamento);
            this.Controls.Add(this.buttonMovimentoLotes);
            this.Controls.Add(this.buttonNovaOper);
            this.Controls.Add(this.buttonLiquidar);
            this.Controls.Add(this.buttonMovimento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTelaPrincipal";
            this.Text = "FormTelaPrincipal";
            this.Load += new System.EventHandler(this.FormTelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMovimento;
        private System.Windows.Forms.Button buttonLiquidar;
        private System.Windows.Forms.Button buttonNovaOper;
        private System.Windows.Forms.Button buttonMovimentoLotes;
        private System.Windows.Forms.Button buttonProcessamento;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button CadastrarFeriadosButton;
    }
}