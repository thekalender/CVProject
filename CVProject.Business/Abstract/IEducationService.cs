using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Abstract
{
    public interface IEducationService
    {
        List<Education> Gelist();
        void Add(Education education);
        void Update(Education education);
        Education GetById(int id);
        void Delete(int id);
    }
}
