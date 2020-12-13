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
	public class DAORapportVisite
	{

		///<summary>
		///Fournit la liste de tous les rapportvisites.
		///</summary>
		///<returns>
		///Une collection (list) de rapportvisites
		///</returns>
		public static List<RapportVisite> GetRapportVisite()
		{
			//Collection de rapportvisite qui sera retournée à la couche présentation.
			//Cette dernière ne doit travailler qu'avec des objets métiers.
			List<RapportVisite> rapportvisite = null;
			//La requête à exécuter pour sélectionner tous les rapportvisites
			string selectRapportVisite = "SELECT RAP_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF, PRA_NUM, VIS_MATRICULE FROM rapportvisite";
			//On appelle la couche persistance pour faire exécuter la requête. On exécute la méthode statique Select de la classe DBInterface
			//Rappel : la méthode Select retourne un datatable
			DataTable dataTable = DBInterface.Select(selectRapportVisite);
			//Le Datatable retourné est transformé en collection de rapportvisite
			if (dataTable != null)
			{
				rapportvisite = new List<RapportVisite>();
				foreach (DataRow row in dataTable.Rows)
				{
					RapportVisite rapportsvisites = CreerRapportVisite(row);
					rapportvisite.Add(rapportsvisites);
				}
			}
			return rapportvisite;
		}

		//Construction d'une instance de rapportvisite à partir d'une ligne du résultat de la requête.
		//Rappel : on souhaite que la couche "Présentation" ne soit pas liée à la base de données.
		//Elle ne doit travailler qu'avec des objets métiers.
		private static RapportVisite CreerRapportVisite(DataRow row)
		{
			RapportVisite rapportvisite = new RapportVisite();
			rapportvisite.Numero = row["RAP_NUM"].ToString();
			rapportvisite.Date = row["RAP_DATE"].ToString();
			rapportvisite.Bilan = row["RAP_BILAN"].ToString();
			rapportvisite.Motif = row["RAP_MOTIF"].ToString();
			rapportvisite.Pra_num = int.Parse(row["PRA_NUM"].ToString());
			rapportvisite.Vis_matricule = row["VIS_MATRICULE"].ToString();
			return rapportvisite;
		}

		public static Boolean CreateRapport(RapportVisite rapport)
		{
			RapportVisite nouveauRapport = null;
			string createRapport = "INSERT INTO RAPPORTVISITE VALUES ('" + rapport.Numero + "', '" + rapport.Date + "', '" + rapport.Bilan + "', '" + rapport.Motif + "', '" + rapport.Pra_num + "', '" + rapport.Vis_matricule + "');";
			DBInterface.Update(createRapport);
			int updatedRows = DBInterface.Update(createRapport);
			if (updatedRows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static Boolean UpdateRapport(RapportVisite rapport)
		{
			string updateRapport = "UPDATE RAPPORTVISITE SET RAP_DATE='" + rapport.Date + "', RAP_BILAN='" + rapport.Bilan + "', RAP_MOTIF='" + rapport.Motif + "', PRA_NUM='" + rapport.Pra_num.ToString() + "' WHERE RAP_NUM='" + rapport.Numero + "';";
			int updatedRows = DBInterface.Update(updateRapport);
			if (updatedRows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
