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

        public EditarFilme(Filme filme)
        {
            InitializeComponent();
            txtNome.Text = filme.Nome;
            txtAvaliacao.Text = Convert.ToString(filme.Avaliacao);
            txtDuracao.Text = filme.Duracao.ToString("yyyy-MM-dd hh:mm:ss");
            cbCategoria.Text = filme.Categoria;
            ckbTemSequencia.Checked = filme.TemSequencia;
            lblID.Text = filme.Id.ToString();
            if (filme.Curtiu)
            {
                rbCurtiuSim.Checked = true;
            }
            else
            {
                rbCurtiuNao.Checked = true;
            }

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            Filme filme = new Filme();
            filme.Id = Convert.ToInt32(lblID.Text);

            filme.Nome = txtNome.Text;
            filme.Curtiu = rbCurtiuSim.Checked;
            filme.TemSequencia = ckbTemSequencia.Checked;
            filme.Duracao = Convert.ToDateTime(txtDuracao.Text);
            filme.Avaliacao = Convert.ToDecimal(txtAvaliacao.Text);
            filme.Categoria = cbCategoria.Text;

            FilmeRepositorio repositorio = new FilmeRepositorio();
            repositorio.Atualizar(filme);
            MessageBox.Show("Cadastro atualizado com Sucesso.");
            Close();
        }
    }
}
