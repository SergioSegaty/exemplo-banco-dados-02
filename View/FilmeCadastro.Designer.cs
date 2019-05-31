namespace View
{
    partial class FilmeCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.llblDuracao = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.rbCurtiuSim = new System.Windows.Forms.RadioButton();
            this.rbCurtiuNao = new System.Windows.Forms.RadioButton();
            this.ckbTemSequencia = new System.Windows.Forms.CheckBox();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.lblCurtiu = new System.Windows.Forms.Label();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(28, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 1;
            // 
            // llblDuracao
            // 
            this.llblDuracao.AutoSize = true;
            this.llblDuracao.Location = new System.Drawing.Point(26, 164);
            this.llblDuracao.Name = "llblDuracao";
            this.llblDuracao.Size = new System.Drawing.Size(48, 13);
            this.llblDuracao.TabIndex = 0;
            this.llblDuracao.Text = "Duração";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(29, 180);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(239, 20);
            this.txtDuracao.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(27, 59);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
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
            this.cbCategoria.Location = new System.Drawing.Point(29, 76);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(193, 21);
            this.cbCategoria.TabIndex = 2;
            // 
            // rbCurtiuSim
            // 
            this.rbCurtiuSim.AutoSize = true;
            this.rbCurtiuSim.Location = new System.Drawing.Point(29, 130);
            this.rbCurtiuSim.Name = "rbCurtiuSim";
            this.rbCurtiuSim.Size = new System.Drawing.Size(42, 17);
            this.rbCurtiuSim.TabIndex = 3;
            this.rbCurtiuSim.TabStop = true;
            this.rbCurtiuSim.Text = "Sim";
            this.rbCurtiuSim.UseVisualStyleBackColor = true;
            // 
            // rbCurtiuNao
            // 
            this.rbCurtiuNao.AutoSize = true;
            this.rbCurtiuNao.Location = new System.Drawing.Point(77, 130);
            this.rbCurtiuNao.Name = "rbCurtiuNao";
            this.rbCurtiuNao.Size = new System.Drawing.Size(45, 17);
            this.rbCurtiuNao.TabIndex = 3;
            this.rbCurtiuNao.TabStop = true;
            this.rbCurtiuNao.Text = "Não";
            this.rbCurtiuNao.UseVisualStyleBackColor = true;
            // 
            // ckbTemSequencia
            // 
            this.ckbTemSequencia.AutoSize = true;
            this.ckbTemSequencia.Location = new System.Drawing.Point(28, 268);
            this.ckbTemSequencia.Name = "ckbTemSequencia";
            this.ckbTemSequencia.Size = new System.Drawing.Size(107, 17);
            this.ckbTemSequencia.TabIndex = 4;
            this.ckbTemSequencia.Text = "Tem Sequencia?";
            this.ckbTemSequencia.UseVisualStyleBackColor = true;
            // 
            // bntSalvar
            // 
            this.bntSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(202)))), ((int)(((byte)(80)))));
            this.bntSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntSalvar.Location = new System.Drawing.Point(92, 317);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(103, 47);
            this.bntSalvar.TabIndex = 5;
            this.bntSalvar.Text = "Salvar";
            this.bntSalvar.UseVisualStyleBackColor = false;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // lblCurtiu
            // 
            this.lblCurtiu.AutoSize = true;
            this.lblCurtiu.Location = new System.Drawing.Point(29, 111);
            this.lblCurtiu.Name = "lblCurtiu";
            this.lblCurtiu.Size = new System.Drawing.Size(40, 13);
            this.lblCurtiu.TabIndex = 6;
            this.lblCurtiu.Text = "Curtiu?";
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.Location = new System.Drawing.Point(25, 215);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(95, 13);
            this.lblAvaliacao.TabIndex = 0;
            this.lblAvaliacao.Text = "Nota de Avaliação";
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Location = new System.Drawing.Point(28, 231);
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(240, 20);
            this.txtAvaliacao.TabIndex = 1;
            // 
            // FilmeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 373);
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
            this.Name = "FilmeCadastro";
            this.Text = "FilmeCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label llblDuracao;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rbCurtiuSim;
        private System.Windows.Forms.RadioButton rbCurtiuNao;
        private System.Windows.Forms.CheckBox ckbTemSequencia;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.Label lblCurtiu;
        private System.Windows.Forms.Label lblAvaliacao;
        private System.Windows.Forms.TextBox txtAvaliacao;
    }
}