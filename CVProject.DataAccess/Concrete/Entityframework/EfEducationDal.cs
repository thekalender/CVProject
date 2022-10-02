using CVProject.Core.DataAccess.EntityFramework;
using CVProject.DataAccess.Abstract;
using CVProject.DataAccess.Concrete.Entityframework.Context;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.DataAccess.Concrete.Entityframework
{
    public class EfEducationDal : EfEntityBaseRepository<Education, NorthwindContext>, IEducationDal
    {
    }
}
