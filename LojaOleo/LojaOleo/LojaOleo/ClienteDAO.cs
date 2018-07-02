using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOleo
{
	public class ClienteDAO
	{
		public List<Cliente> CarregarClientes()
		{
			using (SqlConnection conn = new
				SqlConnection(Properties.Settings.Default.conn))
			{
				string strSQL = "select * from Cliente";

				DataTable dt = new DataTable();
				conn.Open();

				using (SqlCommand cmdo = new SqlCommand())
				{
					cmdo.CommandType = CommandType.Text;
					cmdo.Connection = conn;
					cmdo.CommandText = strSQL;

					SqlDataReader dataReader;
					dataReader = cmdo.ExecuteReader();
					dt.Load(dataReader);

					if (!(dt != null && dt.Rows.Count > 0))
						return null;

					List<Cliente> lstCliente = new List<Cliente>();

					foreach (DataRow linha in dt.Rows)
					{
						Cliente cliente = new Cliente();

						cliente.Codigo = Convert.ToInt32(linha["codigo"]);
						cliente.Nome = Convert.ToString(linha["nome"]);
						cliente.Veiculo = Convert.ToString(linha["veiculo"]);
						cliente.Placa = Convert.ToString(linha["placa"]);
						cliente.Email = Convert.ToString(linha["email"]);

						lstCliente.Add(cliente);
					}

					conn.Close();
					return lstCliente;
				}
			}
		}
	}
}
