using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FilmeCadastro : Form
    {
        public FilmeCadastro()
        {
            InitializeComponent();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();

            filme.Nome = txtNome.Text;

            filme.Categoria = cbCategoria.Text;

            filme.Duracao = Convert.ToDateTime(txtDuracao.Text);

            filme.Avaliacao = Convert.ToDecimal(txtAvaliacao.Text);

            filme.Curtiu = rbCurtiuSim.Checked;

            if (ckbTemSequencia.Checked)
            {
                filme.TemSequencia = true;
            }
            else
            {
                filme.TemSequencia = false;
            }

            FilmeRepositorio repositorio = new FilmeRepositorio();
            repositorio.Inserir(filme);
            Close();

        }
    }
}
