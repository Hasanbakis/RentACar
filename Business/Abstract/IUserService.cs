using Core.Entites.Concrete;
using Core.Ultities;
using Core.Ultities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
      
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
      

    }
}
