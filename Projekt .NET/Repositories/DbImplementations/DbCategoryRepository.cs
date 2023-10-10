using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Projekt_.NET.Context;
using Projekt_.NET.Models;
using Projekt_.NET.Repositories.Interfaces;
using Projekt_.NET.Services.Interfaces;

namespace Projekt_.NET.Repositories.DbImplementations
{
    public class DbCategoryRepository : ICategoryRepository
    {
        public IConfiguration _configuration { get; }
        public DbCategoryRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void Add(Category category)
        {
            string connect = _configuration.GetConnectionString("DataBase");

            SqlConnection con = new SqlConnection(connect);
            string sql = "INSERT INTO Categories (Name) VALUES (@Name)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Name", category.Name);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            string connect = _configuration.GetConnectionString("DataBase");

            SqlConnection con = new SqlConnection(connect);
            string sql = "DELETE FROM Categories WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public Category GetOne(int id)
        {
            Category category = new Category();
            string connect = _configuration.GetConnectionString("DataBase");

            SqlConnection con = new SqlConnection(connect);
            string sql = "SELECT * FROM Categories WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                category = new Category();
                category.Id = reader["Id"] as int? ?? 0;
                category.Name = reader["Name"].ToString();
            }

            reader.Close();
            con.Close();

            return category;  
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();

            string connect = _configuration.GetConnectionString("DataBase");

            SqlConnection con = new SqlConnection(connect);
            string sql = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(sql, con);

            //cmd.Parameters.AddWithValue("@Id", id);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Category category = new Category();
                category.Id = reader["Id"] as int? ?? 0;
                category.Name = reader["Name"].ToString();
                categories.Add(category);
            }

            reader.Close();
            con.Close();

            return categories;
        }
    }
}
