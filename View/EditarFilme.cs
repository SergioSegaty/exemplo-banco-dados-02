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
    public partial class EditarFilme : Form
    {
        public EditarFilme()
        {
            InitializeComponent();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(lblID.Text);

            filme.Nome = txtNome.Text;
            filme.Curtiu = rbCurtiuSim.Checked;
            filme.TemSequencia = ckbTemSequencia.Checked;
            filme.Duracao = Convert.ToDateTime(txtDuracao.Text);
            filme.Avaliacao = Convert.ToDecimal(txtDuracao.Text);
            filme.Categoria = cbCategoria.Text;

            FilmeRepositorio repositorio = new FilmeRepositorio();
            repositorio.Atualizar(filme);
        }
    }
}
