using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOleo
{
	public static class UsuarioDAO
	{
		public static Usuario Logar(Usuario obj)
		{
			using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn))
			{
				string strSQL = "select email, senha from Usuario " +
					"where email = @email or senha = @senha";

				DataTable dt = new DataTable();
				conn.Open();

				using (SqlCommand cmdo = new SqlCommand(strSQL))
				{
					cmdo.CommandType = CommandType.Text;
					cmdo.Connection = conn;
					cmdo.CommandText = strSQL;

					cmdo.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
					cmdo.Parameters.Add("@senha", SqlDbType.VarChar).Value = obj.Senha;

					SqlDataReader dataReader;
					dataReader = cmdo.ExecuteReader();
					dt.Load(dataReader);

					if (!(dt != null && dt.Rows.Count > 0))
						return null;

					var row = dt.Rows[0];
					var usuario = new Usuario()
					{
						Email = row["email"].ToString(),
						Senha = row["senha"].ToString()
					};

					conn.Close();
					return usuario;
				}
			}
		}
	}
}
