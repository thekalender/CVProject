using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.DataAccess.Concrate.EntityFramework;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
            _aboutDal.Add(about);
        }

        public void Delete(int id)
        {
            _aboutDal.Delete(GetById(id));
        }

        public List<About> Gelist()
        {
            return _aboutDal.GetList();
        }

        public About GetById(int id)
        {
            return _aboutDal.Get(about=>about.AboutId==id);
        }

        public void Update(About about)
        {
            _aboutDal.Update(about);
        }
    }
}
