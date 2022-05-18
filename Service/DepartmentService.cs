using Domain;
using Dapper;
using Npgsql;

namespace Service;

public class DepartmentService : IDepartmentService
{
    private string connectionString = "Server=127.0.0.1;Port=5432;Database=Enteprise;User Id=postgres;Password=Qwert!@#098;";

    private NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection (connectionString);
    }
    public Department GetDepartmentById(int Id)
    {
        using (var conn = GetConnection())
        {
            var sql = $"select d.name as DepartmentName, d.id as DepartmentId, concat(e.firsname,' ',e.lastname) as ManagerFullName,e.id as ManagerId from department d left join departmentmanager dm on dm.departmentid = d.id left join employee e on e.id = dm.employeeid where d.id = {Id};";
            var result = conn.QuerySingleOrDefault<Department>(sql);

            return result;
        }
    }

    public int InsertDepartment(InsertDepartment department)
    {
        using (var conn = GetConnection())
        {
            var sql = $"insert into department (Name)" + 
                      $"values ('{department.Name}')";
            var result = conn.Execute(sql);

            return result;
        }
    }

    public int UpdateDepartment(InsertDepartment department, int Id)
    {
         using (var conn = GetConnection())
        {
            var sql = $"update department set " + 
                      $"Name = '{department.Name}' " +
                      $"where id = {Id}";
            var result = conn.Execute(sql);

            return result;
        }
    }

    public List<Department> GetDepartmentList()
    {
        using (var conn = GetConnection())
        {
            var sql = $"select d.name as DepartmentName, d.id as DepartmentId, concat(e.firsname,' ',e.lastname) as ManagerFullName,e.id as ManagerId from department d left join departmentmanager dm on dm.departmentid = d.id left join employee e on e.id = dm.employeeid";
            var result = conn.Query<Department>(sql);
            
            return result.ToList();
        }
    }
}
