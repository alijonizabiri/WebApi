namespace Service;
using Dapper;
using Domain;
using Npgsql;
public class ManagerService : IManagerService
{
    private string connectionString = "Server=127.0.0.1;Port=5432;Database=Enteprise;User Id=postgres;Password=Qwert!@#098;";

    private NpgsqlConnection GetConnection()
    {
        return new NpgsqlConnection (connectionString);
    }

    public int InsertManager(InsertManager manager)
    {
        using (var conn = GetConnection())
        {
            var sql = $"insert into departmentmanager ( EmployeeId, DepartmentId, FromDate, ToDate ) " + 
                      $" values  ({manager.EmployeeId}, {manager.DepartmentId}, '{manager.FromDate}', '{manager.ToDate}')";
            var result = conn.Execute(sql);

            return result;  
        }
    }


    public List<Manager> GetManagers()
    {
        using (var conn = GetConnection())
        {
            var sql = $"select e.id as ManagerId, concat(e.firsname,' ', e.lastname) as ManagerFullName, d.id as DepartmentId, d.name as DepartmentName, m.fromdate as FromDate, m.todate as Todate " +
                      $"from departmentmanager as m "+
                      $"join department as d on m.departmentid = d.id " +
                      $"join employee as e on m.employeeid = e.id";
            var result = conn.Query<Manager>(sql);
            
            return result.ToList();
        }
    }
}
