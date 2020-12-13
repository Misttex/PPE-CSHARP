using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe3
{
    public class RapportVisite
    {
		private string _numero;
		private string _date;
		private string _bilan;
		private string _motif;
		private int _pra_num;
		private string _vis_matricule;

		#region Constructeurs

		public RapportVisite()
		{
			Numero = Date = Bilan = Motif = Vis_matricule = "Aucun";
			Pra_num = 0;
		}

		public RapportVisite(string numero, string date, string bilan, string motif, int pra_num, string vis_matricule)
		{
			Numero = numero;
			Date = date;
			Bilan = bilan;
			Motif = motif;
			Pra_num = pra_num;
			Vis_matricule = vis_matricule;
		}

		#endregion

		#region Propriétés

		#region Propriétes
		public string Numero { get => _numero; set => _numero = value; }
		public string Date { get => _date; set => _date = value; }
		public string Bilan { get => _bilan; set => _bilan = value; }
		public string Motif { get => _motif; set => _motif = value; }
		public int Pra_num { get => _pra_num; set => _pra_num = value; }
		public string Vis_matricule { get => _vis_matricule; set => _vis_matricule = value; }
		#endregion


		#endregion

	}
}
