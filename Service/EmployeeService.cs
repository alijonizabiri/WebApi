using Domain;
using Dapper;
using Npgsql;

namespace Service;

public class EmployeeService : IEmployeeService
{

    private string connectionString = "Server=127.0.0.1;Port=5432;Database=Enteprise;User Id=postgres;Password=Qwert!@#098;";


    private NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection (connectionString);
    }

    public Employee GetEmployeeById(int Id)
    {
        using (var conn = GetConnection())
        {
            var sql = $"select e.id as Id, concat(e.firsname,' ',e.lastname) as Fullname, d.id as DepartmentId, d.name as DepartmentName from employee e join department d on e.id = d.id where e.id = {Id}";
            var result = conn.QuerySingleOrDefault<Employee>(sql);

            return result;
        }
    }

    public int InsertEmployee(InsertEmployee employee)
    {
        using (var conn = GetConnection())
        {
            var sql = $"insert into employee (BirthDate, FirsName, LastName, Gender, HireDate)" + 
                      $"values ('{employee.BirthDate}', '{employee.FirsName}', '{employee.LastName}', '{employee.Gender}', '{employee.HireDate}')";
            var result = conn.Execute(sql);

            return result;
        }
    }

    public int UpdateEmployee(InsertEmployee employee, int Id)
    {
         using (var conn = GetConnection())
        {
            var sql = $"update employee set " + 
                      $"BirthDate = '{employee.BirthDate}'," +
                      $"FirsName = '{employee.FirsName}'," + 
                      $"LastName = '{employee.LastName}'," +
                      $"Gender = '{employee.Gender}'," + 
                      $"HireDate = '{employee.HireDate}'" + 
                      $" where Id = {Id}";
            var result = conn.Execute(sql);

            return result;
        }
    }



    public List<Employee> GetEmployees()
    {
        using (var conn = GetConnection())
        {
            var sql = $"select e.id as Id, concat(e.firsname,' ',e.lastname) as Fullname, d.id as DepartmentId, d.name as DepartmentName from employee e join department d on e.id = d.id order by id";
            var result = conn.Query<Employee>(sql);
            
            return result.ToList();
        }
    }
}
