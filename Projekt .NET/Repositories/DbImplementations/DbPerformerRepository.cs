using Microsoft.Data.SqlClient;

using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;
using System.Data;

namespace Projekt_.NET.Repositories.DbImplementations
{
    public class DbPerformerRepository : IPerformerRepository
    {
        public IConfiguration _configuration { get; }
        public DbPerformerRepository(IConfiguration _configuration) 
        {
            this._configuration = _configuration;
        }
        public void Add(Performer performer)
        {

            string connect = _configuration.GetConnectionString("DataBase");
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("performer_add1", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Dodaj parametry
            //cmd.Parameters.AddWithValue("@Id", performer.Id);
            cmd.Parameters.AddWithValue("@Name", performer.Name);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Delete(int id)
        {
            string connect = _configuration.GetConnectionString("DataBase");
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("performer_delete", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public Performer GetOne(int id)
        {
            Performer performer = new Performer();
            string connect = _configuration.GetConnectionString("DataBase");
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("performer_select_one", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                performer.Id = (int)reader["Id"];
                performer.Name = reader["Name"].ToString();
            }

            //cmd.ExecuteNonQuery();
            reader.Close();
            con.Close();
            return performer;
        }

        public List<Performer> GetAll()
        {
            List <Performer> performers = new List<Performer>();

            string connect = _configuration.GetConnectionString("DataBase");
            SqlConnection con = new SqlConnection(connect);

            SqlCommand cmd = new SqlCommand("performer_select_all", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Performer performer = new Performer();
                performer.Id = (int)reader["Id"];
                performer.Name = reader["Name"].ToString();
                performers.Add(performer);
            }

            //cmd.ExecuteNonQuery();
            reader.Close();
            con.Close();

            return performers;
        }
    }
}
