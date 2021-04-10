using Core.Ultities;
using Core.Ultities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICardService
    {
        IResult Add(Card card);
        IResult Update(Card card);
        IResult Delete(Card card);
        IDataResult<List<Card>> GetAll();
        IDataResult<List<Card>> GetByCustomer(int id);
        
    }
}
