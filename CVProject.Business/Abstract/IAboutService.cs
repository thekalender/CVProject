using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Abstract
{
    public interface IAboutService
    {
        List<About> Gelist();
        void Add(About about);
        void Update(About about);
        About GetById(int id);
        void Delete(int id);
    }
}
