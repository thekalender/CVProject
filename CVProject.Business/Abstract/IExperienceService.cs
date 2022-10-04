using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Abstract
{
    public interface IExperienceService
    {
        List<Experience> Gelist();
        void Add(Experience experience);
        void Update(Experience experience);
        Experience GetById(int id);
        void Delete(int id);
    }
}
