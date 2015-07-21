using DAL.Entites;

namespace DAL.Interfaces.Repositories
{
    public interface IUserRepository: IGenericRepository<User>
    {
        User GetBy(string login);
    }
}
