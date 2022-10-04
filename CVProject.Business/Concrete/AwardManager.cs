using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Concrete
{
    public class AwardManager : IAwardService
    {
        private IAwardDal _awardDal;
        public AwardManager(IAwardDal awardDal)
        {
            _awardDal = awardDal;
        }

        public void Add(Award award)
        {
            _awardDal.Add(award);
        }

        public void Delete(int id)
        {
            _awardDal.Delete(GetById(id));
        }

        public List<Award> Gelist()
        {
            return _awardDal.GetList();
        }

        public Award GetById(int id)
        {
            return _awardDal.Get(a=>a.AwardId == id);
        }

        public void Update(Award award)
        {
            _awardDal.Update(award);
        }
    }
}
