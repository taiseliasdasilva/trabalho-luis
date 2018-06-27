using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// USING PARA ACESSO A DADOS
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ControleTrocaOleo.Data_Acess
{
    public class AcessoDados
    {
        //CRIAR A CONEXÃO

        private SqlConnection CriarConexao()
        {
            return new SqlConnection("String de Conexão");
        }

        // Parametros  que irão para o banco de dados
        SqlParameterCollection SqlParameterCollection = new SqlCommand().Parameters;


        public void LimparParametros()
        {
            SqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            SqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        // Persistencia - inserir, alterar, excluir.

        public object ExecutarPercistencia(CommandType commandType, string textoSql)
        {
            try
            {
                //criar conexao

                SqlConnection sqlConnection = CriarConexao();
                //abrir a conexao 
                sqlConnection.Open();
                //Criar o comando que vai levar as informacoes ate o banco 
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //colocar as coisas dentro do comando 
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = textoSql;
                sqlCommand.CommandTimeout = 3600;

                foreach (SqlParameter sqlParameter in SqlParameterCollection)
                {

                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //executar o comando 

                return sqlCommand.ExecuteScalar();

            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public DataTable ExecutarConsulta(CommandType commandType, string textoSql)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.Conexao;

                //abrir conexao
                con.Open();
                //Criar o comando que vai até o banco 
                SqlCommand sqlcommand = con.CreateCommand();
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = textoSql;
                sqlcommand.CommandTimeout = 3600;

                //adicionar os parametros
                foreach (SqlParameter sqlParameter in SqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //CRIAR UM ADAPTADOR 

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
