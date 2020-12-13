using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ppe3;
using Persistance;

namespace DAO
{
	public class DAOPraticien
	{

		///<summary>
		///Fournit la liste de tous les rapportvisites.
		///</summary>
		///<returns>
		///Une collection (list) de rapportvisites
		///</returns>
		public static List<Praticien> GetPraticien()
		{
			//Collection de rapportvisite qui sera retournée à la couche présentation.
			//Cette dernière ne doit travailler qu'avec des objets métiers.
			List<Praticien> praticien = null;
			//La requête à exécuter pour sélectionner tous les rapportvisites
			string selectPraticien = "SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE FROM praticien";
			//On appelle la couche persistance pour faire exécuter la requête. On exécute la méthode statique Select de la classe DBInterface
			//Rappel : la méthode Select retourne un datatable
			DataTable dataTable = DBInterface.Select(selectPraticien);
			//Le Datatable retourné est transformé en collection de rapportvisite
			if (dataTable != null)
			{
				praticien = new List<Praticien>();
				foreach (DataRow row in dataTable.Rows)
				{
					Praticien praticiens = CreerPraticien(row);
					praticien.Add(praticiens);
				}
			}
			return praticien;
		}

		//Construction d'une instance de rapportvisite à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static Praticien CreerPraticien(DataRow row)
		{
			Praticien praticien= new Praticien();
			praticien.Num = row["PRA_NUM"].ToString();
			praticien.Nom = row["PRA_NOM"].ToString();
			praticien.Prenom = row["PRA_PRENOM"].ToString();
			praticien.Adresse = row["PRA_ADRESSE"].ToString();
			praticien.Cp = row["PRA_CP"].ToString();
			praticien.Ville = row["PRA_VILLE"].ToString();
			praticien.Coefnotoriete = row["PRA_COEFNOTORIETE"].ToString();
			return praticien;
		}

		public static Praticien GetPraticienNomPrenom(string nom, string prenom)
		{
			Praticien praticien = null;
			string selectPraticien = "SELECT PRA_NUM, PRA_NOM, PRA_PRENOM, PRA_ADRESSE, PRA_CP, PRA_VILLE, PRA_COEFNOTORIETE, TYP_CODE FROM PRATICIEN WHERE PRA_NOM='" + nom + "' AND PRA_PRENOM='" + prenom + "'";
			DataTable dataTable = DBInterface.Select(selectPraticien);
			if (dataTable.Rows.Count != 0)
			{
				DataRow row = dataTable.Rows[0];
				praticien = CreerPraticien(row);
			}

			return praticien;
		}
	}
}
