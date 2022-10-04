using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Abstract
{
    public interface ISkillService
    {
        List<Skill> Gelist();
        void Add(Skill skill);
        void Update(Skill skill);
        Skill GetById(int id);
        void Delete(int id);
    }
}
