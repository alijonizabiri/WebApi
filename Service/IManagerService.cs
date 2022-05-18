using Domain;

public interface IManagerService
{
    public int InsertManager(InsertManager manager);
    public List<Manager> GetManagers();
}