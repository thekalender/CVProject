﻿using CVProject.Core.DataAccess.EntityFramework;
using CVProject.DataAccess.Abstract;
using CVProject.DataAccess.Concrate.ContextLibrary;
using CVProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVProject.DataAccess.Concrate.EntityFramework
{
    public class EfAwardDal : EfEntityBaseRepository<Award,CVProjectContext>,IAwardDal
    {
    }
}
