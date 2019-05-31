using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repositorio
{
    public class FilmeRepositorio
    {
        string CadeiaDeConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\62110\Documents\ExemploBancoDados02.mdf;Integrated Security=True;Connect Timeout=30";

        /*
         Metódo que irá retornar os dados do filme (List<Filme>), da tabela  de filmes. 
         */
        public List<Filme> ObterTodos()
        {
            /*
             * Cria a conexão com o banco de dados. 
             * 
             * Lembrar de abrir e fechar a mesma.
             */

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();


            // Cria o comando para ser Executado no BD
            // E diz para este comando qual é a conexão que esta aberta ( e em uso )

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM filmes";


            // Cria uma tabela em memória para conter os dados que são retornados do BD
            // E Executa os comandos no BD
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            List<Filme> filmes = new List<Filme>();

            for (int i = 0; i < tabela.Rows.Count; i++)
            {

                // Cria uma Row, que recebe as Rows da tabela criada antes. E jã instancia a row na Linha.
                DataRow linha = tabela.Rows[i];
                Filme filme = new Filme();

                // Declarando as Variaveis.
                filme.Id = Convert.ToInt32(linha["id"]);
                filme.Nome = linha["nome"].ToString();
                filme.Avaliacao = Convert.ToDecimal(linha["avaliacao"]);
                filme.Duracao = Convert.ToDateTime(linha["duracao"]);
                filme.Curtiu = Convert.ToBoolean(linha["curtiu"]);
                filme.Categoria = linha["categoria"].ToString();
                filme.TemSequencia = Convert.ToBoolean(linha["tem_sequencia"]);
                // Adiciona na lista filmes (new List<Filmes>) o filme em i.
                filmes.Add(filme);
            }
            return filmes;
        }

        public Filme ObterPeloID(int id)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"SELECT * FROM filmes 
            WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            conexao.Close();

            if (tabela.Rows.Count == 1)
            {
                DataRow linha = tabela.Rows[0];
                Filme filme = new Filme();
                filme.Id = Convert.ToInt32(linha["id"]);
                filme.Nome = linha["nome"].ToString();
                filme.Avaliacao = Convert.ToInt32(linha["avaliacao"]);
                filme.Duracao = Convert.ToDateTime(linha["duracao"]);
                filme.Categoria = linha["categoria"].ToString();
                filme.Curtiu = Convert.ToBoolean(linha["curtiu"]);
                filme.TemSequencia = Convert.ToBoolean(linha["tem_sequencia"]);
                return filme;
            }

            return null;
        }

        public void Inserir(Filme filme)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = CadeiaDeConexao;
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO filmes 
            (nome, categoria, curtiu, duracao, avaliacao, tem_senquencia)

            Values
            (@NOME, @CATEGORIA, @CURTIU, @DURACAO, @AVALIACAO, @TEM_SEQUENCIA)";

            comando.Parameters.AddWithValue("@NOME", filme.Nome);
            comando.Parameters.AddWithValue("@CATEGORIA", filme.Categoria);
            comando.Parameters.AddWithValue("@CURTIU", filme.Curtiu);
            comando.Parameters.AddWithValue("@DURACAO", filme.Duracao);
            comando.Parameters.AddWithValue("@AVALIACAO", filme.Avaliacao);
            comando.Parameters.AddWithValue("@TEM_SEQUENCIA", filme.TemSequencia);

            comando.ExecuteNonQuery();
            conexao.Close();


        }
    }
}
