using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTrocaOleo.Data_Acess
{
    public class UsuarioDAO
    {
        public static DataTable CarregarDados()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.Conexao;
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                SqlCommand cmdo = new SqlCommand();
                cmdo.CommandText = "select * from usuarios";
                cmdo.CommandType = CommandType.Text;
                cmdo.Connection = con;
                SqlDataReader dataReader;
                dataReader = cmdo.ExecuteReader();
                dt.Load(dataReader);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

        }
    }


}

