using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleTrocaOleo
{
    public partial class frmControleTroca : Form
    {
        public frmControleTroca()
        {
            InitializeComponent();

        }

        //CRIAR A CONEXÃO

        private SqlConnection CriarConexao()
        {
            return new SqlConnection("Provider=SQLNCLI11;Data Source=LAPTOP-SMVO19P1;Integrated Security=SSPI;Initial Catalog=trabalhoLuis");
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
                // criar conexão
                SqlConnection sqlConnection = CriarConexao();
                //abrir conexao
                sqlConnection.Open();
                //Criar o comando que vai até o banco 
                SqlCommand sqlcommand = sqlConnection.CreateCommand();
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

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmControleTroca_Load(object sender, EventArgs e)
        {
            //criar um DataTable
            DataTable dtTabelas = new DataTable();

            //definir a string de conexao
            String strConn = @"Data Source=LAPTOP-SMVO19P1;Integrated Security=SSPI;Initial Catalog=trabalhoLuis";

            //define a conexao
            SqlConnection conn = new SqlConnection(strConn);

            //criar um adaptador
            SqlDataAdapter da = new SqlDataAdapter("select * from oleos", conn);

            dtTabelas.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cmbOleo.DataSource = null;

            //preenche o DataTable
            da.Fill(dtTabelas);

            //carrega as informacoes no combo
            cmbOleo.DataSource = dtTabelas;
            cmbOleo.DisplayMember = "Nome do Oléo"; // <- nome do campo que será exibido para o usuario
            cmbOleo.ValueMember = "nome"; // <- valor que voce pode jogar no textbox
            cmbOleo.SelectedItem = "";
            cmbOleo.Refresh();

            cmbCategoria.DataSource = dtTabelas;
            cmbCategoria.DisplayMember = "Nome da Categoria"; // <- nome do campo que será exibido para o usuario
            cmbCategoria.ValueMember = "categoria"; // <- valor que voce pode jogar no textbox
            cmbCategoria.SelectedItem = "";
            cmbCategoria.Refresh();

            cmbTipo.DataSource = dtTabelas;
            cmbTipo.DisplayMember = "Tipo do Óleo"; // <- nome do campo que será exibido para o usuario
            cmbTipo.ValueMember = "tipo"; // <- valor que voce pode jogar no textbox
            cmbTipo.SelectedItem = "";
            cmbTipo.Refresh();

            cmbFabricante.DataSource = dtTabelas;
            cmbFabricante.DisplayMember = "Fabricante do Óleo"; // <- nome do campo que será exibido para o usuario
            cmbFabricante.ValueMember = "fabricante"; // <- valor que voce pode jogar no textbox
            cmbFabricante.SelectedItem = "";
            cmbFabricante.Refresh();

            //criar um adaptador para cliente
            SqlDataAdapter da_cli = new SqlDataAdapter("select * from clientes", conn);

            //criar um DataTable
            DataTable dtCli = new DataTable();

            dtCli.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cmbCliente.DataSource = null;

            //preenche o DataTable
            da_cli.Fill(dtCli);

            cmbCliente.DataSource = dtCli;
            cmbCliente.DisplayMember = "Nome do Cliente"; // <- nome do campo que será exibido para o usuario
            cmbCliente.ValueMember = "nome"; // <- valor que voce pode jogar no textbox
            cmbCliente.SelectedItem = "";
            cmbCliente.Refresh();



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //.SelectedIndex = -1 foi usado para Limpar os campos do combobox, funciona porque joga um indice negativo
            cmbCliente.SelectedIndex = -1;
            cmbOleo.SelectedIndex = -1;
            cmbFabricante.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            txtValorLitro.Clear();
            txtQtdLitro.Clear();
            txtVlrTotal.Clear();
            txtEmailCliente.Clear();
            dtpDataTroca.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Conexao;

            try
            {
                con.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.CommandType = CommandType.Text;
                cmdo.Connection = con;
                cmdo.CommandText = "insert into controleTroca(data_troca, nome_cliente, nome_oleo, categoria_oleo, tipo_oleo, fabricante, valor_oleo, qtd_oleo, vlr_total, email_cliente) " +
                "values (@data, @nome_cli, @nome_ole, @cat_ole, @tp_oleo, @fabricante, @vlr_oleo, @qtd_oleo, @vlrtotal, @email_cli)";

                cmdo.Parameters.Clear();
                cmdo.Parameters.Add("@data", SqlDbType.DateTime).Value = dtpDataTroca.Value;
                cmdo.Parameters.Add("@nome_cli", SqlDbType.VarChar, 100).Value = cmbCliente.Text;
                cmdo.Parameters.Add("@nome_ole", SqlDbType.VarChar, 100).Value = cmbOleo.Text;
                cmdo.Parameters.Add("@cat_ole", SqlDbType.VarChar, 100).Value = cmbCategoria.Text;
                cmdo.Parameters.Add("@tp_oleo", SqlDbType.VarChar, 100).Value = cmbTipo.Text;
                cmdo.Parameters.Add("@fabricante", SqlDbType.VarChar, 100).Value = cmbFabricante.Text;
                cmdo.Parameters.Add("@vlr_oleo", SqlDbType.Decimal).Value = txtValorLitro.Text;
                cmdo.Parameters.Add("@qtd_oleo", SqlDbType.Decimal).Value = txtQtdLitro.Text;
                cmdo.Parameters.Add("@vlrtotal", SqlDbType.Decimal).Value = txtVlrTotal.Text;
                cmdo.Parameters.Add("@email_cli", SqlDbType.VarChar, 100).Value = txtEmailCliente.Text;

                cmdo.ExecuteNonQuery();

                //   CarregarDados();
                MessageBox.Show("Dados Iseridos com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível inserir dos dados: "
                    + erro.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void dtpDataTroca_ValueChanged(object sender, EventArgs e)
        {
            //variavel data recebendo o datetime now para comparar no if de validação com a data escolhida
            DateTime data = DateTime.Now;

            DateTime dataDTP = dtpDataTroca.Value.Date;

            if (dataDTP < data.Date)
            {
                // beleza continua o programa
            }
            else
            {
                MessageBox.Show("Data errada, não aceita data futura, confira o dia!");
            }

        }
    }
}
