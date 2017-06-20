using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using Hulptool_Politiek.Models;

namespace Hulptool_Politiek.DAL
{
    class Sql : ISql
    {
        string connectionString = "Server=mssql.fhict.local;Database=dbi365864;User Id=dbi365864;Password=Daan12041999;";

        public List<Election> LoadElections()
        {
            List<Election> elections = new List<Election>();
            string sql = "SELECT * FROM Verkiezing";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        elections.Add(new Election(reader["Naam"].ToString(), (Int32)reader["Zetels"]));
                    }
                }
            }
            return elections;
        }

        public List<ElectionResult> LoadResultsForElection(Election election)
        {
            List<ElectionResult> results = new List<ElectionResult>();
            string sql = "SELECT ur.Stemmen, ur.Percentage, ur.Zetels, ur.Partij, pt.PartijNaam, p.Naam " +
                "FROM UitslagRegel " +
                "ur JOIN Uitslag u on u.UitslagId = ur.UitslagId " +
                "JOIN Verkiezing v on v.VerkiezingId = u.verkiezingId " +
                "JOIN Partij pt on pt.Partij = ur.Partij " +
                "JOIN PoliticusInPartij pip on pip.Partij = ur.Partij " +
                "JOIN Politicus p on p.PoliticusId = pip.PoliticusId " +
                "WHERE v.Naam = @election and pip.Lijsttrekker = 1";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                cmd.Parameters.Add("@election", SqlDbType.VarChar);
                cmd.Parameters["@election"].Value = election.Name;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new ElectionResult(new Party(reader["PartijNaam"].ToString(), reader["Partij"].ToString(), new Politician(reader["Naam"].ToString())), (Int32)reader["Stemmen"], Convert.ToDouble(reader["Percentage"]), (Int32)reader["Zetels"]));
                    }
                }
            }
            return results;
        }
    }
}
