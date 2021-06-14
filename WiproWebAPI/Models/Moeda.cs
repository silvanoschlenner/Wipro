using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WiproWebAPI.Utils;

namespace WiproWebAPI.Models
{
    public class Moeda
    {
		public int Id { get; set; }
		public string DsMoeda{ get; set; }
		public string DtInicio { get; set; }
		public string DtFim { get; set; }

		public void AddItemFila()
		{
			Dal objDal = new Dal();
			string sql = "INSERT INTO moedas(dsMoeda, dtInicio, dtFim) " +
				$"values('{DsMoeda}','{DateTime.Parse(DtInicio).ToString("yyyy/MM/dd")}'," +
				$"'{DateTime.Parse(DtFim).ToString("yyyy/MM/dd")}')";
			objDal.ExecutarComandoSQL(sql);
		}

		public Moeda GetItemFila()
		{
			Moeda item;

			Dal objDal = new Dal();
			string sql = "SELECT * FROM moedas WHERE idMoeda = (SELECT MAX(idMoeda) FROM moedas)";
			DataTable dados = objDal.RetornarDataTable(sql);
			if (dados.Rows.Count == 0)
			{
				item = new Moeda()
				{
					Id = 0,
					DsMoeda = "Moeda não Cadastrada",
					DtInicio = " ",
					DtFim = " "
				};
			}
			else
			{
				item = new Moeda()
				{
					Id = int.Parse(dados.Rows[0]["idMoeda"].ToString()),
					DsMoeda = dados.Rows[0]["dsMoeda"].ToString(),
					DtInicio = DateTime.Parse(dados.Rows[0]["dtInicio"].ToString()).ToString("dd/MM/yyyy"),
					DtFim = DateTime.Parse(dados.Rows[0]["dtFim"].ToString()).ToString("dd/MM/yyyy")
				};
				string sqlDel = "DELETE FROM moedas WHERE idMoeda = " + int.Parse(dados.Rows[0]["idMoeda"].ToString());
				objDal.ExecutarComandoSQL(sqlDel);
			};

			return item;
		}
	}
}
