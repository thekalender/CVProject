using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Abstract
{
    public interface IAwardService
    {
        List<Award> Gelist();
        void Add(Award award);
        void Update(Award award);
        Award GetById(int id);
        void Delete(int id);
    }
}
