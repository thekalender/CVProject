using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Concrete
{
    public class InterestManager : IInterestService
    {
       private IInterestDal _ınterestDal;
        public InterestManager(IInterestDal ınterestDal)
        {
            _ınterestDal = ınterestDal;
        }
    
        public void Add(Interest interest)
        {
            _ınterestDal.Add(interest);
        }

        public void Delete(int id)
        {
            _ınterestDal.Delete(GetById(id));
        }

        public List<Interest> Gelist()
        {
            return _ınterestDal.GetList();
        }

        public Interest GetById(int id)
        {
            return _ınterestDal.Get(i => i.InterestId == id);
        }

        public void Update(Interest interest)
        {
            _ınterestDal.Update(interest);
        }
    }
}
