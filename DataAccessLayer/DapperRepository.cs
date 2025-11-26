using bus;
using DataAccessLayer;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Dapper;

public class DapperRepository : IRepository<Student>
{
    private readonly string _connectionString =
        @"Data Source=(LocalDB)\MSSQLLocalDB;
          Initial Catalog=Students;
          Integrated Security=True";

    public void Create(Student entity)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Execute(
            "INSERT INTO Students (Id, Name, Speciality, [Group]) VALUES (@Id, @Name, @Speciality, @Group)",
            entity);
    }

    public IEnumerable<Student> ReadAll()
    {
        using var connection = new SqlConnection(_connectionString);
        return connection.Query<Student>("SELECT Id, Name, Speciality, [Group] FROM Students");
    }

    public Student ReadById(string id)
    {
        using var connection = new SqlConnection(_connectionString);
        return connection.QuerySingleOrDefault<Student>(
            "SELECT Id, Name, Speciality, [Group] FROM Students WHERE Id = @Id",
            new { Id = id });
    }

    public void Update(Student entity)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Execute(
            "UPDATE Students SET Name=@Name, Speciality=@Speciality, [Group]=@Group WHERE Id=@Id",
            entity);
    }

    public void Delete(string id)
    {
        using var connection = new SqlConnection(_connectionString);
        connection.Execute("DELETE FROM Students WHERE Id = @Id", new { Id = id });
    }
}


