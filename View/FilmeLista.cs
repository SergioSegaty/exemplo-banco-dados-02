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
    public partial class FilmeLista : Form
    {
        public FilmeLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            FilmeRepositorio filmRep = new FilmeRepositorio();

            filmRep.Deletar(id);
            AtualizarTabela();
        }


        public void AtualizarTabela()
        {
            FilmeRepositorio repositorio = new FilmeRepositorio();
            List<Filme> filmes = repositorio.ObterTodos();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < filmes.Count; i++)
            {
                Filme filme = filmes[i];
                dataGridView1.Rows.Add(new object[]
                {
                    filme.Id, filme.Nome, filme.Avaliacao, filme.Categoria
                });
            }
        }

        private void btnCadastar_Click(object sender, EventArgs e)
        {
            FilmeCadastro form = new FilmeCadastro();
            form.ShowDialog();
        }

        private void FilmeLista_Activated(object sender, EventArgs e)
        {
            AtualizarTabela();
        }
    }
}
