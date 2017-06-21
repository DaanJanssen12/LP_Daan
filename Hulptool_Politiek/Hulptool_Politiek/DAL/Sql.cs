﻿using System;
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
            string sql = "SELECT p.Naam, pt.Partij, pt.PartijNaam " +
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
                        parties.Add(new Party(reader["PartijNaam"].ToString(), reader["Partij"].ToString(), new Politician(reader["Naam"].ToString())));
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
            string sql = "SELECT ur.Stemmen, ur.Percentage, ur.Zetels, pt.Partij, pt.PartijNaam, p.Naam " +
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
                        results.Add(new ElectionResult(new Party(reader["PartijNaam"].ToString(), reader["Partij"].ToString(), new Politician(reader["Naam"].ToString())), (Int32)reader["Stemmen"], Convert.ToDouble(reader["Percentage"]), (Int32)reader["Zetels"]));
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
                        politicians.Add(new Politician(reader["Naam"].ToString()));
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
    }
}
