using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Concrete
{
    public class EducationManager : IEducationService
    {
        private IEducationDal _educationDal;
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void Add(Education education)
        {
            _educationDal.Add(education);
        }

        public void Delete(int id)
        {
            _educationDal.Delete(GetById(id));
        }

        public List<Education> Gelist()
        {
            return _educationDal.GetList();
        }

        public Education GetById(int id)
        {
            return _educationDal.Get(e => e.EducaitonId == id);
        }

        public void Update(Education education)
        {
            _educationDal.Update(education);
        }
    }
}
