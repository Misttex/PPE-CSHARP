using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe3
{
	public class Visiteur
	{
		private string _matricule;
		private string _nom;
		private string _prenom;
		private string _adresse;
		private string _cp;
		private string _ville;
		private string _dateembauche;


		#region Constructeurs

		public Visiteur()
		{
			Matricule = Nom = Prenom = Adresse = Cp = Ville = Dateembauche = "Aucun";
		}

		public Visiteur(string matricule, string nom, string prenom, string adresse, string cp, string ville, string dateembauche)
		{
			Matricule = matricule;
			Nom = nom;
			Prenom = prenom;
			Adresse = adresse;
			Cp = cp;
			Ville = ville;
		}


		#endregion

		#region Propriétés

		public string Matricule { get => _matricule; set => _matricule = value; }
		public string Nom { get => _nom; set => _nom = value; }
		public string Prenom { get => _prenom; set => _prenom = value; }
		public string Adresse { get => _adresse; set => _adresse = value; }
		public string Cp { get => _cp; set => _cp = value; }
		public string Ville { get => _ville; set => _ville = value; }
		public string Dateembauche { get => _dateembauche; set => _dateembauche = value; }

		#endregion

	}
}
