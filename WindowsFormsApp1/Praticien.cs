using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe3
{
	public class Praticien
	{
		private string _num;
		private string _nom;
		private string _prenom;
		private string _adresse;
		private string _cp;
		private string _ville;
		private string _coefnotoriete;


		#region Constructeurs

		public Praticien()
		{
			Num = Nom = Prenom = Adresse = Cp = Ville = Coefnotoriete = "Aucun";
		}

		public Praticien(string num, string nom, string prenom, string adresse, string cp, string ville, string coefnotoriete)
		{
			Num = num;
			Nom = nom;
			Prenom = prenom;
			Adresse = adresse;
			Cp = cp;
			Ville = ville;
			Coefnotoriete = coefnotoriete;
		}

		#endregion

		#region Propriétés

		public string Num { get => _num; set => _num = value; }
		public string Nom { get => _nom; set => _nom = value; }
		public string Prenom { get => _prenom; set => _prenom = value; }
		public string Adresse { get => _adresse; set => _adresse = value; }
		public string Cp { get => _cp; set => _cp = value; }
		public string Ville { get => _ville; set => _ville = value; }
		public string Coefnotoriete { get => _coefnotoriete; set => _coefnotoriete = value; }

		#endregion

	}
}
