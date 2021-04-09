using Core.Entites.Concrete;
using Core.Ultities;
using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IResult Add(User user);
        IResult Delete(User user);


        IResult Update(User user);
        IDataResult<List<User>> GetAllUsers();
        IDataResult<List<User>> GetByEmail(string email);
        IDataResult<List<User>> GetByUserId(int id);
        //IDataResult<User> GetByMail(string email);
       
       


    }
}
