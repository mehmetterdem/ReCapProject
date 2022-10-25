using Core.DataAccess;
using CoreLayer.Entities.Concrete;
using System.Collections.Generic;


namespace DataAccessLayer.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
