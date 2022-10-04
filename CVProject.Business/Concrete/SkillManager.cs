using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Concrete
{
    public class SkillManager:ISkillService
    {
        private ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
    
        public List<Skill> Gelist()
        {
            return _skillDal.GetList();
        }

        public void Add(Skill skill)
        {
            _skillDal.Add(skill);
        }

        public void Update(Skill skill)
        {
           _skillDal.Update(skill);
        }

        public Skill GetById(int id)
        {
            return _skillDal.Get(s => s.SkillId == id);
        }

        public void Delete(int id)
        {
            _skillDal.Delete(GetById(id));
        }

    }
}
