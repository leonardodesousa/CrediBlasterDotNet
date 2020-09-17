namespace CrediBlaster
{
    partial class FormEfetivaLotes
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
            this.buttonEfetivaLote = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textBoxLoteSelecionado = new System.Windows.Forms.TextBox();
            this.labelLoteSelecionado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEfetivaLote
            // 
            this.buttonEfetivaLote.Location = new System.Drawing.Point(429, 218);
            this.buttonEfetivaLote.Name = "buttonEfetivaLote";
            this.buttonEfetivaLote.Size = new System.Drawing.Size(141, 51);
            this.buttonEfetivaLote.TabIndex = 1;
            this.buttonEfetivaLote.Text = "Efetivar Lote";
            this.buttonEfetivaLote.UseVisualStyleBackColor = true;
            this.buttonEfetivaLote.Click += new System.EventHandler(this.buttonEfetivaLote_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(429, 125);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(141, 51);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(21, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(309, 445);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // textBoxLoteSelecionado
            // 
            this.textBoxLoteSelecionado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLoteSelecionado.Location = new System.Drawing.Point(196, 487);
            this.textBoxLoteSelecionado.Name = "textBoxLoteSelecionado";
            this.textBoxLoteSelecionado.ReadOnly = true;
            this.textBoxLoteSelecionado.Size = new System.Drawing.Size(134, 22);
            this.textBoxLoteSelecionado.TabIndex = 6;
            this.textBoxLoteSelecionado.TextChanged += new System.EventHandler(this.textBoxLoteSelecionado_TextChanged);
            // 
            // labelLoteSelecionado
            // 
            this.labelLoteSelecionado.AutoSize = true;
            this.labelLoteSelecionado.Location = new System.Drawing.Point(46, 487);
            this.labelLoteSelecionado.Name = "labelLoteSelecionado";
            this.labelLoteSelecionado.Size = new System.Drawing.Size(118, 17);
            this.labelLoteSelecionado.TabIndex = 7;
            this.labelLoteSelecionado.Text = "Lote Selecionado";
            // 
            // FormEfetivaLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 564);
            this.Controls.Add(this.labelLoteSelecionado);
            this.Controls.Add(this.textBoxLoteSelecionado);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonEfetivaLote);
            this.Name = "FormEfetivaLotes";
            this.Text = "FormEfetvaLotes";
            this.Load += new System.EventHandler(this.FormEfetivaLotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEfetivaLote;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBoxLoteSelecionado;
        private System.Windows.Forms.Label labelLoteSelecionado;
    }
}