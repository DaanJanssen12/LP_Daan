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

        public List<Party> LoadAllParties()
        {
            List<Party> parties = new List<Party>();
            string sql = "SELECT p.Naam, p.PoliticusId, pt.PartijId, pt.Partij, pt.PartijNaam " +
                "FROM Partij pt " +
                "JOIN PoliticusInPartij pip on pt.PartijId = pip.PartijId " +
                "JOIN Politicus p on pip.PoliticusId = p.PoliticusId " +
                "WHERE Lijsttrekker = 1 ";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        parties.Add(new Party(reader["PartijNaam"].ToString(), reader["Partij"].ToString(), new Politician(reader["Naam"].ToString(), (Int32)reader["PoliticusId"]), (Int32)reader["PartijId"]));
                    }
                }
            }
            return parties;
        }

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
            string sql = "SELECT ur.UitslagId, ur.Stemmen, ur.Percentage, ur.Zetels, pt.Partij, pt.PartijId, pt.PartijNaam, p.Naam, p.PoliticusId " +
                "FROM UitslagRegel " +
                "ur JOIN Uitslag u on u.UitslagId = ur.UitslagId " +
                "JOIN Verkiezing v on v.VerkiezingId = u.verkiezingId " +
                "JOIN Partij pt on pt.PartijId = ur.PartijId " +
                "JOIN PoliticusInPartij pip on pip.PartijId = ur.PartijId " +
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
                        results.Add(new ElectionResult(new Party(reader["PartijNaam"].ToString(), reader["Partij"].ToString(), new Politician(reader["Naam"].ToString(), (Int32)reader["PoliticusId"]), (Int32)reader["PartijId"]), (Int32)reader["Stemmen"], Convert.ToDouble(reader["Percentage"]), (Int32)reader["Zetels"], (Int32)reader["UitslagId"]));
                    }
                }
            }
            return results;
        }

        public List<Politician> LoadAllPoliticians()
        {
            List<Politician> politicians = new List<Politician>();
            string sql = "SELECT* FROM Politicus";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        politicians.Add(new Politician(reader["Naam"].ToString(), (Int32)reader["PoliticusId"]));
                    }
                }
            }
            return politicians;
        }

        public void UpdateParty(Party newParty, string oldParty)
        {
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand("NieuwePartij", db);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@partij", newParty.Abbreviation));
                cmd.Parameters.Add(new SqlParameter("@partijNaam", newParty.Name));
                cmd.Parameters.Add(new SqlParameter("@lijsttrekker", newParty.LeadCandidate.Name));
                cmd.Parameters.Add(new SqlParameter("@oldPartij", oldParty));

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateResult(ElectionResult result)
        {
            string sql = "UPDATE UitslagRegel " +
                "SET Stemmen = @stemmen, Percentage = @percentage, Zetels = @zetels " +
                "WHERE UitslagId = @id";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                cmd.Parameters.Add(new SqlParameter("@id", result.ResultId));
                cmd.Parameters.Add(new SqlParameter("@stemmen", result.Votes));
                cmd.Parameters.Add(new SqlParameter("@percentage", result.Percentage));
                cmd.Parameters.Add(new SqlParameter("@zetels", result.Seats));

                cmd.ExecuteNonQuery();
            }
        }

        public void NewCoalition(Coalition coalition)
        {
            string sql = "INSERT INTO Coalitie(PremierId, Naam, Meerderheid) " +
                "OUTPUT Inserted.CoalitieId " +
                "VALUES(@id, @name, @mayority)";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                cmd.Parameters.Add(new SqlParameter("@id", coalition.Premier.Id));
                cmd.Parameters.Add(new SqlParameter("@name", coalition.Name));
                cmd.Parameters.Add(new SqlParameter("@mayority", coalition.Mayority));
                coalition.Id = (Int32)cmd.ExecuteScalar();
            }
            foreach (ElectionResult party in coalition.Parties)
            {
                string sql2 = "INSERT INTO CoalitiePartij(CoalitieId, PartijId) " +
                                "VALUES(@cId, @pId)";
                using (var db = new SqlConnection(connectionString))
                {
                    db.Open();
                    SqlCommand cmd = new SqlCommand(sql2, db);
                    cmd.Parameters.Add(new SqlParameter("@cId", coalition.Id));
                    cmd.Parameters.Add(new SqlParameter("@pId", party.Party.Id));

                    cmd.ExecuteNonQuery();
                }
            }
            
        }

        public List<Coalition> LoadAllCoalitions()
        {
            List<Coalition> coalitions = new List<Coalition>();
            string sql = "SELECT * FROM Coalitie";
            using (var db = new SqlConnection(connectionString))
            {
                db.Open();
                SqlCommand cmd = new SqlCommand(sql, db);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        coalitions.Add(new Coalition()
                        {
                            Id = (Int32)reader["CoalitieId"],
                            Name = reader["Naam"].ToString(),
                            Mayority = (bool)reader["Meerderheid"],
                            Premier = new Politician((Int32)reader["PremierId"], this)
                        });
                    }
                }

                foreach (Coalition coalition in coalitions)
                {
                    string sql2 = "SELECT * FROM CoalitiePartij WHERE CoalitieId = @id";
                    SqlCommand cmd2 = new SqlCommand(sql2, db);
                    cmd2.Parameters.Add(new SqlParameter("@id", coalition.Id));
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string electionName = "Tweede Kamer";
                            coalition.ElectionName = electionName;
                            foreach (ElectionResult res in this.LoadResultsForElection(new Election(electionName, 150)))
                            {
                                if (res.Party.Id == (Int32)reader["PartijId"])
                                {
                                    coalition.Parties.Add(res);
                                }
                            }
                            coalition.SelectPremier();
                            
                        }
                    }
                }
                
            }
            return coalitions;
        }
    }
}
