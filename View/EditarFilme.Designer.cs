namespace View
{
    partial class EditarFilme
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
            this.lblCurtiu = new System.Windows.Forms.Label();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.rbCurtiuNao = new System.Windows.Forms.RadioButton();
            this.rbCurtiuSim = new System.Windows.Forms.RadioButton();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.llblDuracao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurtiu
            // 
            this.lblCurtiu.AutoSize = true;
            this.lblCurtiu.Location = new System.Drawing.Point(26, 140);
            this.lblCurtiu.Name = "lblCurtiu";
            this.lblCurtiu.Size = new System.Drawing.Size(40, 13);
            this.lblCurtiu.TabIndex = 19;
            this.lblCurtiu.Text = "Curtiu?";
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(202)))), ((int)(((byte)(80)))));
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvar.Location = new System.Drawing.Point(89, 346);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(103, 47);
            this.bntSalvar.TabIndex = 18;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Location = new System.Drawing.Point(25, 297);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(107, 17);
            this.ckbTemSequencia.TabIndex = 17;
            this.ckbTemSequencia.Text = "Tem Sequencia?";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // rbCurtiuNao
            // 
            this.rbCurtiuNao.AutoSize = true;
            this.rbCurtiuNao.Location = new System.Drawing.Point(74, 159);
            this.rbCurtiuNao.Name = "rbCurtiuNao";
            this.rbCurtiuNao.Size = new System.Drawing.Size(45, 17);
            this.rbCurtiuNao.TabIndex = 15;
            this.rbCurtiuNao.TabStop = true;
            this.rbCurtiuNao.Text = "Não";
            this.rbCurtiuNao.UseVisualStyleBackColor = true;
            // 
            // rbCurtiuSim
            // 
            this.rbCurtiuSim.AutoSize = true;
            this.rbCurtiuSim.Location = new System.Drawing.Point(26, 159);
            this.rbCurtiuSim.Name = "rbCurtiuSim";
            this.rbCurtiuSim.Size = new System.Drawing.Size(42, 17);
            this.rbCurtiuSim.TabIndex = 16;
            this.rbCurtiuSim.TabStop = true;
            this.rbCurtiuSim.Text = "Sim";
            this.rbCurtiuSim.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Infantil",
            "Terror",
            "Aventura",
            "Ação",
            "Mistério",
            "Suspense",
            "Thriller",
            "Romance"});
            this.cbCategoria.Location = new System.Drawing.Point(26, 105);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(193, 21);
            this.cbCategoria.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(24, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(25, 260);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(240, 20);
            this.txtAvaliacao.TabIndex = 11;
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Location = new System.Drawing.Point(22, 244);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(95, 13);
            this.lblAvaliacao.TabIndex = 8;
            this.lblAvaliacao.Text = "Nota de Avaliação";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(26, 209);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(239, 20);
            this.txtDuracao.TabIndex = 12;
            // 
            // llblDuracao
            // 
            this.llblDuracao.AutoSize = true;
            this.llblDuracao.Location = new System.Drawing.Point(23, 193);
            this.llblDuracao.Name = "llblDuracao";
            this.llblDuracao.Size = new System.Drawing.Size(48, 13);
            this.llblDuracao.TabIndex = 9;
            this.llblDuracao.Text = "Duração";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 20;
            this.lblCodigo.Text = "Código:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(65, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 20;
            this.lblID.Text = "0";
            // 
            // EditarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 405);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCurtiu);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.ckbTemSequencia);
            this.Controls.Add(this.rbCurtiuNao);
            this.Controls.Add(this.rbCurtiuSim);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtAvaliacao);
            this.Controls.Add(this.lblAvaliacao);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.llblDuracao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "EditarFilme";
            this.Text = "EditarFilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurtiu;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.RadioButton rbCurtiuNao;
        private System.Windows.Forms.RadioButton rbCurtiuSim;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label llblDuracao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblID;
    }
}