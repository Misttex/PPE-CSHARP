using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe3
{
	public class Medicament
	{
		private string _depotlegal;
		private string _nomcommercial;
		private string _composition;
		private string _effets;
		private string _contreindic;
		private string _prixechantillon;


		#region Constructeurs

		public Medicament()
		{
			Depotlegal = Nomcommercial = Composition = Effets = Contreindic = Prixechantillon = "Aucun";
		}

		public Medicament(string depotlegal, string nomcommercial, string composition, string effets, string contreindic, string prixechantillon)
		{
			Depotlegal = depotlegal;
			Nomcommercial = nomcommercial;
			Composition = composition;
			Effets = effets;
			Contreindic = contreindic;
			Prixechantillon = prixechantillon;
		}



		#endregion

		#region Propriétés

		public string Depotlegal { get => _depotlegal; set => _depotlegal = value; }
		public string Nomcommercial { get => _nomcommercial; set => _nomcommercial = value; }
		public string Composition { get => _composition; set => _composition = value; }
		public string Effets { get => _effets; set => _effets = value; }
		public string Contreindic { get => _contreindic; set => _contreindic = value; }
		public string Prixechantillon { get => _prixechantillon; set => _prixechantillon = value; }

		#endregion

	}
}
