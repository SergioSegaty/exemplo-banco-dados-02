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
                filme.Duração = Convert.ToDateTime(linha["duracao"]);
                filme.Curtiu = Convert.ToBoolean(linha["curtiu"]);
                filme.Categoria = linha["categoria"].ToString();
                filme.TemSequencia = Convert.ToBoolean(linha["tem_sequencia"]);
                // Adiciona na lista filmes (new List<Filmes>) o filme em i.
                filmes.Add(filme);
            }
            conexao.Close();
            return filmes;
        }
    }
}
