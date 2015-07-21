using DAL.Entites;

namespace DAL.Interfaces.Repositories
{
    public interface IUserRepository: IGenericRepository<DalUser>
    {
        DalUser GetBy(string login);
    }
}
