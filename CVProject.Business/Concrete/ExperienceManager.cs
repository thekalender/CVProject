using CVProject.Business.Abstract;
using CVProject.DataAccess.Abstract;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.Business.Concrete
{
    public class ExperienceManager : IExperienceService
    {
        IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience experience)
        {
            _experienceDal.Add(experience);
        }

        public void Delete(int id)
        {
            _experienceDal.Delete(GetById(id));
        }

        public List<Experience> Gelist()
        {
            return _experienceDal.GetList();
        }

        public Experience GetById(int id)
        {
            return _experienceDal.Get(e => e.ExperienceId == id);
        }

        public void Update(Experience experience)
        {
            _experienceDal.Update(experience);
        }
    }
}
