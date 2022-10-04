using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Abstract
{
    public interface IInterestService
    {
        List<Interest> Gelist();
        void Add(Interest interest);
        void Update(Interest interest);
        Interest GetById(int id);
        void Delete(int id);
    }
}
