using CVProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVProject.Entities.Concrete
{
    public class Interest : IEntity
    {
        [Key]
        public int InterestId { get; set; }
        public string Description { get; set; }
    }
}
