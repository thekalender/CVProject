using CVProject.Core.DataAccess;
using CVProject.Core.DataAccess.EntityFramework;
using CVProject.DataAccess.Abstract;
using CVProject.DataAccess.Concrate.ContextLibrary;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.DataAccess.Concrate.EntityFramework
{
    public class EfAboutDal : EfEntityBaseRepository<About,CVProjectContext>,IAboutDal
    {
    }
}
