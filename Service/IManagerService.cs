using Domain;

public interface IManagerService
{
    public Task<int> InsertManager(InsertManager manager);
    public Task<List<Manager>> GetManagers();
}