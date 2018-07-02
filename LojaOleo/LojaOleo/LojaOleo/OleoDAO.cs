using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaOleo
{
	public class OleoDAO
	{
		public List<Oleo> CarregarOleos()
		{
			using (SqlConnection conn = new
				SqlConnection(Properties.Settings.Default.conn))
			{
				string strSQL = "select * from Oleo";

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

					List<Oleo> lstOleo = new List<Oleo>();

					foreach (DataRow linha in dt.Rows)
					{
						Oleo oleo = new Oleo();

						oleo.Codigo = Convert.ToInt32(linha["codigo"]);
						oleo.Nome = Convert.ToString(linha["nome"]);
						oleo.Categoria = Convert.ToString(linha["categoria"]);
						oleo.Tipo = Convert.ToString(linha["tipo"]);
						oleo.Fabricante = Convert.ToString(linha["fabricante"]);
						oleo.Valor = Convert.ToDouble(linha["valor"]);


						lstOleo.Add(oleo);
					}

					conn.Close();
					return lstOleo;
				}
			}
		}
	}
}
